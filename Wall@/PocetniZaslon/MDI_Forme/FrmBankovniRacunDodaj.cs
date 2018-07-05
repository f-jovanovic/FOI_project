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
	public partial class FrmBankovniRacunDodaj : Form
	{
		UpravljanjeBankovnimRacunima radnjaNadBankovnimRacunom = new UpravljanjeBankovnimRacunima();
		private Korisnik trenutniKorisnik = null;
		private Bankovni_racun odabraniRacun = null;

		//konstruktor za stvaranje bankovnog računa
		public FrmBankovniRacunDodaj(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			InitializeComponent();
			vrstaracunaBindingSource.DataSource = radnjaNadBankovnimRacunom.PrikaziVrsteBankovnihRacuna();
		}

		//konstruktor za uređivanje postojećeg bankovnog računa koji također mijenja izgled forme namjenjen za uređivanje bankovnog računa
		public FrmBankovniRacunDodaj(Korisnik korisnik, Bankovni_racun racun)
		{
			odabraniRacun = racun;

			InitializeComponent();
			//mijenjanje izgleda i unaprijed unesenih stvari u formu jer se radi nad postojećim računom
			this.Text = "Uređivanje računa";
			lblMojiBankovniRacuni.Text = "Uređivanje bankovnog računa";
            lblMojiBankovniRacuni.Location = new Point(this.Width / 2 - lblMojiBankovniRacuni.Width / 2, lblMojiBankovniRacuni.Location.Y);

            btnDodajNoviRacun.Text = "Promijeni";
			txtIban.Enabled = false;
			txtStanjeRacuna.Enabled = false;
			cboVrstaRacuna.Enabled = false;

			txtNazivRacuna.Text = odabraniRacun.naziv_racuna;
			txtIban.Text = odabraniRacun.iban;
			txtStanjeRacuna.Text = odabraniRacun.stanje_racuna.ToString();

			using (var db = new WalletEntities())
			{
				Vrsta_racuna vrsta = (from t in db.Vrsta_racuna
									  where t.id_vrsta_racuna == odabraniRacun.id_vrsta_racuna
									  select t).First<Vrsta_racuna>();
				cboVrstaRacuna.Text = vrsta.naziv_vrste_racuna;
			}
		}
		
		/// <summary>
		/// Metoda koja provjerava postoji li IBAN upisan u text boxu txtIban u bazi podataka. Vraća true ako postoji ili false ako ne postoji
		/// </summary>
		private bool ProvjeraJedinstvenostiIbana(string nazivRacuna)
		{
			bool postojiRacunSIstimIbanom = false;
			using (var db = new WalletEntities())
			{
				List<Bankovni_racun> listaBankovnihRacuna = new List<Bankovni_racun>(db.Bankovni_racun.ToList());
				//Prolazimo kroz listu svih računa i provjeravamo postoji li račun s istim IBAN-om
				foreach (var bankovniRacun in listaBankovnihRacuna) if (bankovniRacun.iban.ToUpper() == nazivRacuna) postojiRacunSIstimIbanom = true;
			}
			return postojiRacunSIstimIbanom;
		}

		/// <summary>
		/// Metoda koja dodaje novi bankovni račun
		/// </summary>
		private void dodajNoviRacun(string iban, string nazivRacuna, decimal stanjeRacuna, Korisnik korisnik, Vrsta_racuna odabranaVrstaRacuna)
		{
			if (ProvjeraJedinstvenostiIbana(iban)) MessageBox.Show("Uneseni IBAN već postoji u bazi podataka.");
			else
			{
				using (var db = new WalletEntities())
				{
					db.Korisnik.Attach(korisnik);
					db.Vrsta_racuna.Attach(odabranaVrstaRacuna);

					Bankovni_racun noviBankovniRacun = new Bankovni_racun
					{
						iban = iban,
						naziv_racuna = nazivRacuna,
						stanje_racuna = stanjeRacuna,
						Korisnik = korisnik,
						Vrsta_racuna = odabranaVrstaRacuna
					};
					db.Bankovni_racun.Add(noviBankovniRacun);
					db.SaveChanges();
					db.Entry(korisnik).State = System.Data.Entity.EntityState.Detached;
					db.Entry(odabranaVrstaRacuna).State = System.Data.Entity.EntityState.Detached;
				}
				this.Close();
			}
		}

		/// <summary>
		/// Metoda koja uređuje odabrani bankovni račun
		/// </summary>
		private void urediRacun(Bankovni_racun bankovniRacun, string nazivRacuna ,Vrsta_racuna odabranaVrstaRacuna)
		{
			using (var db = new WalletEntities())
			{
				db.Bankovni_racun.Attach(bankovniRacun);
				odabraniRacun.naziv_racuna = nazivRacuna;
				db.SaveChanges();
			}
			this.Close();
		}

		private void btnDodajNoviRacun_Click(object sender, EventArgs e)
		{
			Vrsta_racuna odabranaVrstaRacuna = vrstaracunaBindingSource.Current as Vrsta_racuna;
			//Određuje se radi li se o unosu novog računa ili uređivanju postojećeg
			if (odabraniRacun == null) dodajNoviRacun(txtIban.Text.ToUpper(), txtNazivRacuna.Text, decimal.Parse(txtStanjeRacuna.Text), trenutniKorisnik, odabranaVrstaRacuna);
			else urediRacun(odabraniRacun, txtNazivRacuna.Text, odabranaVrstaRacuna);
		}

		#region Unošenje teksta, prikazivanje ograničenja i aktivacija gumba

		private void TxtNazivRacuna_TextChanged(object sender, EventArgs e)
		{
			OmoguciStvaranje();
		}

		private void TxtIban_TextChanged(object sender, EventArgs e)
		{
			OmoguciStvaranje();
			lblUpozorenjeIban.Visible = (txtIban.TextLength != 21);
		}

		private void txtStanjeRacuna_TextChanged(object sender, EventArgs e)
		{
			OmoguciStvaranje();
		}

		private void OmoguciStvaranje()
		{
			btnDodajNoviRacun.Enabled = (!string.IsNullOrWhiteSpace(txtStanjeRacuna.Text) && !string.IsNullOrWhiteSpace(txtNazivRacuna.Text) && !string.IsNullOrWhiteSpace(txtIban.Text) && txtIban.TextLength == 21);
		}

		private void btnOtkazi_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion
	}
}
