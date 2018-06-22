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
	public partial class FrmStatistika : Form
	{
		Korisnik trenutniKorisnik = null;
		public FrmStatistika(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			InitializeComponent();
			lblStatistikaNaslov.Location = new Point(this.Width / 2 - lblStatistikaNaslov.Width / 2, lblStatistikaNaslov.Location.Y);
		}

		private void FrmStatistika_Load(object sender, EventArgs e)
		{

		}
	}
}
