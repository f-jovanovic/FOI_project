namespace PocetniZaslon.MDI_Forme
{
	partial class FrmBankovniRacuni
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblMojiBankovniRacuni = new System.Windows.Forms.Label();
			this.lblOdaberiteRacun = new System.Windows.Forms.Label();
			this.lblIban = new System.Windows.Forms.Label();
			this.lblVrstaRacuna = new System.Windows.Forms.Label();
			this.lblStanjeRacuna = new System.Windows.Forms.Label();
			this.cboRacun = new System.Windows.Forms.ComboBox();
			this.btnDodajNoviRacun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblMojiBankovniRacuni
			// 
			this.lblMojiBankovniRacuni.AutoSize = true;
			this.lblMojiBankovniRacuni.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMojiBankovniRacuni.Location = new System.Drawing.Point(278, 32);
			this.lblMojiBankovniRacuni.Name = "lblMojiBankovniRacuni";
			this.lblMojiBankovniRacuni.Size = new System.Drawing.Size(259, 32);
			this.lblMojiBankovniRacuni.TabIndex = 0;
			this.lblMojiBankovniRacuni.Text = "Moji bankovni računi";
			// 
			// lblOdaberiteRacun
			// 
			this.lblOdaberiteRacun.AutoSize = true;
			this.lblOdaberiteRacun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOdaberiteRacun.Location = new System.Drawing.Point(222, 122);
			this.lblOdaberiteRacun.Name = "lblOdaberiteRacun";
			this.lblOdaberiteRacun.Size = new System.Drawing.Size(137, 21);
			this.lblOdaberiteRacun.TabIndex = 1;
			this.lblOdaberiteRacun.Text = "Odaberite račun:";
			// 
			// lblIban
			// 
			this.lblIban.AutoSize = true;
			this.lblIban.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIban.Location = new System.Drawing.Point(306, 229);
			this.lblIban.Name = "lblIban";
			this.lblIban.Size = new System.Drawing.Size(53, 21);
			this.lblIban.TabIndex = 2;
			this.lblIban.Text = "IBAN:";
			// 
			// lblVrstaRacuna
			// 
			this.lblVrstaRacuna.AutoSize = true;
			this.lblVrstaRacuna.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVrstaRacuna.Location = new System.Drawing.Point(251, 263);
			this.lblVrstaRacuna.Name = "lblVrstaRacuna";
			this.lblVrstaRacuna.Size = new System.Drawing.Size(108, 21);
			this.lblVrstaRacuna.TabIndex = 3;
			this.lblVrstaRacuna.Text = "Vrsta računa:";
			// 
			// lblStanjeRacuna
			// 
			this.lblStanjeRacuna.AutoSize = true;
			this.lblStanjeRacuna.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStanjeRacuna.Location = new System.Drawing.Point(241, 298);
			this.lblStanjeRacuna.Name = "lblStanjeRacuna";
			this.lblStanjeRacuna.Size = new System.Drawing.Size(118, 21);
			this.lblStanjeRacuna.TabIndex = 4;
			this.lblStanjeRacuna.Text = "Stanje računa:";
			// 
			// cboRacun
			// 
			this.cboRacun.FormattingEnabled = true;
			this.cboRacun.Location = new System.Drawing.Point(366, 122);
			this.cboRacun.Name = "cboRacun";
			this.cboRacun.Size = new System.Drawing.Size(213, 21);
			this.cboRacun.TabIndex = 5;
			// 
			// btnDodajNoviRacun
			// 
			this.btnDodajNoviRacun.Location = new System.Drawing.Point(585, 120);
			this.btnDodajNoviRacun.Name = "btnDodajNoviRacun";
			this.btnDodajNoviRacun.Size = new System.Drawing.Size(124, 23);
			this.btnDodajNoviRacun.TabIndex = 6;
			this.btnDodajNoviRacun.Text = "Dodaj novi račun";
			this.btnDodajNoviRacun.UseVisualStyleBackColor = true;
			// 
			// FrmBankovniRacuni
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDodajNoviRacun);
			this.Controls.Add(this.cboRacun);
			this.Controls.Add(this.lblStanjeRacuna);
			this.Controls.Add(this.lblVrstaRacuna);
			this.Controls.Add(this.lblIban);
			this.Controls.Add(this.lblOdaberiteRacun);
			this.Controls.Add(this.lblMojiBankovniRacuni);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmBankovniRacuni";
			this.Text = "FrmBankovniRacuni";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMojiBankovniRacuni;
		private System.Windows.Forms.Label lblOdaberiteRacun;
		private System.Windows.Forms.Label lblIban;
		private System.Windows.Forms.Label lblVrstaRacuna;
		private System.Windows.Forms.Label lblStanjeRacuna;
		private System.Windows.Forms.ComboBox cboRacun;
		private System.Windows.Forms.Button btnDodajNoviRacun;
	}
}