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
    public partial class FrmUnosTransakcija : Form
    {
        FrmGlavniIzbornik frmGlavni = null;
        Korisnik trenutniKorisnik = null;

        public FrmUnosTransakcija(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            frmGlavni = new FrmGlavniIzbornik(trenutniKorisnik);
            InitializeComponent();
        }

        private void ZatvoriForme(Form form)
        {
            foreach (var item in this.MdiParent.MdiChildren)
            {
                if (item != form) item.Close();
            }
        }

        private void btnTrosak_Click(object sender, EventArgs e)
        {
            
            FrmUnosTransakcijaTrosak frmUnosTransakcijaTrosak = new FrmUnosTransakcijaTrosak(trenutniKorisnik);
            
            frmUnosTransakcijaTrosak.MdiParent = this.MdiParent;
            frmUnosTransakcijaTrosak.Dock = DockStyle.Fill;
            ZatvoriForme(frmUnosTransakcijaTrosak);
            frmUnosTransakcijaTrosak.Show();
            frmGlavni.PrilagodiElementeChild(frmUnosTransakcijaTrosak);
        }

        private void btnPrihod_Click(object sender, EventArgs e)
        {
            FrmUnosTransakcijaPrihod_Interni frmUnosTransakcijaPrihod = new FrmUnosTransakcijaPrihod_Interni();
            frmUnosTransakcijaPrihod.MdiParent = this.MdiParent;
            frmUnosTransakcijaPrihod.Dock = DockStyle.Fill;
            ZatvoriForme(frmUnosTransakcijaPrihod);
            frmUnosTransakcijaPrihod.Show();
            frmGlavni.PrilagodiElementeChild(frmUnosTransakcijaPrihod);
        }

        private void btnInterniPrijenos_Click(object sender, EventArgs e)
        {
            FrmUnosTransakcijaPrihod_Interni frmUnosTransakcijaInterni = new FrmUnosTransakcijaPrihod_Interni();
            frmUnosTransakcijaInterni.MdiParent = this.MdiParent;
            frmUnosTransakcijaInterni.Dock = DockStyle.Fill;
            ZatvoriForme(frmUnosTransakcijaInterni);
            frmUnosTransakcijaInterni.Show();
            frmGlavni.PrilagodiElementeChild(frmUnosTransakcijaInterni);
        }
    }
}
