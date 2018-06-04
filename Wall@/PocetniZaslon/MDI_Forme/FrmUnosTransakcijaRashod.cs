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
        /// Klikom na gumb Spremi transakcija se unosi, i vežu se svi potrebni ključevi na nju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremiTransakcijuRashod_Click(object sender, EventArgs e)
        {
            using (WalletEntities db = new WalletEntities())
            {
                db.Bankovni_racun.Attach(bankovniracunBindingSource.Current as Bankovni_racun);

                Transakcija noviRashod = new Transakcija
                {
                    Bankovni_racun = bankovniracunBindingSource.Current as Bankovni_racun,
                    iznos_transakcije = decimal.Parse(txtIznosRashod.Text.ToString()),
                    vrijeme_transakcije = dtpDatumTransakcijeRashod.Value.Date + dtpVrijemeTransakcijeRashod.Value.TimeOfDay,
                    opis_transakcije = txtOpisRashod.Text.ToString()
                };

                //Dodavanje ključeva na kolekcije unutar kategorija i transakcije
                foreach (var item in chkKategorijeRashod.CheckedItems)
                {
                    Kategorije_transakcije dodajKategoriju = (from t in db.Kategorije_transakcije
                                                              where t.naziv_kategorije == item.ToString() && t.id_vrsta_transakcije == 2
                                                              select t).First();

                    noviRashod.Kategorije_transakcije.Add(dodajKategoriju);
                }

                foreach (var item in chkKategorijeRashod.CheckedItems)
                {
                    foreach (var kategorija in db.Kategorije_transakcije.ToList())
                    {
                        if (kategorija.naziv_kategorije.ToString() == item.ToString()) kategorija.Transakcija.Add(noviRashod);
                    }
                }

                foreach (Bankovni_racun racun in db.Bankovni_racun)
                {
                    if (racun == bankovniracunBindingSource.Current) racun.stanje_racuna -= noviRashod.iznos_transakcije;
                }

                db.Transakcija.Add(noviRashod);
                db.SaveChanges();
            }

            RefreshPodaci();

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
    }
}
