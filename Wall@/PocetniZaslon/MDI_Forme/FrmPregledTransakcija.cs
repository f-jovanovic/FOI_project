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
		UpravljanjeBankovnimRacunima radnjaNadBankovnimRacunom = new UpravljanjeBankovnimRacunima();
		UpravljanjeTransakcijom radnjaNadTransakcijom = new UpravljanjeTransakcijom();

		BindingList<Bankovni_racun> listaBankovnihRacuna = null;
		BindingList<Vrsta_racuna> listaVrstaRacuna = null;
		BindingList<Vrsta_transakcije> listaVrstaTransakcije = null;
		Korisnik trenutniKorisnik = null;

		public FrmPregledTransakcija(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			InitializeComponent();
		}

		private void FrmPregledTransakcija_Load(object sender, EventArgs e)
		{
			PrilagodiIzgledForme();

			//Dohvaćanje i prikazivanje svih korisnikovih bankovnih računa (uključujući vrstu računa).
			listaBankovnihRacuna = radnjaNadBankovnimRacunom.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik);
			listaVrstaRacuna = radnjaNadBankovnimRacunom.PrikaziVrsteBankovnihRacuna();

			bindingSourceBankovniRacuni.DataSource = listaBankovnihRacuna;
			BindingSourceVrstaRacuna.DataSource = listaVrstaRacuna;

			//Dohvaćanje vrsta transakcija.
			listaVrstaTransakcije = radnjaNadTransakcijom.PrikaziVrsteTransakcija();
			bindingSourceVrstaTransakcije.DataSource = listaVrstaTransakcije;

			OsvjeziPrikazTransakcija();
		}

		private void OsvjeziPrikazTransakcija()
		{
			OsvjeziKategorije();
		}

		private void OsvjeziKategorije()
		{
			if (chkPrihodi.Checked == true && chkRashodi.Checked == true) bindingSourceKategorije.DataSource = radnjaNadTransakcijom.PrikaziKategorijeKorisnika(trenutniKorisnik, 0);
			if (chkPrihodi.Checked == true && chkRashodi.Checked == false) bindingSourceKategorije.DataSource = radnjaNadTransakcijom.PrikaziKategorijeKorisnika(trenutniKorisnik, 1);
			if (chkPrihodi.Checked == false && chkRashodi.Checked == true) bindingSourceKategorije.DataSource = radnjaNadTransakcijom.PrikaziKategorijeKorisnika(trenutniKorisnik, 2);
			if (chkPrihodi.Checked == false && chkRashodi.Checked == false) bindingSourceKategorije.Clear();
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
		
		#region CheckBoxevi funkcionalnosti

		private void chkObicneTransakcije_CheckedChanged(object sender, EventArgs e)
		{
			PrilagodiIzgledForme();
			OsvjeziPrikazTransakcija();
		}

		private void chkTransakcijeInvesticija_CheckedChanged(object sender, EventArgs e)
		{
			OsvjeziPrikazTransakcija();
		}

		private void chkPrihodi_CheckedChanged(object sender, EventArgs e)
		{
			OsvjeziPrikazTransakcija();
		}

		private void chkRashodi_CheckedChanged(object sender, EventArgs e)
		{
			OsvjeziPrikazTransakcija();
		}

		private void chkVrijeme_CheckedChanged(object sender, EventArgs e)
		{
			OsvjeziPrikazTransakcija();
		}

		#endregion

		
	}
}
