using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon
{
    public class UpravljanjeTransakcijom
    {
        /// <summary>
        /// Metoda koja dodaje transakciju u bazu, te sukladno vrsti transakcije mijenja iznos na računu.
        /// Potrebno joj je proslijediti vrijednosti sa kontrola na formi, listu kategorija i ID vrste transakcije (1 - prihod, 2 - rashod).
        /// Vraća istu tu transakciju koja se dodala.
        /// </summary>
        /// <param name="idVrstaTransakcije"></param>
        /// <param name="bankovniRacun"></param>
        /// <param name="iznosTransakcije"></param>
        /// <param name="vrijemeTransakcije"></param>
        /// <param name="opisTransakcije"></param>
        /// <param name="kategorijeTransakcije"></param>
        public Transakcija DodajTransakciju(int idVrstaTransakcije, BindingSource bankovniRacun, string iznosTransakcije, DateTime vrijemeTransakcije, string opisTransakcije, List<string> kategorijeTransakcije, string lokacijaSlike)
        {
            Transakcija novaTransakcija = null;
            using (WalletEntities db = new WalletEntities())
            {
                // Dohvati bankovni račun preko proslijeđenog binding sourcea.
                db.Bankovni_racun.Attach(bankovniRacun.Current as Bankovni_racun);

                novaTransakcija = new Transakcija
                {
                    Bankovni_racun = bankovniRacun.Current as Bankovni_racun,
                    iznos_transakcije = decimal.Parse(iznosTransakcije),
                    vrijeme_transakcije = vrijemeTransakcije,
                    opis_transakcije = opisTransakcije
                };

                if (lokacijaSlike != null) novaTransakcija.lokacija_slike_racuna = lokacijaSlike;

                // Spoji odabrane kategorije na transakciju.
                foreach (var item in kategorijeTransakcije)
                {
                    Kategorije_transakcije dodajKategoriju = (from t in db.Kategorije_transakcije
                                                              where t.naziv_kategorije == item.ToString() && t.id_vrsta_transakcije == idVrstaTransakcije
                                                              select t).First();

                    novaTransakcija.Kategorije_transakcije.Add(dodajKategoriju);
                }

                // Spoji novu transakciju sa kategorijama koje su označene na formi.
                foreach (var item in kategorijeTransakcije)
                {
                    foreach (var kategorija in db.Kategorije_transakcije.ToList())
                    {
                        if (kategorija.naziv_kategorije.ToString() == item.ToString()) kategorija.Transakcija.Add(novaTransakcija);
                    }
                }

                // Ovisno o vrsti transakcije, promijeni iznos bankovnog računa na kojeg je vezana transakcija.
                if (idVrstaTransakcije == 1)
                {
                    foreach (Bankovni_racun racun in db.Bankovni_racun)
                    {
                        if (racun == bankovniRacun.Current) racun.stanje_racuna += novaTransakcija.iznos_transakcije;
                    }
                }
                else if (idVrstaTransakcije == 2)
                {
                    foreach (Bankovni_racun racun in db.Bankovni_racun)
                    {
                        if (racun == bankovniRacun.Current) racun.stanje_racuna -= novaTransakcija.iznos_transakcije;
                    }
                }

                db.Transakcija.Add(novaTransakcija);
                db.SaveChanges();
            }
            return novaTransakcija;
        }
		
		/// <summary>
		/// Metoda koja briše odabranu transakciju. 
		/// Također se brišu i sve veze transakcija s kategorijama transakcija koje su spremljene u tablici Transakcija_ima_kategorije.
		/// Također briše vanjski ključ id_
		/// </summary>
		/// <param name="odabranaTransakcija"></param>
		public void ObrisiTransakciju(Transakcija odabranaTransakcija)
		{
			if (odabranaTransakcija != null)
			{
				using (var db = new WalletEntities())
				{
					db.Transakcija.Attach(odabranaTransakcija);
					Transakcija vlastitaTransakcija = odabranaTransakcija.Transakcija2;
					//Ako se radi o računu na koji smo izvršili prijenos novca
					if (vlastitaTransakcija != null)
					{
						odabranaTransakcija.Transakcija2 = null;
						db.Transakcija.Attach(vlastitaTransakcija);
						vlastitaTransakcija.Transakcija2 = null;
						
					}
					db.SaveChanges();

					db.Entry(odabranaTransakcija).State = System.Data.Entity.EntityState.Detached;
					if (vlastitaTransakcija != null) db.Entry(vlastitaTransakcija).State = System.Data.Entity.EntityState.Detached;

					db.Database.ExecuteSqlCommand("DELETE from Transakcija_ima_kategorije WHERE id_transakcije = " + odabranaTransakcija.id_transakcije);
					db.SaveChanges();

					db.Transakcija.Attach(odabranaTransakcija);
					db.Transakcija.Remove(odabranaTransakcija);
					db.SaveChanges();
				}
			}
			else MessageBox.Show("Transakcija nije odabrana. Brisanje nije moguće.");
		}

		/// <summary>
		/// Metoda koja vraća binding listu svih transakcija prema listi bankovnih računa i prema kategorijama transakcije.
		/// Za dohvaćanje bez obzira na kategorije, metodu pozivamo s listomKategorijaTransakcije s null vrijenošću.
		/// </summary>
		public BindingList<Transakcija> DohvatiSveTransakcije(BindingList<Bankovni_racun> listaBankovnihRacuna)
		{
			BindingList<Transakcija> listaTransakcija = new BindingList<Transakcija>();
			using (var db = new WalletEntities())
			{
				foreach (Bankovni_racun racun in listaBankovnihRacuna)
				{
					db.Bankovni_racun.Attach(racun);
					foreach (Transakcija transakcija in racun.Transakcija)	listaTransakcija.Add(transakcija);
					db.Entry(racun).State = System.Data.Entity.EntityState.Detached;
				}
			}
			
			listaTransakcija.OrderByDescending(x => x.vrijeme_transakcije);
			return listaTransakcija;
		}

		/// <summary>
		/// Metoda koja vraća binding listu svih transakcija investicija prema listi bankovnih računa.
		/// </summary>
		public BindingList<Transakcija_investicije> DohvatiSveTransakcijeInvesticija(BindingList<Bankovni_racun> listaBankovnihRacuna)
		{
			BindingList<Transakcija_investicije> listaTransakcija = new BindingList<Transakcija_investicije>();
			using (var db = new WalletEntities())
			{
				foreach (Bankovni_racun racun in listaBankovnihRacuna)
				{
					db.Bankovni_racun.Attach(racun);
					foreach (Transakcija_investicije transakcija in racun.Transakcija_investicije) listaTransakcija.Add(transakcija);
					db.Entry(racun).State = System.Data.Entity.EntityState.Detached;
				}

			}
			listaTransakcija.OrderBy(x => x.vrijeme_transakcije_investicije);
			return listaTransakcija;
		}

		/// <summary>
		/// Metoda koja vraća binding listu kategorija odabranog korisnika. Parametar idVrstaTransakcije određuje dohvaćanje: 
		/// 0 - svih kategorija, 1 - prihodi, 2 - rashodi.
		/// </summary>
		public BindingList<Kategorije_transakcije> DohvatiKategorijeKorisnika(Korisnik trenutniKorisnik, int idVrsteTransakcije)
		{
			BindingList<Kategorije_transakcije> listaKategorijaKorisnika = new BindingList<Kategorije_transakcije>();
			using (var db = new WalletEntities())
			{
				db.Korisnik.Attach(trenutniKorisnik);
				//Ispituje se je li uzimanje svih kategorija korisnika ili samo prihoda/rashoda
				if (idVrsteTransakcije == 0) listaKategorijaKorisnika = new BindingList<Kategorije_transakcije>(trenutniKorisnik.Kategorije_transakcije.ToList());
				else
				{
					listaKategorijaKorisnika = new BindingList<Kategorije_transakcije>();
					foreach (Kategorije_transakcije kategorija in trenutniKorisnik.Kategorije_transakcije.ToList())
					{
						db.Kategorije_transakcije.Attach(kategorija);
						if (idVrsteTransakcije == kategorija.id_vrsta_transakcije) listaKategorijaKorisnika.Add(kategorija);
						db.Entry(kategorija).State = System.Data.Entity.EntityState.Detached;
					}
				}
				listaKategorijaKorisnika.OrderBy(x => x.naziv_kategorije);
				foreach (Kategorije_transakcije kategorija in db.Kategorije_transakcije.ToList())
				{
					db.Kategorije_transakcije.Attach(kategorija);
					if (idVrsteTransakcije == 0) { if (kategorija.id_kategorije_transakcije == 1 || kategorija.id_kategorije_transakcije == 2) listaKategorijaKorisnika.Add(kategorija); }
					else if (kategorija.id_kategorije_transakcije == idVrsteTransakcije) listaKategorijaKorisnika.Add(kategorija);
					db.Entry(kategorija).State = System.Data.Entity.EntityState.Detached;
				}
			}
			return listaKategorijaKorisnika;
		}

		/// <summary>
		/// Metoda koja vraća binding listu svih vrsta transakcija.
		/// </summary>
		public BindingList<Vrsta_transakcije> DohvatiVrsteTransakcija()
		{
			BindingList<Vrsta_transakcije> listaVrstaTransakcija = new BindingList<Vrsta_transakcije>();
			using (var db = new WalletEntities())
			{
				listaVrstaTransakcija = new BindingList<Vrsta_transakcije>(db.Vrsta_transakcije.ToList());
			}
			return listaVrstaTransakcija;
		}
	}
}
