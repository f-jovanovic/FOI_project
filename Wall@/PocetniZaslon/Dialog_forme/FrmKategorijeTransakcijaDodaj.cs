using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon.Dialog_forme
{
    public partial class FrmKategorijeTransakcijaDodaj : Form
    {
        Korisnik trenutniKorisnik = null;
        Kategorije_transakcije odabranaKategorija = null;
        public FrmKategorijeTransakcijaDodaj(Korisnik korisnik , string naziv)
        {
            trenutniKorisnik = korisnik;
            if (naziv != null)
            {
                using (WalletEntities db = new WalletEntities())
                {
                    odabranaKategorija = (from t in db.Kategorije_transakcije
                                          where t.naziv_kategorije == naziv && t.id_vrsta_transakcije == 2
                                          select t).First();
                }
            }
            InitializeComponent();
        }

        private void FrmKategorijeTransakcijaDodaj_Load(object sender, EventArgs e)
        {
            btnDodajKategoriju.Enabled = false;
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            using (WalletEntities db = new WalletEntities())
            {
                Kategorije_transakcije novaKategorija = null;

                if (odabranaKategorija == null)
                {
                    novaKategorija = new Kategorije_transakcije
                    {
                        naziv_kategorije = txtNazivKategorije.Text,
                        id_korisnik = trenutniKorisnik.id_korisnik,
                        id_vrsta_transakcije = 2
                    };
                    db.Kategorije_transakcije.Add(novaKategorija);
                }
                else
                {
                    db.Kategorije_transakcije.Attach(odabranaKategorija);
                    odabranaKategorija.naziv_kategorije = txtNazivKategorije.Text;
                }

                db.SaveChanges();
            }
            Close();
        }

        private void txtNazivKategorije_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNazivKategorije.Text.ToString())) btnDodajKategoriju.Enabled = true;
            else btnDodajKategoriju.Enabled = false;
        }
    }
}
