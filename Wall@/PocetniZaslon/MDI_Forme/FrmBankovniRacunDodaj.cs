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
		private Korisnik trenutniKorisnik = null;
		private Bankovni_racun odabraniRacun = null;

		//konstruktor za stvaranje bankovnog računa
		public FrmBankovniRacunDodaj(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			InitializeComponent();
			PrikaziVrsteBankovnihRacuna();
		}

		//konstruktor za uređivanje postojećeg bankovnog računa
		public FrmBankovniRacunDodaj(Korisnik korisnik, Bankovni_racun racun)
		{
			odabraniRacun = racun;

			InitializeComponent();

			this.Text = "Uređivanje računa";
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

		private void PrikaziVrsteBankovnihRacuna()
		{
			BindingList<Vrsta_racuna> listaVrstaRacuna = null;
			using (var db = new WalletEntities())
			{
				listaVrstaRacuna = new BindingList<Vrsta_racuna>(db.Vrsta_racuna.ToList());
			}
			vrstaracunaBindingSource.DataSource = listaVrstaRacuna;
		}

		//dodavanje novog korisnika
		private void btnDodajNoviRacun_Click(object sender, EventArgs e)
		{
			Vrsta_racuna odabranaVrstaRacuna = vrstaracunaBindingSource.Current as Vrsta_racuna;
			using (var db = new WalletEntities())
			{
				if (odabraniRacun == null)
				{
					Bankovni_racun provjera = null;
					provjera = (from t in db.Bankovni_racun
								where t.iban == txtIban.Text
								select t).First<Bankovni_racun>();
					if (provjera != null)
					{
						MessageBox.Show("Iban " + provjera.iban + " već postoji u bazi podataka.");
						return;
					}

					db.Korisnik.Attach(trenutniKorisnik);
					db.Vrsta_racuna.Attach(odabranaVrstaRacuna);
					Bankovni_racun noviBankovniRacun = new Bankovni_racun
					{
						iban = txtIban.Text,
						naziv_racuna = txtNazivRacuna.Text,
						stanje_racuna = decimal.Parse(txtStanjeRacuna.Text),
						Korisnik = trenutniKorisnik,
						Vrsta_racuna = odabranaVrstaRacuna
					};
					db.Bankovni_racun.Add(noviBankovniRacun);
					db.SaveChanges();
				}
				else
				{
					db.Bankovni_racun.Attach(odabraniRacun);
					odabraniRacun.naziv_racuna = txtNazivRacuna.Text;
					db.SaveChanges();
				}
				
			}
			this.Close();
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
