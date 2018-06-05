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
    public partial class FrmUnosTransakcijaInterni : Form
    {
        UpravljanjeTransakcijom dodavanjeTransakcije = new UpravljanjeTransakcijom();
        Korisnik trenutniKorisnik;

        public FrmUnosTransakcijaInterni(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

        private void FrmUnosTransakcijaInterni_Load(object sender, EventArgs e)
        {
            btnSpremiTransakcijuInterni.Enabled = false;
            DohvatiPodatke();
        }

        /// <summary>
        /// Dohvaćaju se bankovni računi korisnika i stavlja ih se u zasebne combobox-ove.
        /// </summary>
        private void DohvatiPodatke()
        {
            BindingList<Bankovni_racun> listBankovniRacuni = null;

            using (WalletEntities db = new WalletEntities())
            {
                db.Korisnik.Attach(trenutniKorisnik);
                listBankovniRacuni = new BindingList<Bankovni_racun>(trenutniKorisnik.Bankovni_racun.ToList());
            }

            bankovniracunBindingSource.DataSource = listBankovniRacuni;
            bankovniracunBindingSource1.DataSource = listBankovniRacuni;
        }

        /// <summary>
        /// Dodaje se rashod u transakcije i postavlja mu se default kategorija.
        /// </summary>
        /// <returns></returns>
        private Transakcija IzvrsiRashod()
        {
            List<string> kategorijeRashod = new List<string>();
            kategorijeRashod.Add("Ostali rashodi");

            return dodavanjeTransakcije.DodajTransakciju(2, bankovniracunBindingSource, txtIznosInterni.Text, dtpDatumTransakcijeInterni.Value.Date + dtpVrijemeTransakcijeInterni.Value.TimeOfDay, txtOpisInterni.Text, kategorijeRashod);
        }

        /// <summary>
        /// Dodaje se prihod u transakcije, i postavlja mu se default kategorija.
        /// </summary>
        /// <returns></returns>
        private Transakcija IzvrsiPrihod()
        {
            List<string> kategorijePrihod = new List<string>();
            kategorijePrihod.Add("Ostali prihodi");

            return dodavanjeTransakcije.DodajTransakciju(1, bankovniracunBindingSource1, txtIznosInterni.Text, dtpDatumTransakcijeInterni.Value.Date + dtpVrijemeTransakcijeInterni.Value.TimeOfDay, txtOpisInterni.Text, kategorijePrihod);
        }

        /// <summary>
        /// Metoda koja u odabranu transakciju zapisuje ID druge transakcije, za potebe internog prijenosa. (veza 1-1)
        /// Prima 2 transakcije, prva je transakcija u koju se zapisuje, druga je ona koju zapisujemo.
        /// </summary>
        /// <param name="idTransakcija1"></param>
        /// <param name="idTransakcija2"></param>
        private void SpojiTransakcije(Transakcija transakcijaPrima, Transakcija transakcijaDaje)
        {
            using (WalletEntities db = new WalletEntities())
            {
                db.Transakcija.Attach(transakcijaPrima);
                transakcijaPrima.id_vlastite_transakcije = transakcijaDaje.id_transakcije;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Klikom na spremi vrše se i prihod i rashod, te ih se povezuje naknadno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremiTransakcijuInterni_Click(object sender, EventArgs e)
        {
            Transakcija noviRashod = IzvrsiRashod();
            Transakcija noviPrihod = IzvrsiPrihod();

            SpojiTransakcije(noviRashod, noviPrihod);
            SpojiTransakcije(noviPrihod, noviRashod);
            
            MessageBox.Show("Transakcija uspješno unesena!");

            // Prolazi se kroz sve kontrole glavne forme, i izvršava se click na gumb UnosTransakcije.
            foreach (Control kontrole in this.MdiParent.Controls)
            {
                if (kontrole.GetType() == typeof(Button) && kontrole.Name == "btnUnosTransakcije") (kontrole as Button).PerformClick();
            }
        }

        #region Provjera unesenih podataka
        private void cboBankovniRacunPosiljateljInterni_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProvjeriBankovneRacune();
        }

        private void cboBankovniRacunPrimateljInterni_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProvjeriBankovneRacune();
        }

        private void ProvjeriBankovneRacune()
        {
            if (cboBankovniRacunPosiljateljInterni.SelectedItem == cboBankovniRacunPrimateljInterni.SelectedItem)
            {
                btnSpremiTransakcijuInterni.Enabled = false;
                lblBankovniError.Show();
            }
            else
            {
                btnSpremiTransakcijuInterni.Enabled = true;
                lblBankovniError.Hide();
            }
        }

        private void txtIznosInterni_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIznosInterni.ToString()))
            {
                decimal iznosProvjera;
                if (decimal.TryParse(txtIznosInterni.Text, out iznosProvjera) && iznosProvjera != 0)
                {
                    lblNeispravanIznos.Hide();
                    btnSpremiTransakcijuInterni.Enabled = true;
                }
                else
                {
                    lblNeispravanIznos.Show();
                    btnSpremiTransakcijuInterni.Enabled = false;
                }
            }
            else btnSpremiTransakcijuInterni.Enabled = false;
        }
        #endregion
    }
}
