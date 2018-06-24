using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocetniZaslon.Dialog_forme
{
	public partial class FrmPrikazSlike : Form
	{
		string lokacijaSlike;

		public FrmPrikazSlike(string text)
		{
			InitializeComponent();
			lokacijaSlike = text;
		}

		private void FrmPrikazSlike_Load(object sender, EventArgs e)
		{
			try
			{
				pictureBoxSlika.Image = Image.FromFile(lokacijaSlike);
				this.Size = new Size(pictureBoxSlika.Image.Width + 15, pictureBoxSlika.Image.Height + 40);
			}
			catch (Exception)
			{
				MessageBox.Show("Slika ne postoji na zapisanoj lokaciji.");
				this.Close();
			}
			
		}
	}
}
