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

            // Ako je email ostao isti onda se upis omogućava.
            if (emailZauzet && txtEmail.Text != trenutniKorisnik.email)
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
                MessageBox.Show("Promjene spremljene!");
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
                MessageBox.Show("Lozinka uspješno promijenjena!");
            }
        }

        #region Provjera ispravnosti nove lozinke
        /// <summary>
        /// Metoda za provjeru duljine lozinke. (Minimalna duljina - 8)
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Metoda koja provjerava jesu li nova lozinka i njen ponovni upis jednaki.
        /// </summary>
        /// <returns></returns>
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
		#endregion

		private void FrmPostavke_HelpRequested(object sender, HelpEventArgs hlpevent)
		{
			string keyword = "postavke";
			Help.ShowHelp(this, @"..\\..\\Resources\\Korisnicka.chm", HelpNavigator.TopicId, keyword);
		}
	}
}
