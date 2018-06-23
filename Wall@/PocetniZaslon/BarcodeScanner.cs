using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace PocetniZaslon
{
    /// <summary>
    /// Klasa za skeniranje barkoda iz JPG datoteke. Putem property elemenata pristupa se rezultatima skeniranja.
    /// </summary>
    public class BarcodeScanner
    {
        BarcodeReader barcodeReader = new BarcodeReader();
        Image izvornaSlikaRacuna;

        public decimal skeniraniIznos { get; set; }
        public string skeniraniOpis { get; set; }
        public string lokacijaSlikeRacuna { get; set; }

        /// <summary>
        /// Metoda koja uzima putanju do slike i izvršava skeniranje uz pretvorbu u Bitmap format.
        /// </summary>
        public void SkenirajRacun()
        {
            izvornaSlikaRacuna = Image.FromFile(@lokacijaSlikeRacuna);
            string folderZaTemporary = Path.GetTempPath() + "tmpRacun.bmp";

            IzbrisiSliku(@folderZaTemporary);

            // Sliku spremamo u temporary folder od Windows OS-a jer nam je potrebna samo prilikom skeniranja/okretanja slike.
            izvornaSlikaRacuna.Save(@folderZaTemporary, ImageFormat.Bmp);
            Bitmap slikaRacunaBitmap = Image.FromFile(@folderZaTemporary) as Bitmap;

            var rezultatSkeniranja = barcodeReader.Decode(slikaRacunaBitmap);

            // Trenutno je hardcode-ano da se prihvaća i uzima samo sadržaj sa HUB30 tipa uplatnice.
            if (rezultatSkeniranja == null)
            {
                System.Windows.Forms.MessageBox.Show("Barkod nije pronađen!");
            }

            else if (rezultatSkeniranja.ToString().Contains("HRVHUB30"))
            {
                List<string> skeniraniTekst = (rezultatSkeniranja.ToString().Split(Environment.NewLine.ToCharArray())).ToList();

                skeniraniIznos = (decimal.Parse(skeniraniTekst.ElementAt(2)) / 100);

                skeniraniOpis += skeniraniTekst.ElementAt(6) + Environment.NewLine;
                skeniraniOpis += skeniraniTekst.ElementAt(7) + Environment.NewLine;
                skeniraniOpis += skeniraniTekst.ElementAt(8) + Environment.NewLine;
                skeniraniOpis += skeniraniTekst.ElementAt(13) + Environment.NewLine;
            }

            else if (!string.IsNullOrEmpty(rezultatSkeniranja.ToString()))
            {
                System.Windows.Forms.MessageBox.Show("Format barkoda nije podržan!");
            }
        }

        /// <summary>
        /// Metoda za brisanje slike sa računala.
        /// </summary>
        /// <param name="lokacija"></param>
        private void IzbrisiSliku(string lokacija)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.Delete(lokacija);
        }
    }
}
