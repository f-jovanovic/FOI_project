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
    public partial class FrmUnosTransakcijaRashod : Form
    {
        Korisnik trenutniKorisnik = null;
        UpravljanjeTransakcijom dodavanjeTransakcije = new UpravljanjeTransakcijom();

        string lokacijaSlike = null;

        public FrmUnosTransakcijaRashod(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

        /// <summary>
        /// Kod pokretanja forme UnosTransakcija učitaj bankovne račune trenutnog korisnika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUnosTransakcijaTrosak_Load(object sender, EventArgs e)
        {
            lblNeispravanIznosRashod.Hide();
            btnSpremiTransakcijuRashod.Enabled = false;
            btnIzbrisiKategorijuRashod.Enabled = false;
            btnSkenirajBarkodRashod.Enabled = false;
            RefreshPodaci();
        }

        /// <summary>
        /// Dohvati podatke o bankovnim računima i kategorijama na formu.
        /// </summary>
        private void RefreshPodaci()
        {
            chkKategorijeRashod.Items.Clear();

            BindingList<Bankovni_racun> listBankovniRacuni = null;

            using (WalletEntities db = new WalletEntities())
            {
                db.Korisnik.Attach(trenutniKorisnik);
                listBankovniRacuni = new BindingList<Bankovni_racun>(trenutniKorisnik.Bankovni_racun.ToList());

                foreach (var item in db.Kategorije_transakcije.ToList())
                {
                    if (item.id_vrsta_transakcije == 2 && (item.id_korisnik == trenutniKorisnik.id_korisnik || item.Korisnik == null)) chkKategorijeRashod.Items.Add(item.naziv_kategorije);
                }
            }

            bankovniracunBindingSource.DataSource = listBankovniRacuni;
        }

        /// <summary>
        /// Poziva se metoda za unos transakcije, i daje joj se idVrstaTransakcije 2(rashod), te se označene kategorije spremaju u listu i također proslijeđuju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremiTransakcijuRashod_Click(object sender, EventArgs e)
        {
            List<string> listKategorijeRashod = new List<string>();

            if (chkKategorijeRashod.CheckedItems.Count == 0)
            {
                listKategorijeRashod.Add("Ostali rashodi");
            }
            else
            {
                foreach (var item in chkKategorijeRashod.CheckedItems)
                {
                    listKategorijeRashod.Add(item.ToString());
                }
            }

            dodavanjeTransakcije.DodajTransakciju(2, bankovniracunBindingSource, txtIznosRashod.Text, dtpDatumTransakcijeRashod.Value.Date + dtpVrijemeTransakcijeRashod.Value.TimeOfDay, txtOpisRashod.Text, listKategorijeRashod, lokacijaSlike);

            MessageBox.Show("Transakcija uspješno unesena!");

            // Prolazi se kroz sve kontrole glavne forme, i izvršava se click na gumb UnosTransakcije.
            foreach (Control kontrole in this.MdiParent.Controls)
            {
                if (kontrole.GetType() == typeof(Button) && kontrole.Name == "btnUnosTransakcije") (kontrole as Button).PerformClick();
            }

        }

        #region Upravljanje kategorijama
        private void btnDodajKategorijuRashod_Click(object sender, EventArgs e)
        {
            Dialog_forme.FrmKategorijeTransakcijaDodaj frmDodajKategorijuPrihod = new Dialog_forme.FrmKategorijeTransakcijaDodaj(trenutniKorisnik, 2, null);
            frmDodajKategorijuPrihod.ShowDialog();
            RefreshPodaci();
        }

        private void btnUrediKategorijuRashod_Click(object sender, EventArgs e)
        {
            if (chkKategorijeRashod.CheckedItems.Count != 1) MessageBox.Show("Potrebno je označiti točno jednu kategoriju za uređivanje!");

            else if (chkKategorijeRashod.CheckedItems.Count == 1 && chkKategorijeRashod.CheckedItems[0].ToString() == "Ostali rashodi") MessageBox.Show("Odabranu kategoriju nije moguće uređivati!");

            else
            {
                Kategorije_transakcije kategorija = null;
                using (WalletEntities db = new WalletEntities())
                {
                    foreach (var item in chkKategorijeRashod.CheckedItems)
                    {
                        kategorija = (from t in db.Kategorije_transakcije
                                      where t.naziv_kategorije == item.ToString() && t.id_vrsta_transakcije == 2
                                      select t).First();
                    }
                }

                Dialog_forme.FrmKategorijeTransakcijaDodaj frmUrediKategoriju = new Dialog_forme.FrmKategorijeTransakcijaDodaj(trenutniKorisnik, 2, kategorija);
                frmUrediKategoriju.ShowDialog();

                // iz nekog razloga podaci se updateaju jedino kad je ovo ovdje pozvano... bilo gdje izvan, identičan kod, kad ga se pozove ne prikaže novi naziv :(
                chkKategorijeRashod.Items.Clear();
                using (var db = new WalletEntities())
                {
                    foreach (var item in db.Kategorije_transakcije.ToList())
                    {
                        if (item.id_vrsta_transakcije == 2 && (item.id_korisnik == trenutniKorisnik.id_korisnik || item.Korisnik == null)) chkKategorijeRashod.Items.Add(item.naziv_kategorije);
                    }
                }
            }
        }

        /// <summary>
        /// Brišu se sve odabrane kategorije, osim one koja je default (Ostali rashodi), te se miču i iz povezanih transakcija.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzbrisiKategorijuRashod_Click(object sender, EventArgs e)
        {
            if (chkKategorijeRashod.CheckedItems.Count != 0)
            {
                using (WalletEntities db = new WalletEntities())
                {
                    foreach (Kategorije_transakcije kategorija in db.Kategorije_transakcije)
                    {
                        foreach (var odabranaKategorija in chkKategorijeRashod.CheckedItems)
                        {
                            if (kategorija.naziv_kategorije == odabranaKategorija.ToString() && kategorija.id_vrsta_transakcije == 2 && kategorija.id_korisnik == trenutniKorisnik.id_korisnik)
                            {
                                if (kategorija.Transakcija.Count == 0) db.Kategorije_transakcije.Remove(kategorija);
                                else
                                {
                                    foreach (Transakcija transakcija in db.Transakcija)
                                    {
                                        if (transakcija.Kategorije_transakcije.Contains(kategorija)) transakcija.Kategorije_transakcije.Remove(kategorija);
                                        kategorija.Transakcija.Remove(transakcija);

                                        if (transakcija.Kategorije_transakcije.Count == 0) transakcija.Kategorije_transakcije.Add((from t in db.Kategorije_transakcije
                                                                                                                                   where t.id_kategorije_transakcije == 2
                                                                                                                                   select t).First());
                                    }
                                }
                            }
                        }
                    }

                    db.SaveChanges();
                }
            }
            RefreshPodaci();
        }

        private void chkKategorijeRashod_MouseUp(object sender, MouseEventArgs e)
        {
            if (chkKategorijeRashod.CheckedItems.Count > 0) btnIzbrisiKategorijuRashod.Enabled = true;
            else btnIzbrisiKategorijuRashod.Enabled = false;

            if (chkKategorijeRashod.CheckedItems.Count != 1) btnUrediKategorijuRashod.Enabled = false;
            else btnUrediKategorijuRashod.Enabled = true;
        }
        #endregion

        #region Rad sa slikom računa
        /// <summary>
        /// Event koji sprema string sa lokacijom slike u program kako bi dodali sliku u bazu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajSlikuRashod_Click(object sender, EventArgs e)
        {
            if (ofdSlikaRacuna.ShowDialog() == DialogResult.OK)
            {
                lokacijaSlike = ofdSlikaRacuna.FileName.ToString();
                txtLokacijaSlikeRacuna.Text = lokacijaSlike;
            }
        }

        /// <summary>
        /// Klikom na gumb instancira se klasa za skeniranje, te se pokreće scan sa lokacije koja je unaprijed odabrana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkenirajBarkodRashod_Click(object sender, EventArgs e)
        {
            BarcodeScanner scanner = new BarcodeScanner();
            scanner.lokacijaSlikeRacuna = lokacijaSlike;

            scanner.SkenirajRacun();

            txtIznosRashod.Text = scanner.skeniraniIznos.ToString("F");
            txtOpisRashod.Text = scanner.skeniraniOpis;
        }

        /// <summary>
        /// Kontroliranje gumba za skeniranje ovisno o tome je li slika dodana ili ne.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLokacijaSlikeRacuna_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLokacijaSlikeRacuna.Text)) btnSkenirajBarkodRashod.Enabled = true;
            else btnSkenirajBarkodRashod.Enabled = false;
        }
        #endregion

        /// <summary>
        /// Provjera ispravnosti unesenog iznosa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIznosRashod_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIznosRashod.ToString()))
            {
                decimal iznosProvjera;
                if (decimal.TryParse(txtIznosRashod.Text, out iznosProvjera) && iznosProvjera != 0)
                {
                    lblNeispravanIznosRashod.Hide();
                    btnSpremiTransakcijuRashod.Enabled = true;
                }
                else
                {
                    lblNeispravanIznosRashod.Show();
                    btnSpremiTransakcijuRashod.Enabled = false;
                }
            }
            else btnSpremiTransakcijuRashod.Enabled = false;
        }

		private void FrmUnosTransakcijaRashod_HelpRequested(object sender, HelpEventArgs hlpevent)
		{
			string keyword = "trosak";
			Help.ShowHelp(this, @"C:\Users\Luna\Desktop\Korisnicka.chm", HelpNavigator.TopicId, keyword);
		}
	}
}
