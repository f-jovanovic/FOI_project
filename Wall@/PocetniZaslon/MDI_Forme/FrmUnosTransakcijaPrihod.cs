using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon.MDI_Forme
{
    public partial class FrmUnosTransakcijaPrihod : Form
    {
        Korisnik trenutniKorisnik = null;
        UpravljanjeTransakcijom dodavanjeTransakcije = new UpravljanjeTransakcijom();

        public FrmUnosTransakcijaPrihod(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

        /// <summary>
        /// Kod pokretanja forme UnosTransakcija učitaj bankovne račune trenutnog korisnika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUnosTransakcijaPrihod_Load(object sender, EventArgs e)
        {
            lblNeispravanIznos.Hide();
            btnSpremiTransakcijuPrihod.Enabled = false;
            btnIzbrisiKategorijuPrihod.Enabled = false;
            DohvatiPodatke();
        }

        /// <summary>
        /// Dohvati podatke o bankovnim računima i kategorijama na formu.
        /// </summary>
        private void DohvatiPodatke()
        {
            chkKategorijePrihod.Items.Clear();

            BindingList<Bankovni_racun> listBankovniRacuni = null;

            using (WalletEntities db = new WalletEntities())
            {
                db.Korisnik.Attach(trenutniKorisnik);
                listBankovniRacuni = new BindingList<Bankovni_racun>(trenutniKorisnik.Bankovni_racun.ToList());

                foreach (var item in db.Kategorije_transakcije.ToList())
                {
                    if (item.id_vrsta_transakcije == 1 && (item.id_korisnik == trenutniKorisnik.id_korisnik || item.Korisnik == null)) chkKategorijePrihod.Items.Add(item.naziv_kategorije);
                }
            }

            bankovniracunBindingSource.DataSource = listBankovniRacuni;
        }

        /// <summary>
        /// Poziva se metoda za unos transakcije, i daje joj se idVrstaTransakcije 1(prihod), te se označene kategorije spremaju u listu i također proslijeđuju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremiTransakcijuPrihod_Click(object sender, EventArgs e)
        {
            List<string> listKategorijePrihod = new List<string>();

            if (chkKategorijePrihod.CheckedItems.Count == 0)
            {
                listKategorijePrihod.Add("Ostali prihodi");
            }
            else
            {
                foreach (var item in chkKategorijePrihod.CheckedItems)
                {
                    listKategorijePrihod.Add(item.ToString());
                }
            }

            dodavanjeTransakcije.DodajTransakciju(1, bankovniracunBindingSource, txtIznosPrihod.Text, dtpDatumTransakcijePrihod.Value.Date + dtpVrijemeTransakcijePrihod.Value.TimeOfDay, txtOpisPrihod.Text, listKategorijePrihod, null);
                        
            MessageBox.Show("Transakcija uspješno unesena!");

            // Prolazi se kroz sve kontrole glavne forme, i izvršava se click na gumb UnosTransakcije.
            foreach (Control kontrole in this.MdiParent.Controls)
            {
                if (kontrole.GetType() == typeof(Button) && kontrole.Name == "btnUnosTransakcije") (kontrole as Button).PerformClick();
            }

        }

        #region Upravljanje kategorijama
        private void btnDodajKategorijuPrihod_Click(object sender, EventArgs e)
        {
            Dialog_forme.FrmKategorijeTransakcijaDodaj frmDodajKategorijuPrihod = new Dialog_forme.FrmKategorijeTransakcijaDodaj(trenutniKorisnik, 1, null);
            frmDodajKategorijuPrihod.ShowDialog();
            DohvatiPodatke();
        }

        private void btnUrediKategorijuPrihod_Click(object sender, EventArgs e)
        {
            if (chkKategorijePrihod.CheckedItems.Count != 1) MessageBox.Show("Potrebno je označiti točno jednu kategoriju za uređivanje!");

            else if (chkKategorijePrihod.CheckedItems.Count == 1 && chkKategorijePrihod.CheckedItems[0].ToString() == "Ostali prihodi") MessageBox.Show("Odabranu kategoriju nije moguće uređivati!");

            else
            {
                Kategorije_transakcije kategorija = null;
                using (WalletEntities db = new WalletEntities())
                {
                    foreach (var item in chkKategorijePrihod.CheckedItems)
                    {
                        kategorija = (from t in db.Kategorije_transakcije
                                      where t.naziv_kategorije == item.ToString() && t.id_vrsta_transakcije == 1
                                      select t).First();
                    }
                }

                Dialog_forme.FrmKategorijeTransakcijaDodaj frmUrediKategoriju = new Dialog_forme.FrmKategorijeTransakcijaDodaj(trenutniKorisnik, 1, kategorija);
                frmUrediKategoriju.ShowDialog();

                // iz nekog razloga podaci se updateaju jedino kad je ovo ovdje pozvano... bilo gdje izvan, identičan kod, kad ga se pozove ne prikaže novi naziv :(
                chkKategorijePrihod.Items.Clear();
                using (var db = new WalletEntities())
                {
                    foreach (var item in db.Kategorije_transakcije.ToList())
                    {
                        if (item.id_vrsta_transakcije == 1 && (item.id_korisnik == trenutniKorisnik.id_korisnik || item.Korisnik == null)) chkKategorijePrihod.Items.Add(item.naziv_kategorije);
                    }
                }
            }
        }

        /// <summary>
        /// Brišu se sve odabrane kategorije, osim one koja je default (Ostali prihodi), te se miču i iz povezanih transakcija.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzbrisiKategorijuPrihod_Click(object sender, EventArgs e)
        {
            if (chkKategorijePrihod.CheckedItems.Count != 0)
            {
                using (WalletEntities db = new WalletEntities())
                {
                    foreach (Kategorije_transakcije kategorija in db.Kategorije_transakcije)
                    {
                        foreach (var odabranaKategorija in chkKategorijePrihod.CheckedItems)
                        {
                            if (kategorija.naziv_kategorije == odabranaKategorija.ToString() && kategorija.id_vrsta_transakcije == 1 && kategorija.id_korisnik == trenutniKorisnik.id_korisnik)
                            {
                                if (kategorija.Transakcija.Count == 0) db.Kategorije_transakcije.Remove(kategorija);
                                else
                                {
                                    foreach (Transakcija transakcija in db.Transakcija)
                                    {
                                        if (transakcija.Kategorije_transakcije.Contains(kategorija)) transakcija.Kategorije_transakcije.Remove(kategorija);
                                        kategorija.Transakcija.Remove(transakcija);

                                        if (transakcija.Kategorije_transakcije.Count == 0) transakcija.Kategorije_transakcije.Add((from t in db.Kategorije_transakcije
                                                                                                                                   where t.id_kategorije_transakcije == 1
                                                                                                                                   select t).First());
                                    }
                                }
                            }
                        }
                    }

                    db.SaveChanges();
                }
            }
            DohvatiPodatke();
        }

        private void chkKategorijePrihod_MouseUp(object sender, MouseEventArgs e)
        {
            if (chkKategorijePrihod.CheckedItems.Count > 0) btnIzbrisiKategorijuPrihod.Enabled = true;
            else btnIzbrisiKategorijuPrihod.Enabled = false;

            if (chkKategorijePrihod.CheckedItems.Count != 1) btnUrediKategorijuPrihod.Enabled = false;
            else btnUrediKategorijuPrihod.Enabled = true;
        }
        #endregion

        /// <summary>
        /// Provjera ispravnosti unesenog iznosa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIznosPrihod_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIznosPrihod.ToString()))
            {
                decimal iznosProvjera;
                if (decimal.TryParse(txtIznosPrihod.Text, out iznosProvjera) && iznosProvjera != 0)
                {
                    lblNeispravanIznos.Hide();
                    btnSpremiTransakcijuPrihod.Enabled = true;
                }
                else
                {
                    lblNeispravanIznos.Show();
                    btnSpremiTransakcijuPrihod.Enabled = false;
                }
            }
            else btnSpremiTransakcijuPrihod.Enabled = false;
        }

		private void FrmUnosTransakcijaPrihod_HelpRequested(object sender, HelpEventArgs hlpevent)
		{
			string keyword = "prihod";
			Help.ShowHelp(this, @"C:\Users\Luna\Desktop\Korisnicka.chm", HelpNavigator.TopicId, keyword);
		}
	}
}
