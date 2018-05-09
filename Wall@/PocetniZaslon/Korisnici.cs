using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocetniZaslon
{
    /// <summary>
    /// Klasa tipa singleton koja sadrži listu korisnika
    /// </summary>
    class Korisnici
    {
        private static Korisnici instance;
        List<Korisnik> listKorisnici = new List<Korisnik>(); //lista u koju se spremaju korisnici kod povlačenja iz baze

        public static Korisnici Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new Korisnici();
                }
                return instance;
            }
        }
    }
}
