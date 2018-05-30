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
    public partial class FrmUnosTransakcijaTrosak : Form
    {
        Korisnik trenutniKorisnik = null;
        public FrmUnosTransakcijaTrosak(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

        private void FrmUnosTransakcijaTrosak_Load(object sender, EventArgs e)
        {
            BindingList<Bankovni_racun> listBankovniRacuni = null;
            using (WalletEntities db = new WalletEntities())
            {
                db.Korisnik.Attach(trenutniKorisnik);
                listBankovniRacuni = new BindingList<Bankovni_racun>(trenutniKorisnik.Bankovni_racun.ToList());
            }
            bankovniracunBindingSource.DataSource = listBankovniRacuni;
        }
    }
}
