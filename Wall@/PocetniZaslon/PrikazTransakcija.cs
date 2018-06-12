using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocetniZaslon
{
	class PrikazTransakcije
	{
		//private BindingList<Kategorije_transakcije> listaOznacenihKategorija;
		//private DateTime? vrijemeOd;
		//private DateTime? vrijemeDo;

		public DateTime Datum { get; set; }
		public string iban { get; set; }
		public decimal Iznos { get; set; }
		public int VrstaTransakcije { get; set; }
		public string Opis { get; set; }
		public BindingList<Kategorije_transakcije> KategorijeTransakcije { get; set; }
		public Bankovni_racun BankovniRacun { get; set; }

		public PrikazTransakcije()
		{

		}

		public PrikazTransakcije(DateTime datum, Bankovni_racun bankovniRacun, string IBAN, decimal iznos, BindingList<Kategorije_transakcije> kategorijeTransakcije, string opis, int vrstaTransakcije)
		{
			Datum = datum;
			bankovniRacun = BankovniRacun;
			iban = IBAN;
			if (vrstaTransakcije == 1)
			{
				Iznos = iznos;
			}
			else
			{
				Iznos = 0 - iznos;
			}
			KategorijeTransakcije = kategorijeTransakcije;
			Opis = opis;
			VrstaTransakcije = vrstaTransakcije;
		}
		public PrikazTransakcije(DateTime datum, Bankovni_racun bankovniRacun, string IBAN, decimal iznos, decimal kolicina, string investicija, int vrstaTransakcije)
		{
			Datum = datum;
			iban = IBAN;
			bankovniRacun = BankovniRacun;
			if (vrstaTransakcije == 1)
			{
				Iznos = iznos;
			}
			else
			{
				Iznos = 0 - iznos;
			}
			VrstaTransakcije = vrstaTransakcije;
			Opis = "\nInvesticija:" + investicija + "\nKolicina :" + kolicina;
		}
	}
}
