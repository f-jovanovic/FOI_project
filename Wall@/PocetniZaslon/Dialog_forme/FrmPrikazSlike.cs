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
		public string LokacijaSlike { get; set; }
		public FrmPrikazSlike(string text)
		{
			InitializeComponent();
			LokacijaSlike = text;
		}

		private void FrmPrikazSlike_Load(object sender, EventArgs e)
		{
			try
			{
				pictureBoxSlika.Image = Image.FromFile(LokacijaSlike);
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
