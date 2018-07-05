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

            if (listaRacuna.Count >= 3)
            {
                lblNazivR1.Text = PodaciRacuna(listaRacuna[0])[0];
                lblVrstaR1.Text = PodaciRacuna(listaRacuna[0])[2];
                lblStanjeR1.Text = PodaciRacuna(listaRacuna[0])[1];

                lblNazivR2.Text = PodaciRacuna(listaRacuna[1])[0];
                lblVrstaR2.Text = PodaciRacuna(listaRacuna[1])[2];
                lblStanjeR2.Text = PodaciRacuna(listaRacuna[1])[1];

                lblNazivR3.Text = PodaciRacuna(listaRacuna[2])[0];
                lblVrstaR3.Text = PodaciRacuna(listaRacuna[2])[2];
                lblStanjeR3.Text = PodaciRacuna(listaRacuna[2])[1];
            }

            else if (listaRacuna.Count == 2)
            {
                lblNazivR1.Text = PodaciRacuna(listaRacuna[0])[0];
                lblVrstaR1.Text = PodaciRacuna(listaRacuna[0])[2];
                lblStanjeR1.Text = PodaciRacuna(listaRacuna[0])[1];

                lblNazivR2.Text = PodaciRacuna(listaRacuna[1])[0];
                lblVrstaR2.Text = PodaciRacuna(listaRacuna[1])[2];
                lblStanjeR2.Text = PodaciRacuna(listaRacuna[1])[1];

                lblNazivR3.Text = "";
                lblVrstaR3.Text = "N/A";
                lblStanjeR3.Text = "";
            }

            else if (listaRacuna.Count == 1)
            {
                lblNazivR1.Text = PodaciRacuna(listaRacuna[0])[0];
                lblVrstaR1.Text = PodaciRacuna(listaRacuna[0])[2];
                lblStanjeR1.Text = PodaciRacuna(listaRacuna[0])[1];

                lblNazivR2.Text = "";
                lblVrstaR2.Text = "N/A";
                lblStanjeR2.Text = "";

                lblNazivR3.Text = "";
                lblVrstaR3.Text = "N/A";
                lblStanjeR3.Text = "";
            }

            else
            {
                lblNazivR1.Text = "";
                lblVrstaR1.Text = "N/A";
                lblStanjeR1.Text = "";

                lblNazivR2.Text = "";
                lblVrstaR2.Text = "N/A";
                lblStanjeR2.Text = "";

                lblNazivR3.Text = "";
                lblVrstaR3.Text = "N/A";
                lblStanjeR3.Text = "";
            }
		}

        /// <summary>
        /// Dohvati listu s podacima o danom bankovnom računu.
        /// </summary>
        /// <param name="racun"></param>
        /// <returns></returns>
        private List<string> PodaciRacuna(Bankovni_racun racun)
        {
            List<string> detaljiRacuna = new List<string>();

            using (WalletEntities db = new WalletEntities())
            {
                db.Bankovni_racun.Attach(racun);
                detaljiRacuna.Add(racun.naziv_racuna);
                detaljiRacuna.Add(racun.stanje_racuna.ToString());

                db.Vrsta_racuna.Attach(racun.Vrsta_racuna);
                detaljiRacuna.Add(racun.Vrsta_racuna.naziv_vrste_racuna);
            }

            return detaljiRacuna;
        }

		public void DohvacanjeTransakcija()
		{

			UpravljanjeTransakcijom upravljanjeTransakcijom = new UpravljanjeTransakcijom();
			listaBankovnihRacuna = new BindingList<Bankovni_racun>();
			listaBankovnihRacuna = upravljanjeBankovnimRacunima.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik);

			BindingList<Transakcija> listaTransakcija = upravljanjeTransakcijom.DohvatiSveTransakcije(listaBankovnihRacuna);
			List<Transakcija> lista = listaTransakcija.ToList();
			lista = lista.OrderByDescending(x => x.vrijeme_transakcije).ToList();

            if (lista.Count >= 3)
            {

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
            else if (lista.Count == 2)
            {
                lblDatumT1.Text = lista[0].vrijeme_transakcije.ToString();
                lblNazivT1.Text = lista[0].opis_transakcije.ToString();
                lblIznosT1.Text = lista[0].iznos_transakcije.ToString();

                lblDatumT2.Text = lista[1].vrijeme_transakcije.ToString();
                lblNazivT2.Text = lista[1].opis_transakcije.ToString();
                lblIznosT2.Text = lista[1].iznos_transakcije.ToString();

                lblDatumT3.Text = "";
                lblNazivT3.Text = "N/A";
                lblIznosT3.Text = "";
            }
            else if (lista.Count == 1)
            {
                lblDatumT1.Text = lista[0].vrijeme_transakcije.ToString();
                lblNazivT1.Text = lista[0].opis_transakcije.ToString();
                lblIznosT1.Text = lista[0].iznos_transakcije.ToString();

                lblDatumT2.Text = "";
                lblNazivT2.Text = "N/A";
                lblIznosT2.Text = "";

                lblDatumT3.Text = "";
                lblNazivT3.Text = "N/A";
                lblIznosT3.Text = "";
            }
            else
            {
                lblDatumT1.Text = "";
                lblNazivT1.Text = "N/A";
                lblIznosT1.Text = "";

                lblDatumT2.Text = "";
                lblNazivT2.Text = "N/A";
                lblIznosT2.Text = "";

                lblDatumT3.Text = "";
                lblNazivT3.Text = "N/A";
                lblIznosT3.Text = "";
            }
        }

		private void FrmPocetniZaslon_HelpRequested(object sender, HelpEventArgs hlpevent)
		{
			string keyword = "pocetni";
			Help.ShowHelp(this, @"..\\..\\Resources\\Korisnicka.chm", HelpNavigator.TopicId, keyword);
		}
	}
}
