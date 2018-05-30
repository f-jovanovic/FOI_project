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
	public partial class FrmInvesticijskiPortfolio : Form
	{
		Korisnik trenutniKorisnik = null;
		
		public FrmInvesticijskiPortfolio(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			InitializeComponent();
			lblInvesticijskiPortfolio.Location = new Point(this.Width / 2 - lblInvesticijskiPortfolio.Width / 2, lblInvesticijskiPortfolio.Location.Y);
			PrikaziBankovneRacunePremaKorisniku();
			PrikaziVrsteInvesticije();
		}
		/// <summary>
		/// Prikazuje postojece bankovne racune korisnika
		/// </summary>
		private void PrikaziBankovneRacunePremaKorisniku()
		{
			BindingList<Bankovni_racun> listaRacuna = null;
			using (var db = new WalletEntities())
			{
				db.Korisnik.Attach(trenutniKorisnik);
				listaRacuna = new BindingList<Bankovni_racun>(trenutniKorisnik.Bankovni_racun.ToList<Bankovni_racun>());
			}
			bankovniracunBindingSource.DataSource = listaRacuna;
		}
		/// <summary>
		/// metoda koja popunjava combo box s vrstama investicije
		/// </summary>
		private void PrikaziVrsteInvesticije()
		{
			BindingList<Vrsta_investicije> listaVrstaInvesticija = null;

			using (var db = new WalletEntities())
			{
				listaVrstaInvesticija = new BindingList<Vrsta_investicije>(db.Vrsta_investicije.ToList());
			}
			vrstainvesticijeBindingSource.DataSource = listaVrstaInvesticija;
		}

		private void rBtnKupi_CheckedChanged(object sender, EventArgs e)
		{
			KupiInvesticiju();
		}

		/// <summary>
		/// Ova metoda služi kako bi korisnik mogao kupiti investiciju
		/// </summary>
		private void KupiInvesticiju()
		{
		}

		private void btnDodajInvesticiju_Click(object sender, EventArgs e)
		{
			DodajInvesticiju();
		}
		

		/// <summary>
		/// metoda za dodavanje investicije koju korisnik zeli kupiti
		/// </summary>
		private void DodajInvesticiju()
		{
			//to do 
			//provjera postoji li investicija istog naziva - dun
			//dodavanje investicije - ovo jesi

			Vrsta_investicije vrsta = null;
			vrsta = vrstainvesticijeBindingSource.Current as Vrsta_investicije;
			bool postojiNaziv = false;
			postojiNaziv = ProvjeraNazivaInvesticije(postojiNaziv);

			if (postojiNaziv == true)
			{
				MessageBox.Show("Investicija s unešenim nazivom već postoji");
			}
			else
			{
				using (var db = new WalletEntities())
				{
					db.Vrsta_investicije.Attach(vrsta);
					Investicija novaInvesticija = new Investicija
					{
						naziv_investicije = txtBoxNazivInvesticije.Text,
						Vrsta_investicije = vrsta
						
					};
					db.Investicija.Add(novaInvesticija);
					db.SaveChanges();
					db.Entry(vrsta).State = System.Data.Entity.EntityState.Deleted;
					gBoxInvesticije.Text = txtBoxNazivInvesticije.Text.ToString();
					gBoxInvesticije.Refresh();
				}

			}
			txtBoxNazivInvesticije.Clear();
		}
		/// <summary>
		/// provjerava postoji li uneseni naziv investicije u bazi
		/// </summary>
		/// <param name="postojiNaziv"></param>
		/// <returns></returns>
		private bool ProvjeraNazivaInvesticije(bool postojiNaziv)
		{
			using (var db = new WalletEntities())
			{
				postojiNaziv = false;
				List<Investicija> listaInvesticija = new List<Investicija>(db.Investicija.ToList());

				foreach (var investicija in listaInvesticija) if (investicija.naziv_investicije.ToLower() == txtBoxNazivInvesticije.Text.ToLower()) postojiNaziv = true;
			}
			return postojiNaziv;
		}
	}
}
