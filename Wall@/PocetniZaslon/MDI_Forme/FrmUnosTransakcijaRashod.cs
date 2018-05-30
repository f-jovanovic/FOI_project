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
    public partial class FrmUnosTransakcijaRashod : Form
    {
        Korisnik trenutniKorisnik = null;
        public FrmUnosTransakcijaRashod(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }
        /// <summary>
        /// Kod pokretanja forme UnosTransakcija učitaj bankovne račune trenutnog korisnika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUnosTransakcijaTrosak_Load(object sender, EventArgs e)
        {
            BindingList<Bankovni_racun> listBankovniRacuni = null;
            List<Kategorije_transakcije> listKategorije = null;
            using (WalletEntities db = new WalletEntities())
            {
                db.Korisnik.Attach(trenutniKorisnik);
                listBankovniRacuni = new BindingList<Bankovni_racun>(trenutniKorisnik.Bankovni_racun.ToList());
                listKategorije = new List<Kategorije_transakcije>(db.Kategorije_transakcije.ToList());

                foreach (var item in listKategorije.ToList())
                {
                    if (item.Vrsta_transakcije.naziv_vrste_transakcije != "Rashod") listKategorije.Remove(item);
                    if (item.Korisnik != null && item.Korisnik != trenutniKorisnik) listKategorije.Remove(item);
                }
            }

            bankovniracunBindingSource.DataSource = listBankovniRacuni;

            foreach (var item in listKategorije)
            {
                chkKategorije.Items.Add(item.naziv_kategorije);
            }
        }

        private void btnSpremiTransakcijuRashod_Click(object sender, EventArgs e)
        {
            using (WalletEntities db = new WalletEntities())
            {
                db.Korisnik.Attach(trenutniKorisnik);
                db.Bankovni_racun.Attach(bankovniracunBindingSource.Current as Bankovni_racun);

                Transakcija noviRashod = new Transakcija
                {
                    Bankovni_racun = bankovniracunBindingSource.Current as Bankovni_racun,
                    iznos_transakcije = decimal.Parse(txtIznos.Text.ToString()),
                    vrijeme_transakcije = dtpDatumTransakcijeRashod.Value.Date + dtpVrijemeTransakcijeRashod.Value.TimeOfDay,
                    opis_transakcije = txtOpis.Text.ToString()
                };

                foreach (var item in chkKategorije.CheckedItems)
                {
                    noviRashod.Kategorije_transakcije.Add(item as Kategorije_transakcije);
                }

                foreach (var item in chkKategorije.CheckedItems)
                {
                    foreach (var kategorija in db.Kategorije_transakcije.ToList())
                    {
                        if (kategorija.naziv_kategorije.ToString() == item.ToString()) kategorija.Transakcija.Add(noviRashod);
                    }
                }

                db.Transakcija.Add(noviRashod);
                db.SaveChanges();
            }
        }
    }
}
