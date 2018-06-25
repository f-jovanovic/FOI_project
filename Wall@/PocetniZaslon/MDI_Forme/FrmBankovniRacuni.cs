using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon.MDI_Forme
{
	public partial class FrmBankovniRacuni : Form
	{
		Korisnik trenutniKorisnik = null;
		UpravljanjeBankovnimRacunima radnjaNadBankovnimRacunom = new UpravljanjeBankovnimRacunima();

		public FrmBankovniRacuni(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			InitializeComponent();
			bankovniracunBindingSource.DataSource = radnjaNadBankovnimRacunom.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik);
		}
		
		//Prilikom promjene binding sourcea trenutno selektiranog računa u combo boxu (cboRacun) dohvaćaju se informacije
		//o tom odabranom računu (na formi se prikazuju IBAN, vrsta računa i stanje računa)
		private void bankovniracunBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			Bankovni_racun odabraniBankovniRacun = bankovniracunBindingSource.Current as Bankovni_racun;
			if (odabraniBankovniRacun != null)
			{
				lblIbanOdabranogRacuna.Text = odabraniBankovniRacun.iban;
				//dohvaćamo naziv vrste računa preko vanjskog ključa
				using (var db = new WalletEntities())
				{
					Vrsta_racuna vrsta = (from t in db.Vrsta_racuna
										  where t.id_vrsta_racuna == odabraniBankovniRacun.id_vrsta_racuna
										  select t).First<Vrsta_racuna>();
					lblVrstaOdabranogRacuna.Text = vrsta.naziv_vrste_racuna;
				}
				lblStanjeOdabranogRacuna.Text = odabraniBankovniRacun.stanje_racuna.ToString();
			}
			else
			{
				lblIbanOdabranogRacuna.Text = "N/A";
				lblVrstaOdabranogRacuna.Text = "N/A";
				lblStanjeOdabranogRacuna.Text = "N/A";
			}
		}

		//Klik gumba btnDodajNoviRacun koji otvara formu FrmBankovniRacunDodaj u kojoj se može dodati novi račun.
		private void btnDodajNoviRacun_Click(object sender, EventArgs e)
		{
			MDI_Forme.FrmBankovniRacunDodaj formaDodavanjaRacuna = new FrmBankovniRacunDodaj(trenutniKorisnik);
			formaDodavanjaRacuna.ShowDialog();
			bankovniracunBindingSource.DataSource = radnjaNadBankovnimRacunom.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik);
		}

		//Klik gumba btnUredi koji otvara formu FrmBankovniRacunDodaj u kojoj se može izmjeniti odabrani račun.
		private void btnUredi_Click(object sender, EventArgs e)
		{
			Bankovni_racun odabraniRacun = bankovniracunBindingSource.Current as Bankovni_racun;
			if(odabraniRacun != null)
			{
				MDI_Forme.FrmBankovniRacunDodaj formaDodavanjaRacuna = new FrmBankovniRacunDodaj(trenutniKorisnik, odabraniRacun);
				formaDodavanjaRacuna.ShowDialog();
				bankovniracunBindingSource.DataSource = radnjaNadBankovnimRacunom.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik);
			}
		}

		//Klik gumba btnObrisi koji provodi brisanje računa, provodi se i brisanje transakcija vezane na račun, te brisanje kategorija vezane na iste transakcije.
		private void btnObrisi_Click(object sender, EventArgs e)
		{
			Bankovni_racun odabraniRacun = bankovniracunBindingSource.Current as Bankovni_racun;
			radnjaNadBankovnimRacunom.ObrisiRacun(odabraniRacun);
			bankovniracunBindingSource.DataSource = radnjaNadBankovnimRacunom.PrikaziBankovneRacunePremaKorisniku(trenutniKorisnik);
		}

		private void FrmBankovniRacuni_HelpRequested(object sender, HelpEventArgs hlpevent)
		{
			string keyword = "racun";
			Help.ShowHelp(this, @"..\\..\\Resources\\Korisnicka.chm", HelpNavigator.TopicId, keyword);
		}
	}
}
