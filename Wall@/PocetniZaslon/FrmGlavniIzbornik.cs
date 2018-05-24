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

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Application.Restart(); // Klikom na odjava aplikacija se resetira.
        }

		private void btnBankovniRacun_Click(object sender, EventArgs e) // Klikom na Bankovni racuni otvara se forma FrmBankovniRacuni.
		{
			MDI_Forme.FrmBankovniRacuni formaBankovniRacun = new MDI_Forme.FrmBankovniRacuni();
			formaBankovniRacun.MdiParent = this;
			formaBankovniRacun.WindowState = FormWindowState.Maximized;
			formaBankovniRacun.Show();
		}
	}
}

