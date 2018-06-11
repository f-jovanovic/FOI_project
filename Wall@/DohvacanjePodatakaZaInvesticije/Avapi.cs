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
using PocetniZaslon;
using Avapi.AvapiDIGITAL_CURRENCY_DAILY;


namespace DohvacanjePodatakaZaInvesticije
{
	public partial class Avapi : Form
	{
		public Avapi()
		{
			InitializeComponent();
			MSFT();
			AAPL();
			BTC();
			ETH();
		}

		public IAvapiConnection Konekcija()
		{
			IAvapiConnection connection = AvapiConnection.Instance;
			connection.Connect("EP6HXRE6I90RNOEQ");

			return connection;
		}
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
					txtOpen.Text = timeseries.open;
				}
			};
			


		}
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
					txtOpen2.Text = timeseries.open;
				}


			}
		}

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
					txtOpenCrypto.Text = timeseries.OpenUSD;
				}

			}
		}

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
					txtOpenCrypto2.Text = timeseries.OpenUSD;
				}
			}

		}
		private void Avapi_Load(object sender, EventArgs e)
		{

		}
	}
}
