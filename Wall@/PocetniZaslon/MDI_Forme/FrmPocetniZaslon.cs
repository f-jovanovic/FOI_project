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
	public partial class FrmPocetniZaslon : Form
	{
		MDI_Forme.FrmStatistika frmStatistika = null;
		Korisnik trenutniKorisnik = null;
		public FrmPocetniZaslon(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			frmStatistika = new FrmStatistika(trenutniKorisnik);
			InitializeComponent();
		}

		public void DohvacanjeStatistike()
		{

		}
	}
}
