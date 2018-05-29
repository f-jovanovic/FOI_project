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
	public partial class FrmBankovniRacuni : Form
	{
		Korisnik trenutniKorisnik = null;

		public FrmBankovniRacuni(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			InitializeComponent();
			PrikaziBankovneRacunePremaKorisniku();
		}
		/// <summary>
		/// Metoda koja vraća listu svih bankovnih računa trenutnog korisnika
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


		//Ovisno o odabranom racunu unutar combo boxa prikazuje nam se IBAN, vrsta racuna i stanje racuna
		private void PrikaziPodatkeOdabranogRacuna()
		{
			Bankovni_racun odabraniBankovniRacun = bankovniracunBindingSource.Current as Bankovni_racun;
			if (odabraniBankovniRacun != null)
			{
				lblIbanOdabranogRacuna.Text = odabraniBankovniRacun.iban;
				//dohvaćamo naziv vrste računa preko vanjskog ključa
				using (var db = new WalletEntities())
				{
					Vrsta_racuna vrsta = (from t in db.Vrsta_racuna
										  where t.id_vrsta_racuna == odabraniBankovniRacun.id_vrsta_racuna
										  select t).First<Vrsta_racuna>();
					lblVrstaOdabranogRacuna.Text = vrsta.naziv_vrste_racuna;
				}
				lblStanjeOdabranogRacuna.Text = odabraniBankovniRacun.stanje_racuna.ToString();
			}
			
		}

		//pri promjeni binding sourcea trenutno selektiranog računa u combo boxu odaberite račun poziva se metoda koja mjenja informacije
		//o tom odabranom računu (ispod piše IBAN, vrsta računa i stanje računa)
		private void bankovniracunBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			PrikaziPodatkeOdabranogRacuna();
		}

		private void btnDodajNoviRacun_Click(object sender, EventArgs e)
		{
			MDI_Forme.FrmBankovniRacunDodaj formaDodavanjaRacuna = new FrmBankovniRacunDodaj(trenutniKorisnik);
			formaDodavanjaRacuna.ShowDialog();
			PrikaziBankovneRacunePremaKorisniku();
		}

		private void btnUredi_Click(object sender, EventArgs e)
		{
			Bankovni_racun odabraniRacun = bankovniracunBindingSource.Current as Bankovni_racun;
			if(odabraniRacun != null)
			{
				MDI_Forme.FrmBankovniRacunDodaj formaDodavanjaRacuna = new FrmBankovniRacunDodaj(trenutniKorisnik, odabraniRacun);
				formaDodavanjaRacuna.ShowDialog();
				PrikaziBankovneRacunePremaKorisniku();
			}
		}

		//BRISANJE RAČUNA, JAKO BITNO MIJENJATI AKO JE RAČUN VEĆ VEZAN NA NEŠTO
		private void btnObrisi_Click(object sender, EventArgs e)
		{
			BrisanjeRacuna();
		}

		/// <summary>
		/// Metoda koja briše odabrani račun
		/// </summary>
		private void BrisanjeRacuna()
		{
			Bankovni_racun odabraniRacun = bankovniracunBindingSource.Current as Bankovni_racun;
			if (odabraniRacun != null)
			{
				if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					//provjera ako postoje transakcije ili transakcije investicija vezane na bankovni račun, ako postoje onda se brišu
					ObrisiTransakcijeITransakcijeInvesticija(odabraniRacun);
					//nakon provjere (i brisanja postojećih) transakcija i transakcija investicija brišemo račun
					using (var db = new WalletEntities())
					{
						db.Bankovni_racun.Attach(odabraniRacun);
						db.Bankovni_racun.Remove(odabraniRacun);
						db.SaveChanges();
					}
				}
			}
			PrikaziBankovneRacunePremaKorisniku();
		}

		/// <summary>
		/// Metoda koja briše sve transakcije iz tablice Transakcija i Transakcija_investicija koje imaju vanjski ključ na odabrani bankovni račun
		/// </summary>
		private void ObrisiTransakcijeITransakcijeInvesticija(Bankovni_racun odabraniRacun)
		{
			List<Transakcija> listaTransakcija = new List<Transakcija>();
			List<Transakcija_investicije> listaTransakcijaInvesticija = new List<Transakcija_investicije>();
			using (var db = new WalletEntities())
			{
				db.Bankovni_racun.Attach(odabraniRacun);
				listaTransakcija = odabraniRacun.Transakcija.ToList();
				listaTransakcijaInvesticija = odabraniRacun.Transakcija_investicije.ToList();

			}
			//brisanje svih povezanih transakcija za odabrani račun
			foreach (var transakcija in listaTransakcija)
			{
				using (var db = new WalletEntities())
				{
					if (transakcija.iban == odabraniRacun.iban)
					{
						db.Transakcija.Attach(transakcija);
						db.Transakcija.Remove(transakcija);
						db.SaveChanges();
					}
				}
			}
			//brisanje svih povezanih transakcija investicije za odabrani račun
			foreach (var transakcijaInvesticije in listaTransakcijaInvesticija)
			{
				using (var db = new WalletEntities())
				{
					if (transakcijaInvesticije.iban == odabraniRacun.iban)
					{
						db.Transakcija_investicije.Attach(transakcijaInvesticije);
						db.Transakcija_investicije.Remove(transakcijaInvesticije);
						db.SaveChanges();
					}
				}
			}
		}
	}
}
