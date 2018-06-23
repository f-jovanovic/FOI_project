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
    public partial class FrmPostavke : Form
    {
        Korisnik trenutniKorisnik;

        public FrmPostavke(Korisnik trenutniKorisnik)
        {
            InitializeComponent();
            this.trenutniKorisnik = trenutniKorisnik;

            txtIme.Text = trenutniKorisnik.ime_korisnika;
            txtPrezime.Text = trenutniKorisnik.prezime_korisnika;
            txtEmail.Text = trenutniKorisnik.email;

            btnPromjeniLozinku.Enabled = false;
        }

        bool ProvjeriDuljinu()
        {
            bool dobraDuljina = false;

            if (txtNovaLozinka.Text.Length >= 8)
            {
                dobraDuljina = true;
                lblMinimalnaDuljina.Hide();
            }
            else lblMinimalnaDuljina.Show();

            return dobraDuljina;
        }

        bool ProvjeriIspravnostLozinki()
        {
            bool isteLozinke = false;

            if (txtNovaLozinka.Text == txtNovaPonovno.Text)
            {
                isteLozinke = true;
                lblRazliciteLozinke.Hide();
            }
            else lblRazliciteLozinke.Show();

            return isteLozinke;
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            bool emailZauzet = false;
            using (WalletEntities db = new WalletEntities())
            {
                foreach (Korisnik korisnik in db.Korisnik)
                {
                    if (korisnik.email == txtEmail.Text)
                    {
                        emailZauzet = true;
                        break;
                    }
                }
            }

            if (emailZauzet)
            {
                MessageBox.Show("Email adresa je već zauzeta!");
            }
            else
            {
                using (WalletEntities db = new WalletEntities())
                {
                    db.Korisnik.Attach(trenutniKorisnik);

                    trenutniKorisnik.ime_korisnika = txtIme.Text;
                    trenutniKorisnik.prezime_korisnika = txtPrezime.Text;
                    trenutniKorisnik.email = txtEmail.Text;

                    db.SaveChanges();
                }
            }
        }

        private void btnPromjeniLozinku_Click(object sender, EventArgs e)
        {
            if (txtStaraLozinka.Text != trenutniKorisnik.lozinka) MessageBox.Show("Krivo unesena lozinka!");

            else
            {
                using (WalletEntities db = new WalletEntities())
                {
                    db.Korisnik.Attach(trenutniKorisnik);

                    trenutniKorisnik.lozinka = txtNovaLozinka.Text.ToString();

                    db.SaveChanges();
                }
            }
        }

        private void txtNovaLozinka_TextChanged(object sender, EventArgs e)
        {
            if (ProvjeriDuljinu() && ProvjeriIspravnostLozinki()) btnPromjeniLozinku.Enabled = true;
            else btnPromjeniLozinku.Enabled = false;
        }

        private void txtNovaPonovno_TextChanged(object sender, EventArgs e)
        {
            if (ProvjeriDuljinu() && ProvjeriIspravnostLozinki()) btnPromjeniLozinku.Enabled = true;
            else btnPromjeniLozinku.Enabled = false;
        }
    }
}
