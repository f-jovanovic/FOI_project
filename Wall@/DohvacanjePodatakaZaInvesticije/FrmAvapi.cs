using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Avapi;
using Avapi.AvapiTIME_SERIES_DAILY;
using Avapi.AvapiDIGITAL_CURRENCY_DAILY;


namespace DohvacanjePodatakaZaInvesticije
{
	public partial class FrmAvapi : Form
	{
		List<Invest> listaInvesticija = new List<Invest>();
		string openVrijednost = null;
		public FrmAvapi()
		{
			InitializeComponent();
			MSFT();
			AAPL();
			BTC();
			ETH();
		}

		/// <summary>
		/// metoda koja postavlja konekciju potrebnu za rad api-a
		/// </summary>
		/// <returns></returns>
		public IAvapiConnection Konekcija()
		{
			IAvapiConnection connection = AvapiConnection.Instance;
			connection.Connect("EP6HXRE6I90RNOEQ");

			return connection;
		}
		/// <summary>
		/// metoda koja dohvaća vrijednost dionica Microsofta jednom u danu
		/// </summary>
		public void MSFT()
		{
			IAvapiConnection connection = Konekcija();

			Int_TIME_SERIES_DAILY tIME_SERIES_DAILY = connection.GetQueryObject_TIME_SERIES_DAILY();
			IAvapiResponse_TIME_SERIES_DAILY avapiResponse = tIME_SERIES_DAILY.Query("MSFT", Const_TIME_SERIES_DAILY.TIME_SERIES_DAILY_outputsize.compact);

			var data = avapiResponse.Data;

			if (data.Error)
			{
				MessageBox.Show("Došlo je do problema s dohvaćanjem podataka");
			}
			else
			{
				txtSimbol.Text = data.MetaData.Symbol;
				txtDiT.Text = data.MetaData.TimeZone;
				txtInfo.Text = data.MetaData.Information;
				foreach (var timeseries in data.TimeSeries)
				{
					openVrijednost = timeseries.open;
				}
			};
			Invest investicija = new Invest(
				openVrijednost, 
				data.MetaData.Symbol, 
				DateTime.Now.Date.ToString()
				);

			listaInvesticija.Add(investicija);

		}
		/// <summary>
		/// metoda koja dohvaća vrijednosti dionica Applea jednom u danu
		/// </summary>
		public void AAPL()
		{
			Konekcija();
			IAvapiConnection connection = Konekcija();

			Int_TIME_SERIES_DAILY tIME_SERIES_DAILY = connection.GetQueryObject_TIME_SERIES_DAILY();
			IAvapiResponse_TIME_SERIES_DAILY avapiResponse = tIME_SERIES_DAILY.Query("AAPL", Const_TIME_SERIES_DAILY.TIME_SERIES_DAILY_outputsize.compact);

			var data = avapiResponse.Data;
			if (data.Error)
			{
				MessageBox.Show("Došlo je do problema s dohvaćanjem podataka");
			}
			else
			{
				txtSimbol2.Text = data.MetaData.Symbol;
				txtDiT2.Text = data.MetaData.TimeZone;
				txtInfo2.Text = data.MetaData.Information;
				foreach (var timeseries in data.TimeSeries)
				{
					openVrijednost = timeseries.open;
				}

				Invest investicija = new Invest(
							openVrijednost,
							data.MetaData.Symbol,
							DateTime.Now.Date.ToString()
				);
				listaInvesticija.Add(investicija);


			}
		}
		/// <summary>
		/// metoda koja dohvaća Bitcoin jednom u danu
		/// </summary>
		public void BTC()
		{
			IAvapiConnection connection = Konekcija();

			Int_DIGITAL_CURRENCY_DAILY dIGITAL_CURRENCY_DAILY = connection.GetQueryObject_DIGITAL_CURRENCY_DAILY();

			IAvapiResponse_DIGITAL_CURRENCY_DAILY avapiResponse_DIGITAL = dIGITAL_CURRENCY_DAILY.QueryPrimitive("BTC", "CNY");

			var data = avapiResponse_DIGITAL.Data;
			if (data.Error)
			{
				MessageBox.Show("Došlo je do problema s dohvaćanjem podataka");
			}
			else
			{
				txtSymbolCrypto.Text = data.MetaData.DigitalCurrencyCode;
				txtDiTCrypto.Text = data.MetaData.LastRefreshed;
				txtInfoCrypto.Text = data.MetaData.Information;
				foreach (var timeseries in data.TimeSeries)
				{
					openVrijednost = timeseries.OpenUSD;
				}
				Invest investicija = new Invest(
					openVrijednost,
					data.MetaData.DigitalCurrencyCode,
					DateTime.Now.Date.ToString()
				);

				listaInvesticija.Add(investicija);

			}
		}
		/// <summary>
		/// metoda koja dohvaća Etherium jednom u danu, najcese uzima vrijednost dana prije, jer se biljeze na kraju dana
		/// </summary>
		public void ETH()
		{
			IAvapiConnection connection = Konekcija();

			Int_DIGITAL_CURRENCY_DAILY dIGITAL_CURRENCY_DAILY = connection.GetQueryObject_DIGITAL_CURRENCY_DAILY();

			IAvapiResponse_DIGITAL_CURRENCY_DAILY avapiResponse_DIGITAL = dIGITAL_CURRENCY_DAILY.QueryPrimitive("ETH", "USD");

			var data = avapiResponse_DIGITAL.Data;
			if (data.Error)
			{
				MessageBox.Show("Došlo je do problema s dohvaćanjem podataka");
			}
			else
			{

				txtSimbolCrypto2.Text = data.MetaData.DigitalCurrencyCode;
				txtDiTCrypto2.Text = data.MetaData.LastRefreshed;
				txtInfoCrypto2.Text = data.MetaData.Information;
				foreach (var timeseries in data.TimeSeries)
				{
				  openVrijednost= timeseries.OpenUSD;
				}
			}
			Invest investicija = new Invest(
				openVrijednost,
				data.MetaData.DigitalCurrencyCode,
				DateTime.Now.Date.ToString()
			);

			listaInvesticija.Add(investicija);


		}
		public List<Invest> lista()
		{
			return listaInvesticija;
		}
		/*	public void Kill()
			{
				Application.Exit();
			}*/
	}
}
