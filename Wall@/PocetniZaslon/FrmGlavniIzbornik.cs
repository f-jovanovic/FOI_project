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
    public partial class FrmGlavniIzbornik : Form
    {
        public FrmGlavniIzbornik()
        {
            InitializeComponent();
        }

		#region Upravljanje Gumbima Glavnog Izbornika

		/// <summary>
		/// Metoda koja zatvara sve otvorene forme koje su otvorene unutar MDI containera forme "FrmGlavniIzbornik"
		/// </summary>

		private void UgasiSveOtvoreneProzore()
		{
			if (this.MdiChildren.Count<Form>() > 0) this.ActiveMdiChild.Close();
		}
		
		private void btnBankovniRacun_Click(object sender, EventArgs e) // Klikom na Bankovni racuni otvara se forma FrmBankovniRacuni unutar MDI containera
		{
			UgasiSveOtvoreneProzore();
			MDI_Forme.FrmBankovniRacuni formaBankovniRacun = new MDI_Forme.FrmBankovniRacuni();
			formaBankovniRacun.MdiParent = this;
			formaBankovniRacun.Dock = DockStyle.Fill;
			formaBankovniRacun.Show();
		}

		private void btnZaslon_Click(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
		}

		private void btnUnosTransakcije_Click(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
		}

		private void btnPregled_Click(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
		}

		private void btnInvesticijskiPortfolio_Click(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
		}

		private void btnStatistika_Click(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
		}

		private void btnPostavke_Click(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
		}

		private void btnOdjava_Click(object sender, EventArgs e)
		{
			Application.Restart(); // Klikom na odjava aplikacija se resetira.
		}

		#endregion
	}
}

