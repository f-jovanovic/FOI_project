using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon
{
	class UpravljanjeBankovnimRacunima
	{
		UpravljanjeTransakcijom upravljanjeTransakcijom = new UpravljanjeTransakcijom();
		
		/// <summary>
		/// Metoda koja vraća binding listu svih bankovnih računa odabranog korisnika
		/// </summary>
		public BindingList<Bankovni_racun> PrikaziBankovneRacunePremaKorisniku(Korisnik trenutniKorisnik)
		{
			BindingList<Bankovni_racun> listaRacuna = null;
			using (var db = new WalletEntities())
			{
				db.Korisnik.Attach(trenutniKorisnik);
				listaRacuna = new BindingList<Bankovni_racun>(trenutniKorisnik.Bankovni_racun.ToList<Bankovni_racun>());
			}
			return listaRacuna;
		}

		/// <summary>
		/// Metoda koja vraća binding listu svih vrsta bankovnih računa.
		/// </summary>
		public BindingList<Vrsta_racuna> PrikaziVrsteBankovnihRacuna()
		{
			BindingList<Vrsta_racuna> listaVrstaRacuna = null;
			using (var db = new WalletEntities())
			{
				listaVrstaRacuna = new BindingList<Vrsta_racuna>(db.Vrsta_racuna.ToList());
			}
			return listaVrstaRacuna;
		}

		/// <summary>
		/// Metoda koja briše odabrani račun.
		/// Također brišemo i sve transakcije povezane na bankovni račun 
		/// kao i sve veze istih transakcija s kategorijama transakcija koje su spremljene u tablici Transakcija_ima_kategorije.
		/// </summary>
		public void ObrisiRacun(Bankovni_racun odabraniRacun)
		{
			if (odabraniRacun != null)
			{
				if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					ObrisiSveTransakcijeRacuna(odabraniRacun);
					//nakon provjere (i brisanja postojećih) transakcija i transakcija investicija brišemo račun
					using (var db = new WalletEntities())
					{
						db.Bankovni_racun.Attach(odabraniRacun);
						db.Bankovni_racun.Remove(odabraniRacun);
						db.SaveChanges();
					}
				}
			}
			else MessageBox.Show("Morate prvo odabrati postojeći račun da biste ga obrisali.");
		}

		/// <summary>
		/// Metoda koja briše sve postojeće transakcije iz tablice Transakcija i Transakcija_investicija vezane na odabrani bankovni račun.
		/// </summary>
		public void ObrisiSveTransakcijeRacuna(Bankovni_racun odabraniRacun)
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
			foreach (var transakcija in listaTransakcija) upravljanjeTransakcijom.ObrisiTransakciju(transakcija);
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
