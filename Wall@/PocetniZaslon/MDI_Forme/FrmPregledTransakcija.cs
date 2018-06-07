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
	public partial class FrmPregledTransakcija : Form
	{
		public FrmPregledTransakcija(Korisnik trenutniKorisnik)
		{
			InitializeComponent();
			PrilagodiIzgledForme();
		}

		private void PrilagodiIzgledForme()
		{
			lblPregledTransakcija.Location = new Point(this.Width / 2 - lblPregledTransakcija.Width / 2, lblPregledTransakcija.Location.Y);
			if (chkObicneTransakcije.Checked == false)
			{
				lblKategorije.Visible = false;
				dgvKategorije.Visible = false;
				dgvBankovniRacuni.Height = dgvKategorije.Location.Y + dgvKategorije.Height - dgvBankovniRacuni.Location.Y;
			}
			else
			{
				lblKategorije.Visible = true;
				dgvKategorije.Visible = true;
				dgvBankovniRacuni.Height = lblKategorije.Location.Y - dgvBankovniRacuni.Location.Y - 20;
			}
		}

		/// <summary>
		/// Dohvaćanje binding lista svih transakcija i transakcija investicije
		/// </summary>
		private void PrikaziSveTransakcije()
		{


			
		}

		private void DohvatiSveTransakcije()
		{

		}

		private void DohvatiSveTransakcijeInvesticija()
		{

		}

		#region CheckBoxevi funkcionalnosti

		private void chkObicneTransakcije_CheckedChanged(object sender, EventArgs e)
		{
			PrilagodiIzgledForme();
		}

		private void chkTransakcijeInvesticija_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void chkPrihodi_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void chkRashodi_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void chkVrijeme_CheckedChanged(object sender, EventArgs e)
		{

		}



		#endregion

		
	}
}
