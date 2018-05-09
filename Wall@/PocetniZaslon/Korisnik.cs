using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocetniZaslon
{
    class Korisnik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        private string Lozinka { get; set; }

        public Korisnik(int id, string ime, string prezime, string email, string lozinka)
        {
            this.ID = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Lozinka = lozinka;
        }
    }
}
