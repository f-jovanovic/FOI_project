using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon
{
	public class PrikazTransakcije
	{
		public string DatumTransakcije { get; set; }
		public DateTime Vrijeme { get; set; }
		public string iban { get; set; }
		public decimal Iznos { get; set; }
		public int VrstaTransakcije { get; set; }
		public string Opis { get; set; }
		public BindingList<Kategorije_transakcije> KategorijeTransakcije { get; set; }
		public Bankovni_racun BankovniRacun { get; set; }
		public Transakcija ObicnaTransakcija { get; set; }
		public Transakcija_investicije TransakcijaInvesticije { get; set; }
		public string LokacijaSlike { get; set; }

		/// <summary>
		/// Konstruktor za spremanje obične transakcije.
		/// </summary>
		public PrikazTransakcije(Transakcija obicnaTransakcija, DateTime datum, Bankovni_racun bankovniRacun, string IBAN, decimal iznos, BindingList<Kategorije_transakcije> kategorijeTransakcije, string opis, int vrstaTransakcije, string lokacijaSlike)
		{
			ObicnaTransakcija = obicnaTransakcija;
			Vrijeme = datum;
			bankovniRacun = BankovniRacun;
			iban = IBAN;
			if (vrstaTransakcije == 1) Iznos = iznos;
			else Iznos = 0 - iznos;
			KategorijeTransakcije = kategorijeTransakcije;
			Opis = opis;
			VrstaTransakcije = vrstaTransakcije;
			DatumTransakcije = Vrijeme.ToString("dd/MM/yyyy");
			if (lokacijaSlike != null) LokacijaSlike = lokacijaSlike;
		}
		
		/// <summary>
		/// Konstruktor za spremanje transakcije investicija.
		/// </summary>
		public PrikazTransakcije(Transakcija_investicije transakcijaInvesticije,DateTime datum, Bankovni_racun bankovniRacun, string IBAN, decimal iznos, decimal kolicina, string investicija, int vrstaTransakcije)
		{
			TransakcijaInvesticije = transakcijaInvesticije;
			Vrijeme = datum;
			iban = IBAN;
			bankovniRacun = BankovniRacun;
			if (vrstaTransakcije == 1) Iznos = iznos;
			else Iznos = 0 - iznos;
			VrstaTransakcije = vrstaTransakcije;
			Opis = "\nInvesticija:" + investicija + "\nKolicina :" + kolicina;
			KategorijeTransakcije = null;
			DatumTransakcije = Vrijeme.ToString("dd/MM/yyyy");
		}
	}
}
