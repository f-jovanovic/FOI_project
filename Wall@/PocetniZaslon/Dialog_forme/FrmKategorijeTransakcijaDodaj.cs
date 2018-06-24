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
        int idVrste;
        Kategorije_transakcije odabranaKategorija = null;
        public FrmKategorijeTransakcijaDodaj(Korisnik korisnik, int vrsta_id, Kategorije_transakcije kategorija)
        {
            odabranaKategorija = kategorija;
            trenutniKorisnik = korisnik;
            this.idVrste = vrsta_id;

            InitializeComponent();

            if (odabranaKategorija != null)
            {
                this.Text = "Wall@ | Uredi kategoriju";
                lblNazivKategorije.Text = "Novi naziv kategorije:";
                txtNazivKategorije.Text = odabranaKategorija.naziv_kategorije;
                txtNazivKategorije.SelectAll();
            }
        }

        private void FrmKategorijeTransakcijaDodaj_Load(object sender, EventArgs e)
        {
            btnDodajKategoriju.Enabled = false;
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {

            bool postojeciNaziv = false;

            using (WalletEntities db = new WalletEntities())
            {
                Kategorije_transakcije novaKategorija = null;

                if (odabranaKategorija == null)
                {
                    foreach (var item in db.Kategorije_transakcije)
                    {
                        if (item.naziv_kategorije.ToUpper() == txtNazivKategorije.Text.ToUpper()) postojeciNaziv = true;
                    }

                    if (!postojeciNaziv)
                    {
                        novaKategorija = new Kategorije_transakcije
                        {
                            naziv_kategorije = txtNazivKategorije.Text,
                            id_korisnik = trenutniKorisnik.id_korisnik,
                            id_vrsta_transakcije = idVrste
                        };
                        db.Kategorije_transakcije.Add(novaKategorija);
                    }
                    else MessageBox.Show("Postoji kategorija sa navedenim nazivom!");
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
