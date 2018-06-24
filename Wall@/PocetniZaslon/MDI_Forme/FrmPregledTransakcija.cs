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
		BindingList<Transakcija> listaTransakcija = null;
		BindingList<Transakcija_investicije> listaTransakcijaInvesticije = null;
		BindingList<Kategorije_transakcije> listaKategorijaTransakcija = null;
		Korisnik trenutniKorisnik = null;

		BindingList<Bankovni_racun> listaOznacenihBankovnihRacuna = null;
		BindingList<Kategorije_transakcije> listaOznacenihKategorija = null;
		DateTime? vrijemeOd = null;
		DateTime? vrijemeDo = null;
		int vrstaTransakcije = 0;

		BindingList<PrikazTransakcije> listaPrikazaTransakcija = new BindingList<PrikazTransakcije>();
		BindingList<PrikazTransakcije> listaFiltriranihPrikazaTransakcije = null;

		//Konstruktor.
		public FrmPregledTransakcija(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			InitializeComponent();
		}

		//postavljanje početnih vrijednosti
		private void FrmPregledTransakcija_Load(object sender, EventArgs e)
		{
			PrilagodiIzgledForme();
			//postavljanje raspon datuma između današnjeg dana i onog mjesec dana kasnije
			dtpVrijemeOd.Value = DateTime.Now.Date;
			dtpVrijemeDo.Value = DateTime.Now.AddMonths(1).AddDays(1).AddMinutes(-1);

			DohvatiSveKorisnikoveZapise();
		}

		/// <summary>
		/// Dohvaćanje svih korisnikovih bankovnih računa, transakcija, kategorija i transakcija investicije.
		/// Dohvaćaju se još i vrste transakcija.
		/// </summary>
		private void DohvatiSveKorisnikoveZapise()
		{
			//Dohvaćanje i prikazivanje svih korisnikovih bankovnih računa (uključujući vrstu računa).
			listaBankovnihRacuna = new BindingList<Bankovni_racun>();
			listaBankovnihRacuna = radnjaNadBankovnimRacunom.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik);
			listaVrstaRacuna = new BindingList<Vrsta_racuna>();
			listaVrstaRacuna = radnjaNadBankovnimRacunom.PrikaziVrsteBankovnihRacuna();
			
			//Dohvaćanje vrsta transakcija.
			listaVrstaTransakcije = new BindingList<Vrsta_transakcije>();
			listaVrstaTransakcije = radnjaNadTransakcijom.DohvatiVrsteTransakcija();

			//Dohvaćanje Transakcija i transakcija investicija.
			listaTransakcijaInvesticije = new BindingList<Transakcija_investicije>();
			listaTransakcijaInvesticije = radnjaNadTransakcijom.DohvatiSveTransakcijeInvesticija(listaBankovnihRacuna);
			listaTransakcija = new BindingList<Transakcija>();
			listaTransakcija = radnjaNadTransakcijom.DohvatiSveTransakcije(listaBankovnihRacuna);

			//Dohvaćanje svih korisnikovih kategorije
			OsvjeziKategorije();

			//Poruka greške.
			if (listaBankovnihRacuna == null)
			{
				MessageBox.Show("Ne postoje bankovni računi!");
				return;
			}
			else btnOsvjeziTransakcije.Enabled = true;


			//Vezemo sve bankovne racune, vrste racuna, vrste transakcija na binding source-ove
			bindingSourceBankovniRacuni.DataSource = listaBankovnihRacuna;
			BindingSourceVrstaRacuna.DataSource = listaVrstaRacuna;
			bindingSourceVrstaTransakcije.DataSource = listaVrstaTransakcije;

			using (var db = new WalletEntities())
			{
				//Sve transakcije spremamo u listu prikaza transakcije
				foreach (Transakcija transakcija in listaTransakcija)
				{
					if (transakcija != null)
					{
						db.Transakcija.Attach(transakcija);

						BindingList<Kategorije_transakcije> listaKategorijaTransakcijeListeTransakcija = new BindingList<Kategorije_transakcije>(transakcija.Kategorije_transakcije.ToList());
						Kategorije_transakcije kategorija = null;
						kategorija = listaKategorijaTransakcijeListeTransakcija[0];
						db.Kategorije_transakcije.Attach(kategorija);

						PrikazTransakcije noviPrikazTransakcije = new PrikazTransakcije(
							transakcija,
							transakcija.vrijeme_transakcije.Value,
							transakcija.Bankovni_racun,
							transakcija.iban,
							transakcija.iznos_transakcije,
							listaKategorijaTransakcijeListeTransakcija,
							transakcija.opis_transakcije,
							kategorija.id_vrsta_transakcije,
							transakcija.lokacija_slike_racuna
							);

						db.Entry(transakcija).State = System.Data.Entity.EntityState.Detached;
						db.Entry(kategorija).State = System.Data.Entity.EntityState.Detached;
						listaPrikazaTransakcija.Add(noviPrikazTransakcije);
					}
				}
				//Sve transakcije investicije spremamo u listu prikaza transakcije
				foreach (Transakcija_investicije transakcija in listaTransakcijaInvesticije)
				{
					if (transakcija != null)
					{
						db.Transakcija_investicije.Attach(transakcija);
						Investicija investicija = transakcija.Investicija;
						db.Investicija.Attach(investicija);

						PrikazTransakcije noviPrikazTransakcije = new PrikazTransakcije(
							transakcija,
							transakcija.vrijeme_transakcije_investicije.Value,
							transakcija.Bankovni_racun,
							transakcija.iban,
							transakcija.iznos_transakcije_investicije.Value,
							transakcija.kolicina_investicije,
							investicija.naziv_investicije,
							transakcija.id_vrsta_transakcije
							);
						db.Entry(transakcija).State = System.Data.Entity.EntityState.Detached;
						listaPrikazaTransakcija.Add(noviPrikazTransakcije);
					}
				}
			}
			OsvjeziPrikazTransakcija();
		}

		/// <summary>
		/// Filtriranje svih korisnikovih transakcija prema označenim check boxevima i odabranom vremenskom razdoblju.
		/// </summary>
		private void OsvjeziPrikazTransakcija()
		{
			//Provjera jesu li odznačene i obične transakcije i transakcije investicija s pripadajućom povratnom porukom
			if (chkTransakcijeInvesticija.Checked == false && chkObicneTransakcije.Checked == false)
			{
				MessageBox.Show("Moraju biti označene barem 'Obične transakcije' ili 'Transakcije investicija'");
				return;
			}
			//Provjera jesu li odznačene i prihodi i rashodi s pripadajućom povratnom porukom
			if (chkPrihodi.Checked == false && chkRashodi.Checked == false)
			{
				MessageBox.Show("Moraju biti označene barem 'Prihodi' ili 'Rashodi'");
				return;
			}

			//Dohvaćanje vremena sa forme.
			vrijemeOd = null;
			vrijemeDo = null;
			if (!chkVrijeme.Checked)
			{
				vrijemeOd = dtpVrijemeOd.Value;
				vrijemeDo = dtpVrijemeDo.Value;
			}

			//Dohvaćanje vrste transakcije: prihod(1) ili rashod(2) ili i prihodi i rashodi(0)
			if		(chkPrihodi.Checked == true  && chkRashodi.Checked == true)	 vrstaTransakcije = 0;
			else if (chkPrihodi.Checked == true	 && chkRashodi.Checked == false) vrstaTransakcije = 1;
			else if (chkPrihodi.Checked == false && chkRashodi.Checked == true)	 vrstaTransakcije = 2;

			//Dohvaćamo označene bankovne račune iz dataGridView-a bankovnih računa.
			listaOznacenihBankovnihRacuna = new BindingList<Bankovni_racun>();
			foreach (DataGridViewRow red in dgvBankovniRacuni.Rows)
			{
				if (red.Cells[1].Value.ToString() == "True" || red.Cells[1].Value.ToString() == "true")
				{
					listaOznacenihBankovnihRacuna.Add(red.DataBoundItem as Bankovni_racun);
				}
			}

			//Dohvaćamo označene kategorije iz dataGridView-a kategorija.
			listaOznacenihKategorija = new BindingList<Kategorije_transakcije>();
			foreach (DataGridViewRow red in dgvKategorije.Rows)
			{
				if (red.Cells[1].Value.ToString() == "True" || red.Cells[1].Value.ToString() == "true")
				{
					listaOznacenihKategorija.Add(red.DataBoundItem as Kategorije_transakcije);
				}
			}

			//Stvaranje liste prikaza transakcija koji će se prikazivati u datagridviewu
			listaFiltriranihPrikazaTransakcije = new BindingList<PrikazTransakcije>();


			//Filtriramo popis Prikaza Transakcija prema uvjetima forme
			bool uvjet;
			foreach (PrikazTransakcije prikazTransakcije in listaPrikazaTransakcija)
			{
				//Provjera vremena
				if (vrijemeOd != null) if (vrijemeOd > prikazTransakcije.Vrijeme || prikazTransakcije.Vrijeme > vrijemeDo) continue;

				//Provjera prihoda(1) ili rashoda(2) ili i prihodi i rashodi(0)
				if (vrstaTransakcije != 0) if (prikazTransakcije.VrstaTransakcije != vrstaTransakcije) continue;

				//Provjera Obična transakcija ili Transakcija investicije
				if (chkObicneTransakcije.Checked != true || chkTransakcijeInvesticija.Checked != true)
				{
					if (chkObicneTransakcije.Checked == true && prikazTransakcije.KategorijeTransakcije == null) continue;
					if (chkTransakcijeInvesticija.Checked == true && prikazTransakcije.KategorijeTransakcije != null) continue;
				}


				//provjera bankovnih računa
				uvjet = false;
				using (var db = new WalletEntities())
				{
					foreach (Bankovni_racun racun in listaOznacenihBankovnihRacuna)
					{
						db.Bankovni_racun.Attach(racun);

						if (prikazTransakcije.iban == racun.iban)
						{
							//Zadovoljava uvjet da transakcija ima jedan od označenih računa
							uvjet = true;
						}
						db.Entry(racun).State = System.Data.Entity.EntityState.Detached;
						if (uvjet == true) break;
					}
				}
				if (uvjet == false) continue;

				//Provjera kategorija
				uvjet = false;
				if (prikazTransakcije.TransakcijaInvesticije != null) uvjet = true;
				else
				{
					using (var db = new WalletEntities())
					{
						foreach (Kategorije_transakcije kategorija in prikazTransakcije.KategorijeTransakcije)
						{
							foreach (Kategorije_transakcije oznacenaKategorija in listaOznacenihKategorija)
							{
								db.Kategorije_transakcije.Attach(kategorija);
								int idKategorijePrikaza = kategorija.id_kategorije_transakcije;
								db.Entry(kategorija).State = System.Data.Entity.EntityState.Detached;
								db.Kategorije_transakcije.Attach(oznacenaKategorija);

								if (idKategorijePrikaza == oznacenaKategorija.id_kategorije_transakcije)
								{
									//Zadovoljava uvjet da transakcija ima jednu od označenih kategorija
									uvjet = true;
								}
								db.Entry(oznacenaKategorija).State = System.Data.Entity.EntityState.Detached;
								if (uvjet == true) break;
							}
							if (uvjet == true) break;
						}
					}
				}
				if (uvjet == false) continue;

				listaFiltriranihPrikazaTransakcije.Add(prikazTransakcije);
			}

			bindingSourcePregledTransakcija.Clear();
			bindingSourcePregledTransakcija.DataSource = listaFiltriranihPrikazaTransakcije.OrderByDescending(x => x.Vrijeme);
			
		}

		#region CheckBoxevi funkcionalnosti

		//Obicne transakcije check box.
		private void chkObicneTransakcije_CheckedChanged(object sender, EventArgs e)
		{
			PrilagodiIzgledForme();
		}

		

		//Prihodi check box.
		private void chkPrihodi_CheckedChanged(object sender, EventArgs e)
		{
			OsvjeziKategorije();
		}

		//Rashodi check box.
		private void chkRashodi_CheckedChanged(object sender, EventArgs e)
		{
			OsvjeziKategorije();
		}

		//Svo vrijeme check box.
		private void chkVrijeme_CheckedChanged(object sender, EventArgs e)
		{
			dtpVrijemeOd.Enabled = !(chkVrijeme.Checked);
			dtpVrijemeDo.Enabled = !(chkVrijeme.Checked);
		}

		//Svi računi check box.
		private void chkSviBankovniRacuni_CheckedChanged(object sender, EventArgs e)
		{
			OznacitiSveCheckBoxeve(dgvBankovniRacuni, chkSviBankovniRacuni);
		}

		//Sve kategorije check box.
		private void chkSveKategorije_CheckedChanged(object sender, EventArgs e)
		{
			OznacitiSveCheckBoxeve(dgvKategorije, chkSveKategorije);
		}

		//Promjena sadržaja dgvBankovniRacuni oznacuje sve bankovne racune.
		private void dgvBankovniRacuni_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			chkSviBankovniRacuni.Checked = true;
			OznacitiSveCheckBoxeve(dgvBankovniRacuni, chkSviBankovniRacuni);
		}
		

		//Promjena sadržaja dgvKategorije oznacuje sve kategorije transakcija.
		private void dgvKategorije_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			chkSveKategorije.Checked = true;
			OznacitiSveCheckBoxeve(dgvKategorije, chkSveKategorije);
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

		/// <summary>
		/// Dohvaća sve kategorije na temelju označenih prihoda ili rashoda te ih stavlja u dgvKategorije.
		/// </summary>
		private void OsvjeziKategorije()
		{
			if (chkPrihodi.Checked == true && chkRashodi.Checked == true) listaKategorijaTransakcija = radnjaNadTransakcijom.DohvatiKategorijeKorisnika(trenutniKorisnik, 0);
			else if (chkPrihodi.Checked == true && chkRashodi.Checked == false) listaKategorijaTransakcija = radnjaNadTransakcijom.DohvatiKategorijeKorisnika(trenutniKorisnik, 1);
			else if (chkPrihodi.Checked == false && chkRashodi.Checked == true) listaKategorijaTransakcija = radnjaNadTransakcijom.DohvatiKategorijeKorisnika(trenutniKorisnik, 2);
			else if (chkPrihodi.Checked == false && chkRashodi.Checked == false) listaKategorijaTransakcija.Clear();
			bindingSourceKategorije.DataSource = listaKategorijaTransakcija;
		}

		private void PrilagodiIzgledForme()
		{
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

		private void btnOsvjeziTransakcije_Click(object sender, EventArgs e)
		{
			OsvjeziPrikazTransakcija();
		}

		private void dgvPregledTransakcija_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (dgvPregledTransakcija.ColumnCount > 0 && dgvPregledTransakcija.Columns["Datum"] != null)
			{
				dgvPregledTransakcija.Columns[1].ValueType = typeof(DateTime);
				dgvPregledTransakcija.Sort(dgvPregledTransakcija.Columns["Datum"], ListSortDirection.Descending);
			}
		}

		private void btnObrisi_Click(object sender, EventArgs e)
		{
			//Uvjet za brisanje je da ne smije biti prazan dgvPregledTransakcija i da mora biti označen barem jedan red.
			if (dgvPregledTransakcija.RowCount == 0 || dgvPregledTransakcija.SelectedRows.Count != 1) return;
			PrikazTransakcije prikazTransakcijeZaBrisanje = dgvPregledTransakcija.CurrentRow.DataBoundItem as PrikazTransakcije;

			if (prikazTransakcijeZaBrisanje.ObicnaTransakcija != null) radnjaNadTransakcijom.ObrisiTransakciju(prikazTransakcijeZaBrisanje.ObicnaTransakcija);
			if (prikazTransakcijeZaBrisanje.TransakcijaInvesticije != null)
			{
				using (WalletEntities db = new WalletEntities())
				{
					db.Transakcija_investicije.Attach(prikazTransakcijeZaBrisanje.TransakcijaInvesticije);
					db.Transakcija_investicije.Remove(prikazTransakcijeZaBrisanje.TransakcijaInvesticije);
					db.SaveChanges();
				}
			}
			listaPrikazaTransakcija.Clear();
			DohvatiSveKorisnikoveZapise();
		}

		//Klik gumba btnReport otvara dialog formu koja prikazuje report sa trenutnim prikazov dgvPregledTransakcija
		private void btnReport_Click(object sender, EventArgs e)
		{
			Dialog_forme.FrmReportTransakcija frmReportTransakcija = new Dialog_forme.FrmReportTransakcija(listaFiltriranihPrikazaTransakcije);
			frmReportTransakcija.ShowDialog();
		}

		//Označavanjem reda u dgvPregledTransakcija prikazuje nam se opis odabrane transakcije u text boxu ispod dataGridView-a
		private void dgvPregledTransakcija_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvPregledTransakcija.CurrentRow == null) return;
			PrikazTransakcije prikazTransakcije = dgvPregledTransakcija.CurrentRow.DataBoundItem as PrikazTransakcije;
			if (prikazTransakcije == null) return;
			txtOpis.Text = "Opis:" + System.Environment.NewLine + prikazTransakcije.Opis;
			if (prikazTransakcije.LokacijaSlike != null)
			{
				txtLokacijaSlike.Text = prikazTransakcije.LokacijaSlike;
				txtLokacijaSlike.Visible = true;
				btnPrikaziSliku.Visible = true;
			}
			else
			{
				txtLokacijaSlike.Text = null;
				txtLokacijaSlike.Visible = false;
				btnPrikaziSliku.Visible = false;
			}
		}

		private void btnPrikaziSliku_Click(object sender, EventArgs e)
		{
			Dialog_forme.FrmPrikazSlike prikazSlike = new Dialog_forme.FrmPrikazSlike(txtLokacijaSlike.Text);
			prikazSlike.ShowDialog();
		}
	}
}
