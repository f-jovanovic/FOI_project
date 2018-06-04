using System;
using System.Collections.Generic;
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
        /// </summary>
        /// <param name="idVrstaTransakcije"></param>
        /// <param name="bankovniRacun"></param>
        /// <param name="iznosTransakcije"></param>
        /// <param name="vrijemeTransakcije"></param>
        /// <param name="opisTransakcije"></param>
        /// <param name="kategorijeTransakcije"></param>
        public void DodajTransakciju(int idVrstaTransakcije, BindingSource bankovniRacun, string iznosTransakcije, DateTime vrijemeTransakcije, string opisTransakcije, List<string> kategorijeTransakcije)
        {
            using (WalletEntities db = new WalletEntities())
            {
                // Dohvati bankovne račune preko proslijeđenog binding sourcea.
                db.Bankovni_racun.Attach(bankovniRacun.Current as Bankovni_racun);

                Transakcija novaTransakcija = new Transakcija
                {
                    Bankovni_racun = bankovniRacun.Current as Bankovni_racun,
                    iznos_transakcije = decimal.Parse(iznosTransakcije),
                    vrijeme_transakcije = vrijemeTransakcije,
                    opis_transakcije = opisTransakcije
                };

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
        }
    }
}
