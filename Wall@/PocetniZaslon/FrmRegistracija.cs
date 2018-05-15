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
            BindingList<korisnik> korisnici = null;
            using (var db = new Entities())
            {
                korisnici = new BindingList<korisnik>(db.korisnik.ToList());
            }

            // Provjeri postoji li mail u bazi, ako da postavi bool na true i prikaži warning.
            bool emailPostoji = false;
            foreach (var item in korisnici)
            {
                if (txtEmail.Text == item.email) emailPostoji = true;
            }

            if (emailPostoji) lblWarningEmail.Show(); 

            // Provjera duljine lozinke, ako je < od 8 onda prikaži warning.
            if (txtLozinka.TextLength < 8) lblWarningLozinka.Show();

            // Provjera jesu li upisane lozinke iste, ako nisu prikaži warning.
            if (txtLozinka.Text != txtPonoviLozinku.Text) lblWarningPonoviLozinku.Show();

            // TO DO
            /*
             * Dodati spajanje na bazu ako je sve dobro uneseno.
             * Ostvariti sinkronizaciju.
             */
        }
    }
}
