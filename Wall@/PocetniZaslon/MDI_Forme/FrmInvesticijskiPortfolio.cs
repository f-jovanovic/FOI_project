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
			PrikaziVrsteInvesticije();
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
		/// metoda koja popunjava combo box s vrstama investicije
		/// </summary>
		private void PrikaziVrsteInvesticije()
		{
			BindingList<Vrsta_investicije> listaVrstaInvesticija = null;

			using (var db = new WalletEntities())
			{
				listaVrstaInvesticija = new BindingList<Vrsta_investicije>(db.Vrsta_investicije.ToList());
			}
			vrstainvesticijeBindingSource.DataSource = listaVrstaInvesticija;
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
					vrijeme_transakcije_investicije = dateDatum.Value,
					kolicina_investicije = decimal.Parse(txtBoxKolicina.Text),
					iznos_transakcije_investicije = decimal.Parse(txtBoxIznosTransInv.Text),
					Bankovni_racun = bankovni_Racun,
					id_portfolia = idPort,
					id_vrsta_transakcije = idVrsteTrans,
				};

				lblKriviTipPodatakaKolicina.Visible = false;
				decimal ukupniIznos = decimal.Parse(txtBoxKolicina.Text) * decimal.Parse(txtBoxIznosTransInv.Text);
				bankovni_Racun.stanje_racuna = bankovni_Racun.stanje_racuna - ukupniIznos;
				db.Transakcija_investicije.Add(transakcija_Investicije);
				db.SaveChanges();

				txtBoxKolicina.Clear();
				txtBoxIznosTransInv.Clear();
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
					vrijeme_transakcije_investicije = dateDatum.Value,
					kolicina_investicije = decimal.Parse(txtBoxKolicina.Text),
					iznos_transakcije_investicije = decimal.Parse(txtBoxIznosTransInv.Text),
					Bankovni_racun = bankovni_Racun,
					Investicija = investicija,
					id_portfolia = idPort,
					id_vrsta_transakcije = idVrsteTrans,
				};
				decimal ukupniIznos = decimal.Parse(txtBoxKolicina.Text) * decimal.Parse(txtBoxIznosTransInv.Text);
				bankovni_Racun.stanje_racuna = bankovni_Racun.stanje_racuna + ukupniIznos;
				db.Transakcija_investicije.Add(transakcija_Investicije);
				db.SaveChanges();
				db.Entry(investicija).State = System.Data.Entity.EntityState.Deleted;
				txtBoxKolicina.Clear();
				txtBoxIznosTransInv.Clear();
			}
		}
		private void btnDodajInvesticiju_Click(object sender, EventArgs e)
		{
			DodajInvesticiju();
			PrikaziImenaInvesticija();
		}

		/// <summary>
		/// metoda za dodavanje investicije koju korisnik zeli kupiti
		/// </summary>
		private void DodajInvesticiju()
		{
			Vrsta_investicije vrsta = null;
			vrsta = vrstainvesticijeBindingSource.Current as Vrsta_investicije;
			bool postojiNaziv = false;
			postojiNaziv = ProvjeraNazivaInvesticije(postojiNaziv);

			if (postojiNaziv == true)
			{
				MessageBox.Show("Investicija s unešenim nazivom već postoji");
			}
			else
			{
				using (var db = new WalletEntities())
				{
					db.Vrsta_investicije.Attach(vrsta);
					Investicija novaInvesticija = new Investicija
					{
						naziv_investicije = txtBoxNazivInvesticije.Text,
						Vrsta_investicije = vrsta

					};
					db.Investicija.Add(novaInvesticija);
					db.SaveChanges();
					db.Entry(vrsta).State = System.Data.Entity.EntityState.Deleted;
					//gBoxInvesticije.Text = txtBoxNazivInvesticije.Text.ToString();
					//gBoxInvesticije.Refresh();
				}
			}
			txtBoxNazivInvesticije.Clear();
		}
		/// <summary>
		/// provjerava postoji li uneseni naziv investicije u bazi
		/// </summary>
		/// <param name="postojiNaziv"></param>
		/// <returns></returns>
		private bool ProvjeraNazivaInvesticije(bool postojiNaziv)
		{
			using (var db = new WalletEntities())
			{
				postojiNaziv = false;
				List<Investicija> listaInvesticija = new List<Investicija>(db.Investicija.ToList());

				foreach (var investicija in listaInvesticija) if (investicija.naziv_investicije.ToLower() == txtBoxNazivInvesticije.Text.ToLower()) postojiNaziv = true;
			}
			return postojiNaziv;
		}
		/// <summary>
		/// ovisno o tome koji je radio btn oznacen izvršava se kupi ili prodaj
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		private void btnObrisiInvesticiju_Click(object sender, EventArgs e)
		{
			Dialog_forme.FrmInvesticijskiPortfolioObrisiInvesticiju frmInvesticijskiPortfolioObrišiInvesticiju = new Dialog_forme.FrmInvesticijskiPortfolioObrisiInvesticiju(trenutniKorisnik);
			frmInvesticijskiPortfolioObrišiInvesticiju.ShowDialog();
			PrikaziImenaInvesticija();
			DohvacanjePodatakaZaDGW();
		}

		/// <summary>
		/// metoda koja sluzi da se dohvate svi podaci potrebni za prikaz investicije (stanje naziv itd)
		/// </summary>
		private void DohvacanjePodatakaZaDGW()
		{
			using (var db = new WalletEntities())
			{
				
				var listaInvesticija = (from i in db.Investicija
										join s in db.Stanje_investicije on i.id_investicije equals s.id_investicije
										join v in db.Vrsta_investicije on i.id_vrsta_investicije equals v.id_vrsta_investicije
										join t in db.Transakcija_investicije on i.id_investicije equals t.id_investicije
										join p in db.Investicijski_portfolio on t.id_portfolia equals p.id_portfolia
										where t.id_investicije == t.id_investicije && p.id_korisnik == trenutniKorisnik.id_korisnik
										orderby t.vrijeme_transakcije_investicije descending
										select new
										{
											i.naziv_investicije,
											t.vrijeme_transakcije_investicije,
											s.vrijednost_investicije,
											v.naziv_vrste_investicije,
											t.kolicina_investicije
										}).ToList();
				dgwVlastiteInvesticije.DataSource = listaInvesticija;
			}
		}

		private void FrmInvesticijskiPortfolio_Load(object sender, EventArgs e)
		{
			DohvacanjePodatakaZaDGW();
			DohvacanjeStanjaInvesticija();
			btnIzvrsiTransakciju.Enabled = false;
		}
		/// <summary>
		/// provjera tipa unosa kolicine prilikom transakcije investicije
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtBoxKolicina_TextChanged(object sender, EventArgs e)
		{
			decimal kolicina_investicije = 0;
			if (decimal.TryParse(txtBoxKolicina.Text, out kolicina_investicije) && kolicina_investicije != 0)
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
			if (decimal.TryParse(txtBoxIznosTransInv.Text, out iznos_transakcije) && iznos_transakcije != 0)
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
			int idInv = 0;
			//doovdi
			using (var db = new WalletEntities())
			{
				foreach (var item in getData.lista())
				{
					//if (item.Datum != DateTime.Today.ToLongDateString())
					//{
					foreach (var it in db.Investicija)
					{
						if (item.Simbol == it.naziv_investicije)
						{
							Investicija investicija = it;
							db.Investicija.Attach(investicija);
							idInv = investicija.id_investicije;
							db.Entry(investicija).State = System.Data.Entity.EntityState.Detached;
							Stanje_investicije stanje_Investicije = new Stanje_investicije
							{
								id_investicije = idInv,
								vrijednost_investicije = decimal.Parse(item.Vrijednost),
								vrijeme_stanja = DateTime.Parse(item.Datum)
							};
							db.Stanje_investicije.Add(stanje_Investicije);
						}
					}
					//}
				}
				db.SaveChanges();
			}
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			DohvacanjeAPI.GetData data = new DohvacanjeAPI.GetData();

			dgwTest.DataSource = data.lista();
			MessageBox.Show(data.lista().Count.ToString());

		}

		/*private void cBoxNazivInvesticije_SelectedIndexChanged(object sender, EventArgs e)
		{
			using (var db = new WalletEntities())
			{
				foreach (var item in db.Stanje_investicije)
				{
					if (item.id_investicije == (cBoxNazivInvesticije.SelectedItem as Investicija).id_investicije && item.vrijeme_stanja.Date == DateTime.Now.Date)
					{
						txtBoxIznosTransInv.Text = item.vrijednost_investicije.ToString();
						break;
					}

				}
			}
		}*/
	}
}
