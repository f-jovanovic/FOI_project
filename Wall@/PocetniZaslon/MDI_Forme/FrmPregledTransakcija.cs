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

			dtpVrijemeOd.Value = DateTime.Now;
			dtpVrijemeDo.Value = DateTime.Now.AddMonths(1);

			//Dohvaćanje i prikazivanje svih korisnikovih bankovnih računa (uključujući vrstu računa).
			listaBankovnihRacuna = radnjaNadBankovnimRacunom.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik);
			listaVrstaRacuna = radnjaNadBankovnimRacunom.PrikaziVrsteBankovnihRacuna();

			bindingSourceBankovniRacuni.DataSource = listaBankovnihRacuna;
			BindingSourceVrstaRacuna.DataSource = listaVrstaRacuna;

			//Dohvaćanje vrsta transakcija.
			listaVrstaTransakcije = radnjaNadTransakcijom.PrikaziVrsteTransakcija();
			bindingSourceVrstaTransakcije.DataSource = listaVrstaTransakcije;

			OsvjeziKategorije();
			OsvjeziPrikazTransakcija();
		}

		private void OsvjeziPrikazTransakcija()
		{

		}

		private void OsvjeziKategorije()
		{
			if (chkPrihodi.Checked == true && chkRashodi.Checked == true) bindingSourceKategorije.DataSource = radnjaNadTransakcijom.PrikaziKategorijeKorisnika(trenutniKorisnik, 0);
			if (chkPrihodi.Checked == true && chkRashodi.Checked == false) bindingSourceKategorije.DataSource = radnjaNadTransakcijom.PrikaziKategorijeKorisnika(trenutniKorisnik, 1);
			if (chkPrihodi.Checked == false && chkRashodi.Checked == true) bindingSourceKategorije.DataSource = radnjaNadTransakcijom.PrikaziKategorijeKorisnika(trenutniKorisnik, 2);
			if (chkPrihodi.Checked == false && chkRashodi.Checked == false) bindingSourceKategorije.Clear();
		}
		

		#region CheckBoxevi funkcionalnosti

		//Obicne transakcije check box.
		private void chkObicneTransakcije_CheckedChanged(object sender, EventArgs e)
		{
			PrilagodiIzgledForme();
			OsvjeziPrikazTransakcija();
		}

		//Transakcije investicija check box.
		private void chkTransakcijeInvesticija_CheckedChanged(object sender, EventArgs e)
		{
			OsvjeziPrikazTransakcija();
		}

		//Prihodi check box.
		private void chkPrihodi_CheckedChanged(object sender, EventArgs e)
		{
			OsvjeziKategorije();
			OsvjeziPrikazTransakcija();
		}

		//Rashodi check box.
		private void chkRashodi_CheckedChanged(object sender, EventArgs e)
		{
			OsvjeziKategorije();
			OsvjeziPrikazTransakcija();
		}

		//Svo vrijeme check box.
		private void chkVrijeme_CheckedChanged(object sender, EventArgs e)
		{
			dtpVrijemeOd.Enabled = !(chkVrijeme.Checked);
			dtpVrijemeDo.Enabled = !(chkVrijeme.Checked);
			OsvjeziPrikazTransakcija();
		}

		//Svi računi check box.
		private void chkSviBankovniRacuni_CheckedChanged(object sender, EventArgs e)
		{
			OznacitiSveCheckBoxeve(dgvBankovniRacuni, chkSviBankovniRacuni);
			OsvjeziPrikazTransakcija();
		}

		//Sve kategorije check box.
		private void chkSveKategorije_CheckedChanged(object sender, EventArgs e)
		{
			OznacitiSveCheckBoxeve(dgvKategorije, chkSveKategorije);
			OsvjeziPrikazTransakcija();
		}

		//Promjena sadržaja dgvBankovniRacuni oznacuje sve bankovne racune.
		private void dgvBankovniRacuni_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			chkSviBankovniRacuni.Checked = true;
			OznacitiSveCheckBoxeve(dgvBankovniRacuni, chkSviBankovniRacuni);
			OsvjeziPrikazTransakcija();
		}
		private void dgvBankovniRacuni_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			chkSviBankovniRacuni.Checked = true;
			OznacitiSveCheckBoxeve(dgvBankovniRacuni, chkSviBankovniRacuni);
			OsvjeziPrikazTransakcija();
		}

		//Promjena sadržaja dgvKategorije oznacuje sve kategorije transakcija.
		private void dgvKategorije_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			chkSveKategorije.Checked = true;
			OznacitiSveCheckBoxeve(dgvKategorije, chkSveKategorije);
			OsvjeziPrikazTransakcija();
		}
		private void dgvKategorije_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			chkSveKategorije.Checked = true;
			OznacitiSveCheckBoxeve(dgvKategorije, chkSveKategorije);
			OsvjeziPrikazTransakcija();
		}

		/// <summary>
		/// Označuju se ili odznačuju se svi checkboxevi unutar DataGridView-a ovisno o nekoj drugoj checkBox oznaci.
		/// Unutar DataGridViewa stupac s checkboxevima mora biti na prvom mjestu.
		/// </summary>l
		private void OznacitiSveCheckBoxeve(DataGridView dataGrid, CheckBox oznaka)
		{
			foreach (DataGridViewRow red in dataGrid.Rows)
			{
				DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)red.Cells[1];
				checkBox.Value = oznaka.Checked;
			}
		}

		#endregion


		private void PrilagodiIzgledForme()
		{
			lblPregledTransakcija.Location = new Point(this.Width / 2 - lblPregledTransakcija.Width / 2, lblPregledTransakcija.Location.Y);
			if (chkObicneTransakcije.Checked == false)
			{
				lblKategorije.Visible = false;
				dgvKategorije.Visible = false;
				chkSveKategorije.Visible = false;
				dgvBankovniRacuni.Height = dgvKategorije.Location.Y + dgvKategorije.Height - dgvBankovniRacuni.Location.Y;
			}
			else
			{
				lblKategorije.Visible = true;
				dgvKategorije.Visible = true;
				chkSveKategorije.Visible = true;
				dgvBankovniRacuni.Height = lblKategorije.Location.Y - dgvBankovniRacuni.Location.Y - 20;
			}
		}

	}
}
