﻿using System;
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
            lblNeispravanIznos.Hide();
            btnSpremiTransakcijuRashod.Enabled = false;
            btnIzbrisiKategoriju.Enabled = false;
            RefreshPodaci();
        }

        /// <summary>
        /// Dohvati podatke o bankovnim računima i kategorijama na formu.
        /// </summary>
        private void RefreshPodaci()
        {
            chkKategorije.Items.Clear();

            BindingList<Bankovni_racun> listBankovniRacuni = null;

            using (WalletEntities db = new WalletEntities())
            {
                db.Korisnik.Attach(trenutniKorisnik);
                listBankovniRacuni = new BindingList<Bankovni_racun>(trenutniKorisnik.Bankovni_racun.ToList());

                foreach (var item in db.Kategorije_transakcije.ToList())
                {
                    if (item.id_vrsta_transakcije == 2 && (item.id_korisnik == trenutniKorisnik.id_korisnik || item.Korisnik == null)) chkKategorije.Items.Add(item.naziv_kategorije);
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
                    iznos_transakcije = decimal.Parse(txtIznos.Text.ToString()),
                    vrijeme_transakcije = dtpDatumTransakcijeRashod.Value.Date + dtpVrijemeTransakcijeRashod.Value.TimeOfDay,
                    opis_transakcije = txtOpis.Text.ToString()
                };

                //Dodavanje ključeva na kolekcije unutar kategorija i transakcije
                foreach (var item in chkKategorije.CheckedItems)
                {
                    Kategorije_transakcije dodajKategoriju = (from t in db.Kategorije_transakcije
                                                              where t.naziv_kategorije == item.ToString() && t.id_vrsta_transakcije == 2
                                                              select t).First();

                    noviRashod.Kategorije_transakcije.Add(dodajKategoriju);
                }

                foreach (var item in chkKategorije.CheckedItems)
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
        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            Dialog_forme.FrmKategorijeTransakcijaDodaj frmDodajKategoriju = new Dialog_forme.FrmKategorijeTransakcijaDodaj(trenutniKorisnik, 2, null);
            frmDodajKategoriju.ShowDialog();
            RefreshPodaci();
        }

        private void btnUrediKategoriju_Click(object sender, EventArgs e)
        {
            if (chkKategorije.CheckedItems.Count != 1) MessageBox.Show("Potrebno je označiti točno jednu kategoriju za uređivanje!");
            else
            {
                Kategorije_transakcije kategorija = null;
                using (WalletEntities db = new WalletEntities())
                {
                    foreach (var item in chkKategorije.CheckedItems)
                    {
                        kategorija = (from t in db.Kategorije_transakcije
                                      where t.naziv_kategorije == item.ToString() && t.id_vrsta_transakcije == 2
                                      select t).First();
                    }
                }

                Dialog_forme.FrmKategorijeTransakcijaDodaj frmUrediKategoriju = new Dialog_forme.FrmKategorijeTransakcijaDodaj(trenutniKorisnik, 2, kategorija);
                frmUrediKategoriju.ShowDialog();

                // iz nekog razloga podaci se updateaju jedino kad je ovo ovdje pozvano... bilo gdje izvan, identičan kod, kad ga se pozove ne prikaže novi naziv :(
                chkKategorije.Items.Clear();
                using (var db = new WalletEntities())
                {
                    foreach (var item in db.Kategorije_transakcije.ToList())
                    {
                        if (item.id_vrsta_transakcije == 2 && (item.id_korisnik == trenutniKorisnik.id_korisnik || item.Korisnik == null)) chkKategorije.Items.Add(item.naziv_kategorije);
                    }
                }
            }
        }

        private void btnIzbrisiKategoriju_Click(object sender, EventArgs e)
        {
            if (chkKategorije.CheckedItems.Count != 0)
            {
                using (WalletEntities db = new WalletEntities())
                {
                    foreach (Kategorije_transakcije kategorija in db.Kategorije_transakcije)
                    {
                        foreach (var odabranaKategorija in chkKategorije.CheckedItems)
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

        private void chkKategorije_MouseUp(object sender, MouseEventArgs e)
        {
            if (chkKategorije.CheckedItems.Count > 0) btnIzbrisiKategoriju.Enabled = true;
            else btnIzbrisiKategoriju.Enabled = false;

            if (chkKategorije.CheckedItems.Count != 1) btnUrediKategoriju.Enabled = false;
            else btnUrediKategoriju.Enabled = true;
        }
        #endregion

        /// <summary>
        /// Provjera ispravnosti unesenog iznosa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIznos_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIznos.ToString()))
            {
                decimal iznosProvjera;
                if (decimal.TryParse(txtIznos.Text, out iznosProvjera) && iznosProvjera != 0)
                {
                    lblNeispravanIznos.Hide();
                    btnSpremiTransakcijuRashod.Enabled = true;
                }
                else
                {
                    lblNeispravanIznos.Show();
                    btnSpremiTransakcijuRashod.Enabled = false;
                }
            }
            else btnSpremiTransakcijuRashod.Enabled = false;
        }
    }
}