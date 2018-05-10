using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon
{
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            korisnik trenutniKorisnik = new korisnik(); // Instanciranje korisnika koje pri uspješnoj prijavi bilježi točno tog korisnika.

            /*
             Čitanje liste korisnika, tako da možemo provjeriti točnost login podataka.
             */
            BindingList<korisnik> korisnici = null;
            using (var db = new Entities())
            {
                korisnici = new BindingList<korisnik>(db.korisnik.ToList());
            }


            foreach (var item in korisnici)
            {
                if (txtEmail.Text == item.email)
                {
                    if (txtLozinka.Text == item.lozinka)
                    {
                        MessageBox.Show("Prijava uspješna");
                        trenutniKorisnik = item;
                        FrmGlavniIzbornik glavniIzbornik = new FrmGlavniIzbornik(); // Ako je login dobar onda se pokrene FrmGlavniIzbornik, a ovaj se zatvara tek kad je i onaj closed.
                        this.Hide();
                        glavniIzbornik.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Kriva lozinka");
                }
                else
                {
                    MessageBox.Show("Nepostojeći korisnik");
                }
            }
        }

        private void cboxMaskLozinka_CheckedChanged(object sender, EventArgs e) // Checkbox za otkrivanje/skrivanje lozinke.
        {
            if (cboxMaskLozinka.Checked) txtLozinka.UseSystemPasswordChar = false;

            else txtLozinka.UseSystemPasswordChar = true;

        }
    }
}
