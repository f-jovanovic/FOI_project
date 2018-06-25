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
		UpravljanjeBankovnimRacunima upravljanjeBankovnimRacunima = new UpravljanjeBankovnimRacunima();
		BindingList<Bankovni_racun> listaBankovnihRacuna = null;

		MDI_Forme.FrmStatistika frmStatistika = null;
		Korisnik trenutniKorisnik = null;
		public FrmPocetniZaslon(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			frmStatistika = new FrmStatistika(trenutniKorisnik);
			InitializeComponent();
			DohvacanjeStatistike();
			DohvacanjeInvesticija();
			DohvacanjeBankovnihRacuna();
			DohvacanjeTransakcija();

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
		/// <summary>
		/// metoda koja dohvaca bankonve racune te ih prikazuje u glavnom prozoru
		/// </summary>
		public void DohvacanjeBankovnihRacuna()
		{
			BindingList<Bankovni_racun> listaRacuna = upravljanjeBankovnimRacunima.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik);
			int brojac = 0;
			string[] naziv = new string[2];
			string[] vrsta = new string[2];
			decimal?[] stanje = new decimal?[2];
			Vrsta_racuna vrstaRacuna = null;
			foreach (Bankovni_racun racun in listaRacuna)
			{
				if (brojac == 3) break;
				using (WalletEntities db = new WalletEntities())
				{
					db.Bankovni_racun.Attach(racun);
					naziv[brojac] = racun.naziv_racuna;
					stanje[brojac] = racun.stanje_racuna;
					vrstaRacuna = racun.Vrsta_racuna;
					db.Vrsta_racuna.Attach(vrstaRacuna);
					vrsta[brojac] = vrstaRacuna.naziv_vrste_racuna;
				}
				brojac++;
			}

			if (brojac == 0)
			{
				lblNazivR1.Text = "N/A";
				lblVrstaR1.Text = "N/A";
				lblStanjeR1.Text = "N/A";

				lblNazivR2.Text = "N/A";
				lblVrstaR2.Text = "N/A";
				lblStanjeR2.Text = "N/A";

				lblNazivR3.Text = "N/A";
				lblVrstaR3.Text = "N/A";
				lblStanjeR3.Text = "N/A";

				return;
			}
			lblNazivR1.Text = naziv[0].ToString();
			lblVrstaR1.Text = vrsta[0].ToString();
			lblStanjeR1.Text = stanje[0].ToString();
			if (brojac == 1)
			{
				lblNazivR2.Text = "N/A";
				lblVrstaR2.Text = "N/A";
				lblStanjeR2.Text = "N/A";

				lblNazivR3.Text = "N/A";
				lblVrstaR3.Text = "N/A";
				lblStanjeR3.Text = "N/A";

				return;
			}
			lblNazivR2.Text = naziv[1].ToString();
			lblVrstaR2.Text = vrsta[1].ToString();
			lblStanjeR2.Text = stanje[1].ToString();
			if (brojac == 2)
			{
				lblNazivR3.Text = "N/A";
				lblVrstaR3.Text = "N/A";
				lblStanjeR3.Text = "N/A";
				return;
			}
			lblNazivR3.Text = naziv[2].ToString();
			lblVrstaR3.Text = vrsta[2].ToString();
			lblStanjeR3.Text = stanje[2].ToString();
		}

		public void DohvacanjeTransakcija()
		{

			UpravljanjeTransakcijom upravljanjeTransakcijom = new UpravljanjeTransakcijom();
			listaBankovnihRacuna = new BindingList<Bankovni_racun>();
			listaBankovnihRacuna = upravljanjeBankovnimRacunima.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik);

			BindingList<Transakcija> listaTransakcija = upravljanjeTransakcijom.DohvatiSveTransakcije(listaBankovnihRacuna);
			List<Transakcija> lista = listaTransakcija.ToList();
			lista = lista.OrderByDescending(x => x.vrijeme_transakcije).ToList();

			lblDatumT1.Text = lista[0].vrijeme_transakcije.ToString();
			lblNazivT1.Text = lista[0].opis_transakcije.ToString();
			lblIznosT1.Text = lista[0].iznos_transakcije.ToString();

			lblDatumT2.Text = lista[1].vrijeme_transakcije.ToString();
			lblNazivT2.Text = lista[1].opis_transakcije.ToString();
			lblIznosT2.Text = lista[1].iznos_transakcije.ToString();

			lblDatumT3.Text = lista[2].vrijeme_transakcije.ToString();
			lblNazivT3.Text = lista[2].opis_transakcije.ToString();
			lblIznosT3.Text = lista[2].iznos_transakcije.ToString();
		}
	}
}
