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

        /// <summary>
        /// Metoda za zatvaranje svih MDI Child formi kako bi prikazali samo jednu formu u MDI containeru.
        /// </summary>
        /// <param name="form"></param>
        private void ZatvoriForme(Form form)
        {
            foreach (var item in this.MdiParent.MdiChildren)
            {
                if (item != form) item.Close();
            }
        }

        #region Navigacija za unos različitih transakcija
        private void btnTrosak_Click(object sender, EventArgs e)
        {
            FrmUnosTransakcijaRashod frmUnosTransakcijaRashod = new FrmUnosTransakcijaRashod(trenutniKorisnik);
            frmUnosTransakcijaRashod.MdiParent = this.MdiParent;
            frmUnosTransakcijaRashod.Dock = DockStyle.Fill;
            ZatvoriForme(frmUnosTransakcijaRashod);
            frmUnosTransakcijaRashod.Show();
            frmGlavni.PrilagodiElementeChild(frmUnosTransakcijaRashod);
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
        #endregion
    }
}
