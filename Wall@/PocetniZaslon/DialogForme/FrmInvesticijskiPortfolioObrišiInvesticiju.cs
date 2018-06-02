﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon.DialogForme
{
	public partial class FrmInvesticijskiPortfolioObrišiInvesticiju : Form
	{
		private Korisnik trenutniKorisnik = null;

		public FrmInvesticijskiPortfolioObrišiInvesticiju(Korisnik korisnik)
		{
			trenutniKorisnik = korisnik;
			InitializeComponent();
			DohvatiInvesticije();
		}
		/// <summary>
		/// dohvaća imena investicija koje se nalaze u bazi trenutnog korisnika
		/// </summary>
		private void DohvatiInvesticije()
		{
			BindingList<Investicija> listaImena = null;
			using (var db = new WalletEntities())
			{
				listaImena = new BindingList<Investicija>(db.Investicija.ToList());
			}
			investicijaBindingSource.DataSource = listaImena;
		}
		/// <summary>
		/// metoda za brisanje investicije
		/// </summary>
		private void BrisanjeInvesticije()
		{
			Investicija odabranaInvesticija = investicijaBindingSource.Current as Investicija;
			
			if (odabranaInvesticija != null)
			{
				if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					ObrišiSveVezanoNaOdabranuInvesticiju(odabranaInvesticija);
					using (var db = new WalletEntities())
					{
						db.Investicija.Attach(odabranaInvesticija);
						db.Investicija.Remove(odabranaInvesticija);
						db.SaveChanges();
					}
				}
			}
			DohvatiInvesticije();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			BrisanjeInvesticije();
		}

		private void ObrišiSveVezanoNaOdabranuInvesticiju(Investicija odabranaInvesticija)
		{
			List<Transakcija_investicije> listaTransakcijaInvesticija = new List<Transakcija_investicije>();
			using (var db = new WalletEntities())
			{
				db.Investicija.Attach(odabranaInvesticija);
				listaTransakcijaInvesticija = odabranaInvesticija.Transakcija_investicije.ToList();
			}

			foreach (var item in listaTransakcijaInvesticija)
			{
				using (var db = new WalletEntities())
				{
					if (item.id_investicije == odabranaInvesticija.id_investicije)
					{
						db.Transakcija_investicije.Attach(item);
						db.Transakcija_investicije.Remove(item);
						db.SaveChanges();
					}
				}
			}
		}

	}
}
