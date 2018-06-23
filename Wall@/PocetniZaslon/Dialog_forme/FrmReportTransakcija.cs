using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon.Dialog_forme
{
	public partial class FrmReportTransakcija : Form
	{
		public FrmReportTransakcija(BindingList<PrikazTransakcije> listaFiltriranihPrikazaTransakcije)
		{
			InitializeComponent();
			PrikazTransakcijeBindingSource.DataSource = listaFiltriranihPrikazaTransakcije.OrderByDescending(x => x.Vrijeme);
		}

		private void FrmReportTransakcija_Load(object sender, EventArgs e)
		{
			this.reportViewerPregledTransakcija.RefreshReport();
		}
	}
}
