using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon.DialogForme
{
	public partial class FrmInvesticijskiPortfolioObrišiInvesticiju : Form
	{
		private Korisnik trenutniKorisnik = null;

		public FrmInvesticijskiPortfolioObrišiInvesticiju(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			InitializeComponent();
			DohvatiInvesticije();
		}
		/// <summary>
		/// dohvaća imena investicija koje se nalaze u bazi trenutnog korisnika
		/// </summary>
		private void DohvatiInvesticije()
		{
			BindingList<Investicija> listaImena = null;
			using (var db = new WalletEntities())
			{
				listaImena = new BindingList<Investicija>(db.Investicija.ToList());
			}
			investicijaBindingSource.DataSource = listaImena;
		}
	}
}
