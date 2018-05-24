using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon
{
    public partial class FrmRegistracija : Form
    {
        public FrmRegistracija()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja provjerava jesu li svi textboxovi popunjeni, i sukladno tome omogućava(enable) btnRegistracija.
        /// </summary>
        private void OmoguciRegistraciju()
        {
            /*
             * Enabled se mijenja ovisno o stanju textboxova, ako je bar jedan textbox prazan logicki izraz je false i gumb je disabled. Tek kad su svi popunjeni se enabled stavlja na true.
             */
            btnRegistracija.Enabled = (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtIme.Text) && !string.IsNullOrWhiteSpace(txtPrezime.Text) && !string.IsNullOrWhiteSpace(txtLozinka.Text) && !string.IsNullOrWhiteSpace(txtPonoviLozinku.Text));
        }

        // Prijašnju metodu pozivamo kad se mijenja bilo koji textbox
        private void txtPonoviLozinku_TextChanged(object sender, EventArgs e)
        {
            lblWarningPonoviLozinku.Hide();
            OmoguciRegistraciju();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            OmoguciRegistraciju();
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            OmoguciRegistraciju();
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            lblWarningLozinka.Hide();
            OmoguciRegistraciju();

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblWarningEmail.Hide();
            OmoguciRegistraciju();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            // Dohvati sve korisnike iz baze.
            BindingList<Korisnik> korisnici = null;
            using (var db = new WalletEntities())
            {
                korisnici = new BindingList<Korisnik>(db.Korisnik.ToList());
            }

            // Provjeri postoji li mail u bazi, ako da postavi bool na true i prikaži warning.
            bool emailPostoji = false;
            foreach (var item in korisnici)
            {
                if (txtEmail.Text == item.email) emailPostoji = true;
            }
            if (emailPostoji) lblWarningEmail.Show();


            if (txtLozinka.TextLength < 8) lblWarningLozinka.Show(); // Provjera duljine lozinke, ako je < od 8 onda prikaži warning.

            else if (txtLozinka.Text != txtPonoviLozinku.Text) lblWarningPonoviLozinku.Show(); // Provjera jesu li upisane lozinke iste, ako nisu prikaži warning.


            else if (!emailPostoji)
            {
                Korisnik noviKorisnik = new Korisnik(); // Instanciramo novog korisnika kojeg ćemo unijeti.

                noviKorisnik.email = txtEmail.Text.ToString(); // Zabilježe se vrijednosti textboxova.
                noviKorisnik.ime_korisnika = txtIme.Text.ToString();
                noviKorisnik.prezime_korisnika = txtPrezime.Text.ToString();
                noviKorisnik.lozinka = txtLozinka.Text.ToString();
                noviKorisnik.datum_registracije = DateTime.Now;

                using (WalletEntities db = new WalletEntities()) // Dodaj korisnika u listu korisnika, i to vrati u bazu.
                {
                    db.Korisnik.Add(noviKorisnik);
                    db.SaveChanges();
                }

                MessageBox.Show("Korisnik " + noviKorisnik.email + " kreiran."); // Potvrda da je korisnik registriran.
                this.Close(); // Zatvori formu i vrati se na prijavu.
            }
        }
    }
}
