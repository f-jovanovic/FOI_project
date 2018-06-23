using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace PocetniZaslon.MDI_Forme
{
	public partial class FrmStatistika : Form
	{
		UpravljanjeTransakcijom radnjaNadTransakcijom = new UpravljanjeTransakcijom();
		UpravljanjeBankovnimRacunima radnjaNadBankovnimRacunima = new UpravljanjeBankovnimRacunima();

		BindingList<Vrsta_transakcije> listaVrstaTransakcija = null;
		BindingList<Transakcija> listaTransakcija = null;
		BindingList<Transakcija_investicije> listaTransakcijaInvesticija = null;
		BindingList<Bankovni_racun> listaBankovnihRacuna = null;
		Korisnik trenutniKorisnik = null;

		BindingList<PrikazTransakcije> listaPrikazaTransacija = new BindingList<PrikazTransakcije>();

		public FrmStatistika(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			InitializeComponent();
			lblStatistikaNaslov.Location = new Point(this.Width / 2 - lblStatistikaNaslov.Width / 2, lblStatistikaNaslov.Location.Y);
		}

		private void FrmStatistika_Load(object sender, EventArgs e)
		{
			DohvatiSveZapise();
		}
		/// <summary>
		/// metoda koja sluzi da se izračunaju ukupni iznosi rashoda za svaki dan
		/// </summary>
		public void DohvatiSveZapise()
		{
			//trebam:
			//vrstu transakcije, rashod
			//listu transakcija rashoda i podijelit po datumu
			

			listaBankovnihRacuna = new BindingList<Bankovni_racun>();
			listaBankovnihRacuna = radnjaNadBankovnimRacunima.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik);


			listaVrstaTransakcija = new BindingList<Vrsta_transakcije>();
			listaVrstaTransakcija = radnjaNadTransakcijom.DohvatiVrsteTransakcija();

			listaTransakcijaInvesticija = new BindingList<Transakcija_investicije>();
			listaTransakcijaInvesticija = radnjaNadTransakcijom.DohvatiSveTransakcijeInvesticija(listaBankovnihRacuna);
			listaTransakcija = new BindingList<Transakcija>();
			listaTransakcija = radnjaNadTransakcijom.DohvatiSveTransakcije(listaBankovnihRacuna);
			//dodaje sve transakcije i sve transakcije investicija u listu prikaza transakcija
			using (var db = new WalletEntities())
			{
				foreach (Transakcija transakcija in listaTransakcija)
				{
					if (transakcija != null)
					{
						db.Transakcija.Attach(transakcija);

						BindingList<Kategorije_transakcije> listaKategorijaTransakcijeListeTransakcija = new BindingList<Kategorije_transakcije>(transakcija.Kategorije_transakcije.ToList());
						Kategorije_transakcije kategorije = null;
						kategorije = listaKategorijaTransakcijeListeTransakcija[0];
						db.Kategorije_transakcije.Attach(kategorije);

						PrikazTransakcije noviPrikazTransakcije = new PrikazTransakcije(
							transakcija,
							transakcija.vrijeme_transakcije.Value,
							transakcija.Bankovni_racun,
							transakcija.iban,
							transakcija.iznos_transakcije,
							listaKategorijaTransakcijeListeTransakcija,
							transakcija.opis_transakcije,
							kategorije.id_kategorije_transakcije
							);
						db.Entry(transakcija).State = System.Data.Entity.EntityState.Detached;
						db.Entry(kategorije).State = System.Data.Entity.EntityState.Detached;
						listaPrikazaTransacija.Add(noviPrikazTransakcije);
					}
				}
				foreach (Transakcija_investicije transakcija in listaTransakcijaInvesticija)
				{
					if (transakcija != null)
					{
						db.Transakcija_investicije.Attach(transakcija);
						Investicija investicija = transakcija.Investicija;
						db.Investicija.Attach(investicija);

						PrikazTransakcije noviPrikazTransakcije = new PrikazTransakcije(
							transakcija,
							transakcija.vrijeme_transakcije_investicije.Value,
							transakcija.Bankovni_racun,
							transakcija.iban,
							transakcija.iznos_transakcije_investicije.Value,
							transakcija.kolicina_investicije,
							investicija.naziv_investicije,
							transakcija.id_vrsta_transakcije);
						db.Entry(transakcija).State = System.Data.Entity.EntityState.Detached;
						listaPrikazaTransacija.Add(noviPrikazTransakcije);
					}
				}
				//lista svih investicija
			}
			BindingList<PrikazTransakcije> listaPrihoda = new BindingList<PrikazTransakcije>();
			BindingList<PrikazTransakcije> listaRashoda = new BindingList<PrikazTransakcije>();
			//djeli listu prikaza transakcije u listu rashoda i listu prihoda
			decimal ukupniIznosRashoda = 0;
			decimal ukupniIznosPrihoda = 0;
			foreach (var item in listaPrikazaTransacija)
			{
				if (item.VrstaTransakcije == 2)
				{
					listaRashoda.Add(item);
					foreach (var i in listaRashoda)
					{
						ukupniIznosRashoda = ukupniIznosRashoda + i.Iznos;

						chartLinearRashodi.Series["LinChart"].Points.AddXY(i.Vrijeme.Date,-(i.Iznos));

					}
				}
				if(item.VrstaTransakcije == 1)
				{
					listaPrihoda.Add(item);
					foreach (var i in listaPrihoda)
					{
						ukupniIznosPrihoda = ukupniIznosPrihoda + i.Iznos;
					}
				}
			}
			decimal ukupniIznosSvihTransackija = ukupniIznosPrihoda + ukupniIznosRashoda;
			//punjenje pie charta
			chartPrihodivRashodi.Series["PChart"].Points.AddXY("Rashodi", ukupniIznosRashoda/ukupniIznosSvihTransackija);
			chartPrihodivRashodi.Series["PChart"].Points.AddXY("Prihodi", ukupniIznosPrihoda/ukupniIznosSvihTransackija);


		}

	}
}
