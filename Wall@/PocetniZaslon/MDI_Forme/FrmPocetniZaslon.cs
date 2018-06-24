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
			DohvacanjeStatistike();
		}

		public void DohvacanjeStatistike()
		{
			decimal ukupniIznosTransakcija = frmStatistika.DohvatiSveZapise();
			decimal ukupniPrihodi = frmStatistika.VratiUkupniPrihod();
			decimal ukupniRashodi = frmStatistika.VratiUkupniRashod();
			

			chartStatistika.Series["Stat"].Points.AddXY("Prihodi",  ukupniPrihodi/ ukupniIznosTransakcija);
			chartStatistika.Series["Stat"].Points.AddXY("Rashodi", ukupniRashodi / ukupniIznosTransakcija);

		}
	}
}
