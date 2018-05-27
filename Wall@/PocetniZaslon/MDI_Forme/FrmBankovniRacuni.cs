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

		public FrmBankovniRacuni(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			InitializeComponent();
			PrikaziBankovneRacunePremaKorisniku();
		}

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

		private void PrikaziPodatkeOdabranogRacuna()
		{
			Bankovni_racun odabraniBankovniRacun = bankovniracunBindingSource.Current as Bankovni_racun;
			if (odabraniBankovniRacun != null)
			{
				lblIbanOdabranogRacuna.Text = odabraniBankovniRacun.iban;
				using (var db = new WalletEntities())
				{
					Vrsta_racuna vrsta = (from t in db.Vrsta_racuna
										  where t.id_vrsta_racuna == odabraniBankovniRacun.id_vrsta_racuna
										  select t).First<Vrsta_racuna>();
					lblVrstaOdabranogRacuna.Text = vrsta.naziv_vrste_racuna;
				}
				lblStanjeOdabranogRacuna.Text = odabraniBankovniRacun.stanje_racuna.ToString();
			}
			
		}

		//pri promjeni binding sourcea trenutno selektiranog računa u combo boxu odaberite račun poziva se metoda koja mjenja informacije
		//o tom odabranom računu (ispod piše IBAN, vrsta računa i stanje računa)
		private void bankovniracunBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			PrikaziPodatkeOdabranogRacuna();
		}

		private void btnDodajNoviRacun_Click(object sender, EventArgs e)
		{
			MDI_Forme.FrmBankovniRacunDodaj formaDodavanjaRacuna = new FrmBankovniRacunDodaj();
			formaDodavanjaRacuna.ShowDialog();
		}
	}
}
