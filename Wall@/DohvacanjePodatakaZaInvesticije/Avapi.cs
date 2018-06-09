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


namespace DohvacanjePodatakaZaInvesticije
{
	public partial class Avapi : Form
	{
		public Avapi()
		{
			InitializeComponent();
			MSFT();
		}
		private void MSFT()
		{
			IAvapiConnection connection = AvapiConnection.Instance;
			connection.Connect("EP6HXRE6I90RNOEQ");

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
	}
}
