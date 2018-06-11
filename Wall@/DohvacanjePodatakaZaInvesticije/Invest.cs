using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DohvacanjePodatakaZaInvesticije
{
	public class Invest
	{
		//dohvatit 3 vrijednosti svake investicije koju si : openvalue, symbol/ime i date

		public string Vrijednost { get; set; }
		public string Simbol { get; set; }
		public string Datum { get; set; }

		public Invest(string vrijednost, string simbol, string datum)
		{
			this.Vrijednost = vrijednost;
			this.Simbol = simbol;
			this.Datum = datum;
		}

	}
}
