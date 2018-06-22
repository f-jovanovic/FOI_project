using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace PocetniZaslon.MDI_Forme
{
	public partial class FrmInvesticijskiPortfolio : Form
	{
		Korisnik trenutniKorisnik = null;


		public FrmInvesticijskiPortfolio(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			bool portfolioPostoji = true;
			using (var db = new WalletEntities())
			{
				foreach (var portfolio in db.Investicijski_portfolio)
				{
					if (portfolio.id_korisnik != korisnik.id_korisnik)
					{
						portfolioPostoji = false;
					}
					else
					{
						portfolioPostoji = true;
						break;
					}
				}

				if (!portfolioPostoji)
				{
					Investicijski_portfolio noviPortfolio = new Investicijski_portfolio
					{
						id_korisnik = trenutniKorisnik.id_korisnik
					};
					db.Investicijski_portfolio.Add(noviPortfolio);
					db.SaveChanges();
				}
			}

			InitializeComponent();
			lblInvesticijskiPortfolio.Location = new Point(this.Width / 2 - lblInvesticijskiPortfolio.Width / 2, lblInvesticijskiPortfolio.Location.Y);
			PrikaziBankovneRacunePremaKorisniku();

			PrikaziImenaInvesticija();
		}
		/// <summary>
		/// Prikazuje postojece investicije za comboBox u transakcijama investicija
		/// </summary>
		private void PrikaziImenaInvesticija()
		{
			BindingList<Investicija> listaImena = null;

			using (var db = new WalletEntities())
			{
				listaImena = new BindingList<Investicija>(db.Investicija.ToList());
			}
			investicijaBindingSource.DataSource = listaImena;
		}

		/// <summary>
		/// Prikazuje postojece bankovne racune korisnika
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

		/// <summary>
		/// Ova metoda služi kako bi korisnik mogao kupiti investiciju
		/// </summary>
		private void KupiInvesticiju()
		{
			Bankovni_racun bankovni_Racun = null;
			bankovni_Racun = bankovniracunBindingSource.Current as Bankovni_racun;
			Investicija investicija = null;
			investicija = investicijaBindingSource.Current as Investicija;

			using (var db = new WalletEntities())
			{
				db.Korisnik.Attach(trenutniKorisnik);
				db.Investicija.Attach(investicija);
				db.Bankovni_racun.Attach(bankovni_Racun);
				int idPort = 0;
				int idVrsteTrans = 0;
				//dobavlja vanjski kljuc id_portfolia
				foreach (var item in db.Investicijski_portfolio)
				{
					Investicijski_portfolio investicijski = (from t in db.Investicijski_portfolio
															 where t.id_korisnik == trenutniKorisnik.id_korisnik
															 select t).First();
					idPort = investicijski.id_portfolia;
				}
				//dobavlja vanjski kljuc  za kupi transakciju, vrstu transakcije
				if (rBtnKupi.Checked == true)
				{
					foreach (var item in db.Vrsta_transakcije)
					{
						Vrsta_transakcije vrsta = (from t in db.Vrsta_transakcije
												   where t.id_vrsta_transakcije == 2
												   select t).First();
						idVrsteTrans = 2;
					}
				}
				lblKriviTipPodatakaIznos.Hide();
				lblKriviTipPodatakaKolicina.Hide();

				Transakcija_investicije transakcija_Investicije = new Transakcija_investicije
				{
					Investicija = investicija,
					vrijeme_transakcije_investicije = dtpDatum.Value,
					kolicina_investicije = decimal.Parse(txtKolicina.Text),
					iznos_transakcije_investicije = decimal.Parse(txtIznosTransInv.Text),
					Bankovni_racun = bankovni_Racun,
					id_portfolia = idPort,
					id_vrsta_transakcije = idVrsteTrans,
				};

				//lblKriviTipPodatakaKolicina.Visible = false;
				decimal ukupniIznos = decimal.Parse(txtKolicina.Text) * decimal.Parse(txtIznosTransInv.Text);
				bankovni_Racun.stanje_racuna = bankovni_Racun.stanje_racuna - ukupniIznos;
				db.Transakcija_investicije.Add(transakcija_Investicije);
				db.SaveChanges();
				txtKolicina.Clear();
				txtIznosTransInv.Clear();
			}
		}
		/// <summary>
		/// ova metoda sluzi kako bi korisnik mogao prodati investicije, čime se povecava iznos na odabranom bankovnom racunu
		/// </summary>
		private void ProdajInvesticiju()
		{
			Bankovni_racun bankovni_Racun = null;
			bankovni_Racun = bankovniracunBindingSource.Current as Bankovni_racun;
			Investicija investicija = null;
			investicija = investicijaBindingSource.Current as Investicija;

			using (var db = new WalletEntities())
			{
				db.Korisnik.Attach(trenutniKorisnik);
				db.Investicija.Attach(investicija);
				db.Bankovni_racun.Attach(bankovni_Racun);
				int idPort = 0;
				int idVrsteTrans = 0;
				//dobavlja vanjski kljuc id_portfolia
				foreach (var item in db.Investicijski_portfolio)
				{
					Investicijski_portfolio investicijski = (from t in db.Investicijski_portfolio
															 where t.id_korisnik == trenutniKorisnik.id_korisnik
															 select t).First();
					idPort = investicijski.id_portfolia;
				}
				//dobavlja vanjski kljuc  za kupi transakciju, vrstu transakcije
				if (rBtnProdaj.Checked == true)
				{
					foreach (var item in db.Vrsta_transakcije)
					{
						Vrsta_transakcije vrsta = (from t in db.Vrsta_transakcije
												   where t.id_vrsta_transakcije == 1
												   select t).First();
						idVrsteTrans = 1;
					}
				}
				Transakcija_investicije transakcija_Investicije = new Transakcija_investicije
				{
					vrijeme_transakcije_investicije = dtpDatum.Value,
					kolicina_investicije = decimal.Parse(txtKolicina.Text),
					iznos_transakcije_investicije = decimal.Parse(txtIznosTransInv.Text),
					Bankovni_racun = bankovni_Racun,
					Investicija = investicija,
					id_portfolia = idPort,
					id_vrsta_transakcije = idVrsteTrans,
				};
				decimal ukupniIznos = decimal.Parse(txtKolicina.Text) * decimal.Parse(txtIznosTransInv.Text);
				bankovni_Racun.stanje_racuna = bankovni_Racun.stanje_racuna + ukupniIznos;
				db.Transakcija_investicije.Add(transakcija_Investicije);
				db.SaveChanges();
				txtKolicina.Clear();
				txtIznosTransInv.Clear();
			}
		}
		private void btnDodajInvesticiju_Click(object sender, EventArgs e)
		{
			PrikaziImenaInvesticija();
		}

		private void btnIzvrsiTransakciju_Click(object sender, EventArgs e)
		{
			if (rBtnKupi.Checked == true)
			{
				KupiInvesticiju();
			}
			else
			{
				ProdajInvesticiju();
			}
			DohvacanjePodatakaZaDGW();
		}

		/// <summary>
		/// metoda koja sluzi da se dohvate svi podaci potrebni za prikaz investicije (stanje naziv itd)
		/// </summary>
		private void DohvacanjePodatakaZaDGW()
		{
			UpravljanjeTransakcijom upravljanjeTransakcijom = new UpravljanjeTransakcijom();
			UpravljanjeBankovnimRacunima upravljanjeBankovnimRacunima = new UpravljanjeBankovnimRacunima();
			BindingList<Bankovni_racun> listaBankovnikRacuna = upravljanjeBankovnimRacunima.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik);

			BindingList<Transakcija_investicije> listaSvihTransakcijaInvesticija = upravljanjeTransakcijom.DohvatiSveTransakcijeInvesticija(listaBankovnikRacuna);

			dgwVlastiteInvesticije.Rows.Clear();

			dgwVlastiteInvesticije.ColumnCount = 6;

			dgwVlastiteInvesticije.Columns[0].Name = "Naziv investicije";
			dgwVlastiteInvesticije.Columns[1].Name = "Vrijeme transakcije investicije";
			dgwVlastiteInvesticije.Columns[2].Name = "Naziv vrste investicije";
			dgwVlastiteInvesticije.Columns[3].Name = "Vrijednost investicije";
			dgwVlastiteInvesticije.Columns[4].Name = "Kolicina investicije";
			dgwVlastiteInvesticije.Columns[5].Name = "Ukupni iznos";

			string naziv = "";
			DateTime? vrijeme;
			string nazivVrsteInvesticije = "";
			decimal? vrijednost = 0;
			decimal? kolicina = 0;
			Investicija investicija = null;

			using (var db = new WalletEntities())
			{
				foreach (Transakcija_investicije transakcijaInvesticije in listaSvihTransakcijaInvesticija)
				{
					if (transakcijaInvesticije == null) continue;
					db.Transakcija_investicije.Attach(transakcijaInvesticije);

					vrijednost = transakcijaInvesticije.iznos_transakcije_investicije;
					kolicina = transakcijaInvesticije.kolicina_investicije;
					vrijeme = transakcijaInvesticije.vrijeme_transakcije_investicije;

					if (transakcijaInvesticije.id_vrsta_transakcije == 2)
					{
						vrijednost = 0 - vrijednost;
					}

					investicija = transakcijaInvesticije.Investicija;
					db.Investicija.Attach(investicija);
					naziv = investicija.naziv_investicije;

					if (investicija.id_vrsta_investicije == 1) nazivVrsteInvesticije = "Dionica";
					if (investicija.id_vrsta_investicije == 2) nazivVrsteInvesticije = "Kriptovaluta";

					db.Entry(investicija).State = System.Data.Entity.EntityState.Detached;
					db.Entry(transakcijaInvesticije).State = System.Data.Entity.EntityState.Detached;

					string[] row = new string[] { naziv, vrijeme.ToString(), nazivVrsteInvesticije, vrijednost.ToString(), kolicina.ToString(), (vrijednost * kolicina).ToString() };
					dgwVlastiteInvesticije.Rows.Add(row);
				}
			}

			dgwVlastiteInvesticije.Columns[2].ValueType = typeof(DateTime);
			dgwVlastiteInvesticije.Sort(dgwVlastiteInvesticije.Columns["Vrijeme transakcije investicije"], ListSortDirection.Descending);
			
		}

		private void FrmInvesticijskiPortfolio_Load(object sender, EventArgs e)
		{
			lblTekst.Visible = false;
			DohvacanjePodatakaZaDGW();
			btnIzvrsiTransakciju.Enabled = false;
			//provjerava ako je stanje već uzeto da korisnik na taj dan ne moze uzimati ponovno stanje
			using (var db = new WalletEntities())
			{
				foreach (var item in db.Stanje_investicije)
				{
					if (item.vrijeme_stanja == DateTime.Today)
					{
						btnDohvati.Enabled = false;
					}
				}
			}
			if (btnDohvati.Enabled == false)
			{
				lblTekst.Visible = true;
			}
			else
			{
				lblTekst.Visible = false;
			}
		}
		/// <summary>
		/// provjera tipa unosa kolicine prilikom transakcije investicije
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtBoxKolicina_TextChanged(object sender, EventArgs e)
		{
			decimal kolicina_investicije = 0;
			if (decimal.TryParse(txtKolicina.Text, out kolicina_investicije) && kolicina_investicije != 0)
			{
				lblKriviTipPodatakaKolicina.Hide();
				btnIzvrsiTransakciju.Enabled = true;

			}
			else
			{
				lblKriviTipPodatakaKolicina.Show();
				btnIzvrsiTransakciju.Enabled = false;
			}

		}
		/// <summary>
		/// provjera unosa iznosa investicije prilikom transakcije 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtBoxIznosTransInv_TextChanged(object sender, EventArgs e)
		{
			decimal iznos_transakcije = 0;
			if (decimal.TryParse(txtIznosTransInv.Text, out iznos_transakcije))
			{
				lblKriviTipPodatakaKolicina.Hide();
				btnIzvrsiTransakciju.Enabled = true;
			}
			else
			{
				lblKriviTipPodatakaKolicina.Show();
				btnIzvrsiTransakciju.Enabled = false;
			}
		}
		/// <summary>
		/// dohvaćanje stanja s drugog projekta
		/// </summary>
		public void DohvacanjeStanjaInvesticija()
		{
			DohvacanjeAPI.GetData getData = new DohvacanjeAPI.GetData();
			getData.Dohvacanje();
			int idInv = 0;
			using (var db = new WalletEntities())
			{
				foreach (var item in getData.lista())
				{
						foreach (var it in db.Investicija)
						{
							if (item.Simbol == it.naziv_investicije)
							{
									decimal USD = 6.3m;
									decimal vrijednostUKunama = decimal.Multiply(decimal.Parse(item.Vrijednost), USD);
									Investicija investicija = it;
									db.Investicija.Attach(investicija);
									idInv = investicija.id_investicije;
									db.Entry(investicija).State = System.Data.Entity.EntityState.Detached;
									Stanje_investicije stanje_Investicije = new Stanje_investicije
									{
										id_investicije = idInv,
										vrijednost_investicije = vrijednostUKunama,
										vrijeme_stanja = DateTime.Parse(item.Datum)
									};
									db.Stanje_investicije.Add(stanje_Investicije);
							}
						}
					
				}
			db.SaveChanges();
			}
		}

		private void cBoxNazivInvesticije_SelectedIndexChanged(object sender, EventArgs e)
		{
			using (var db = new WalletEntities())
			{
				foreach (var item in db.Stanje_investicije)
				{
					if (item.id_investicije == (cBoxNazivInvesticije.SelectedItem as Investicija).id_investicije)
					{
						txtIznosTransInv.Text = item.vrijednost_investicije.ToString();
					}
				}
			}

		}

		private void FrmInvesticijskiPortfolio_FormClosing(object sender, FormClosingEventArgs e)
		{
			cBoxNazivInvesticije.Dispose();
		}

		private void btnDohvati_Click(object sender, EventArgs e)
		{
			DohvacanjeStanjaInvesticija();

			btnDohvati.Enabled = false;

		}
	}
}
