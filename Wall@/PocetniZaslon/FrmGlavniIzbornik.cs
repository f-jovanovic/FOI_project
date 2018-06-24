using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon
{
	public partial class FrmGlavniIzbornik : Form
	{
		Korisnik trenutniKorisnik = null;
		public FrmGlavniIzbornik(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;

			InitializeComponent();

			lblTrenutniKorisnikImePrezime.Text = trenutniKorisnik.ime_korisnika + " " + trenutniKorisnik.prezime_korisnika;
		}

		#region Upravljanje Gumbima Glavnog Izbornika

		/// <summary>
		/// Metoda koja zatvara sve otvorene forme koje su otvorene unutar MDI containera forme "FrmGlavniIzbornik"
		/// </summary>

		private void UgasiSveOtvoreneProzore()
		{
			if (this.MdiChildren.Count<Form>() > 0) this.ActiveMdiChild.Close();
		}

		private void btnBankovniRacun_Click(object sender, EventArgs e) // Klikom na Bankovni racuni otvara se forma FrmBankovniRacuni unutar MDI containera
		{
			UgasiSveOtvoreneProzore();
			MDI_Forme.FrmBankovniRacuni formaBankovniRacun = new MDI_Forme.FrmBankovniRacuni(trenutniKorisnik);
			formaBankovniRacun.MdiParent = this;
			formaBankovniRacun.Dock = DockStyle.Fill;
			formaBankovniRacun.Show();
			PrilagodiElementeChild(formaBankovniRacun);
		}

		private void btnZaslon_Click(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
			MDI_Forme.FrmPocetniZaslon frmPocetniZaslon = new MDI_Forme.FrmPocetniZaslon(trenutniKorisnik);
			frmPocetniZaslon.MdiParent = this;
			frmPocetniZaslon.Dock = DockStyle.Fill;
			frmPocetniZaslon.Show();
			PrilagodiElementeChild(frmPocetniZaslon);
		}

		private void btnUnosTransakcije_Click(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
            MDI_Forme.FrmUnosTransakcija frmUnosTransakcija = new MDI_Forme.FrmUnosTransakcija(trenutniKorisnik);
            frmUnosTransakcija.MdiParent = this;
            frmUnosTransakcija.Dock = DockStyle.Fill;
            frmUnosTransakcija.Show();
            PrilagodiElementeChild(frmUnosTransakcija);
		}

		private void btnPregled_Click(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
			MDI_Forme.FrmPregledTransakcija frmPregledTransakcija = new MDI_Forme.FrmPregledTransakcija(trenutniKorisnik);
			frmPregledTransakcija.MdiParent = this;
			frmPregledTransakcija.Dock = DockStyle.Fill;
			frmPregledTransakcija.Show();
			PrilagodiElementeChild(frmPregledTransakcija);
		}

		private void btnInvesticijskiPortfolio_Click(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
			MDI_Forme.FrmInvesticijskiPortfolio formaInvesticijskiPortfolio = new MDI_Forme.FrmInvesticijskiPortfolio(trenutniKorisnik);
			formaInvesticijskiPortfolio.MdiParent = this;
			formaInvesticijskiPortfolio.Dock = DockStyle.Fill;
			formaInvesticijskiPortfolio.Show();
			PrilagodiElementeChild(formaInvesticijskiPortfolio);

		}

		private void btnStatistika_Click(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
			MDI_Forme.FrmStatistika formaStatistika = new MDI_Forme.FrmStatistika(trenutniKorisnik);
			formaStatistika.MdiParent = this;
			formaStatistika.Dock = DockStyle.Fill;
			formaStatistika.Show();
			PrilagodiElementeChild(formaStatistika);
		}

		private void btnPostavke_Click(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
            MDI_Forme.FrmPostavke frmPostavke = new MDI_Forme.FrmPostavke(trenutniKorisnik);
            frmPostavke.MdiParent = this;
            frmPostavke.Dock = DockStyle.Fill;
            frmPostavke.Show();
            PrilagodiElementeChild(frmPostavke);
		}

		private void btnOdjava_Click(object sender, EventArgs e)
		{
			Application.Restart(); // Klikom na odjava aplikacija se resetira.
		}

		private void FrmGlavniIzbornik_SizeChanged(object sender, EventArgs e)
		{
			if (this.MdiChildren.Count<Form>() > 0) PrilagodiElementeChild(this.ActiveMdiChild);
		}

		/// <summary>
		/// Metoda raspoređuje sve elemente forme u njenu sredinu."
		/// </summary>

		public void PrilagodiElementeChild(Form forma)
		{
			if (forma != null)
			{
				int krajnjiLijeviRub = forma.Width;
				int krajnjiGornjiRub = forma.Height;
				int krajnjiDesniRub = 0;
				int krajnjiDonjiRub = 0;

				int locationX, locationY, widthElementa, heightElementa;

				foreach (Control elementForme in forma.Controls)
				{
					locationX = elementForme.Location.X;
					locationY = elementForme.Location.Y;
					widthElementa = elementForme.Width;
					heightElementa = elementForme.Height;

					if (locationX < krajnjiLijeviRub) krajnjiLijeviRub = locationX;
					if (locationY < krajnjiGornjiRub) krajnjiGornjiRub = locationY;

					if (locationX + widthElementa > krajnjiDesniRub) krajnjiDesniRub = locationX + widthElementa;
					if (locationY + heightElementa > krajnjiDonjiRub) krajnjiDonjiRub = locationY + heightElementa;
				}

				foreach (Control elementForme in forma.Controls)
				{
					elementForme.Location = new Point(
						elementForme.Location.X - krajnjiLijeviRub, //stavlja lokaciju u sredinu po x osi
						elementForme.Location.Y - krajnjiGornjiRub // stavlja lokaciju u sredinu po y osi
						);
					elementForme.Location = new Point(
						elementForme.Location.X + (forma.Width / 2 - (krajnjiDesniRub - krajnjiLijeviRub) / 2), //stavlja lokaciju u sredinu po x osi
						elementForme.Location.Y + (forma.Height / 2 - (krajnjiDonjiRub - krajnjiGornjiRub) / 2) // stavlja lokaciju u sredinu po y osi
						);
				}
			}
		}
		#endregion

		private void FrmGlavniIzbornik_Load(object sender, EventArgs e)
		{
			UgasiSveOtvoreneProzore();
			MDI_Forme.FrmPocetniZaslon frmPocetniZaslon = new MDI_Forme.FrmPocetniZaslon(trenutniKorisnik);
			frmPocetniZaslon.MdiParent = this;
			frmPocetniZaslon.Dock = DockStyle.Fill;
			frmPocetniZaslon.Show();
			PrilagodiElementeChild(frmPocetniZaslon);
		}
	}
}

