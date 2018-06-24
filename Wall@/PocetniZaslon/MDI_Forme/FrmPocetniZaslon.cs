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
			DohvacanjeInvesticija();

			//sakrivanje stanja investicija ako korisnik nema investicijski portfolio
			bool portfolioPostoji = true;
			using (var db = new WalletEntities())
			{
				foreach (var portfolio in db.Investicijski_portfolio)
				{
					if (portfolio.id_korisnik != korisnik.id_korisnik)
					{
						portfolioPostoji = false;
					}
					else
					{
						portfolioPostoji = true;
						break;
					}
				}
				if (portfolioPostoji == false)
				{
					gBoxInvesticije.Visible = false;
				}
			}
		}
		/// <summary>
		/// metoda koja služi crtanju grafa na početnom zaslonu, dohvacaju se ukupni iznosi rashoda, prihoda i svih transakcija iz frmStatistike
		/// </summary>
		public void DohvacanjeStatistike()
		{
			decimal ukupniIznosTransakcija = frmStatistika.DohvatiSveZapise();
			decimal ukupniPrihodi = frmStatistika.VratiUkupniPrihod();
			decimal ukupniRashodi = frmStatistika.VratiUkupniRashod();

			try
			{
				chartStatistika.Series["Stat"].Points.AddXY("Prihodi", ukupniPrihodi / ukupniIznosTransakcija);
				chartStatistika.Series["Stat"].Points.AddXY("Rashodi", ukupniRashodi / ukupniIznosTransakcija);
			}
			catch (Exception)
			{
				chartStatistika.Hide();
			}


		}
		/// <summary>
		/// metoda koja sluzi za punjenje podataka investicijskog portfolija na glavnom zaslonu
		/// </summary>
		public void DohvacanjeInvesticija()
		{
			UpravljanjeTransakcijom upravljanje = new UpravljanjeTransakcijom();
			UpravljanjeBankovnimRacunima upravljanjeBankovnim = new UpravljanjeBankovnimRacunima();
			foreach (Transakcija_investicije inv in upravljanje.DohvatiSveTransakcijeInvesticija(upravljanjeBankovnim.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik)))
			{
				
			}
			using (var db = new WalletEntities())
			{
				lblNazivInv1.Text = (from t in db.Investicija
									 where t.naziv_investicije == "BTC"
									 select t.naziv_investicije).First();

				lblNazivInv2.Text = (from t in db.Investicija
									 where t.naziv_investicije == "ETH"
									 select t.naziv_investicije).First();

				lblNazivInv3.Text = (from t in db.Investicija
									 where t.naziv_investicije == "AAPL"
									 select t.naziv_investicije).First();

				lblNazivInv4.Text = (from t in db.Investicija
									 where t.naziv_investicije == "MSFT"
									 select t.naziv_investicije).First();

				decimal vrjPrveInvest = (from t in db.Stanje_investicije
								where t.id_investicije == 1002
								orderby t.vrijeme_stanja descending
								select t.vrijednost_investicije).First();

				decimal vrjDrugeInvest = (from t in db.Stanje_investicije
										  where t.id_investicije == 1003
										  orderby t.vrijeme_stanja descending
										  select t.vrijednost_investicije).First();

				decimal vrjTreceInvest = (from t in db.Stanje_investicije
										  where t.id_investicije == 1004
										  orderby t.vrijeme_stanja descending
										  select t.vrijednost_investicije).First();

				decimal vrjCetvrteInvest = (from t in db.Stanje_investicije
										  where t.id_investicije == 1005
										  orderby t.vrijeme_stanja descending
										  select t.vrijednost_investicije).First();

				lblVrj1.Text = vrjPrveInvest.ToString();
				lblVrj2.Text = vrjDrugeInvest.ToString();
				lblVrj3.Text = vrjTreceInvest.ToString();
				lblVrj4.Text = vrjCetvrteInvest.ToString();

			}


		}
	}
}
