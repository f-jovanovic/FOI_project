namespace PocetniZaslon.MDI_Forme
{
	partial class FrmBankovniRacunDodaj
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
			this.components = new System.ComponentModel.Container();
			this.txtNazivRacuna = new System.Windows.Forms.TextBox();
			this.txtIban = new System.Windows.Forms.TextBox();
			this.txtStanjeRacuna = new System.Windows.Forms.TextBox();
			this.cboVrstaRacuna = new System.Windows.Forms.ComboBox();
			this.vrstaracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblStanjeRacuna = new System.Windows.Forms.Label();
			this.lblVrstaRacuna = new System.Windows.Forms.Label();
			this.lblIban = new System.Windows.Forms.Label();
			this.lblNazivRacuna = new System.Windows.Forms.Label();
			this.lblMojiBankovniRacuni = new System.Windows.Forms.Label();
			this.btnOtkazi = new System.Windows.Forms.Button();
			this.btnDodajNoviRacun = new System.Windows.Forms.Button();
			this.lblUpozorenjeIban = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.vrstaracunaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNazivRacuna
			// 
			this.txtNazivRacuna.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNazivRacuna.Location = new System.Drawing.Point(203, 230);
			this.txtNazivRacuna.Name = "txtNazivRacuna";
			this.txtNazivRacuna.Size = new System.Drawing.Size(604, 39);
			this.txtNazivRacuna.TabIndex = 0;
			this.txtNazivRacuna.TextChanged += new System.EventHandler(this.TxtNazivRacuna_TextChanged);
			// 
			// txtIban
			// 
			this.txtIban.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIban.Location = new System.Drawing.Point(203, 286);
			this.txtIban.Name = "txtIban";
			this.txtIban.Size = new System.Drawing.Size(604, 39);
			this.txtIban.TabIndex = 1;
			this.txtIban.TextChanged += new System.EventHandler(this.TxtIban_TextChanged);
			// 
			// txtStanjeRacuna
			// 
			this.txtStanjeRacuna.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStanjeRacuna.Location = new System.Drawing.Point(203, 386);
			this.txtStanjeRacuna.Name = "txtStanjeRacuna";
			this.txtStanjeRacuna.Size = new System.Drawing.Size(604, 39);
			this.txtStanjeRacuna.TabIndex = 3;
			this.txtStanjeRacuna.TextChanged += new System.EventHandler(this.txtStanjeRacuna_TextChanged);
			// 
			// cboVrstaRacuna
			// 
			this.cboVrstaRacuna.DataSource = this.vrstaracunaBindingSource;
			this.cboVrstaRacuna.DisplayMember = "naziv_vrste_racuna";
			this.cboVrstaRacuna.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboVrstaRacuna.FormattingEnabled = true;
			this.cboVrstaRacuna.Location = new System.Drawing.Point(203, 336);
			this.cboVrstaRacuna.Name = "cboVrstaRacuna";
			this.cboVrstaRacuna.Size = new System.Drawing.Size(604, 40);
			this.cboVrstaRacuna.TabIndex = 2;
			this.cboVrstaRacuna.ValueMember = "id_vrsta_racuna";
			// 
			// vrstaracunaBindingSource
			// 
			this.vrstaracunaBindingSource.DataSource = typeof(PocetniZaslon.Vrsta_racuna);
			// 
			// lblStanjeRacuna
			// 
			this.lblStanjeRacuna.AutoSize = true;
			this.lblStanjeRacuna.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStanjeRacuna.Location = new System.Drawing.Point(1, 385);
			this.lblStanjeRacuna.Name = "lblStanjeRacuna";
			this.lblStanjeRacuna.Size = new System.Drawing.Size(196, 37);
			this.lblStanjeRacuna.TabIndex = 13;
			this.lblStanjeRacuna.Text = "Stanje računa:";
			// 
			// lblVrstaRacuna
			// 
			this.lblVrstaRacuna.AutoSize = true;
			this.lblVrstaRacuna.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVrstaRacuna.Location = new System.Drawing.Point(14, 335);
			this.lblVrstaRacuna.Name = "lblVrstaRacuna";
			this.lblVrstaRacuna.Size = new System.Drawing.Size(183, 37);
			this.lblVrstaRacuna.TabIndex = 12;
			this.lblVrstaRacuna.Text = "Vrsta računa:";
			// 
			// lblIban
			// 
			this.lblIban.AutoSize = true;
			this.lblIban.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIban.Location = new System.Drawing.Point(107, 286);
			this.lblIban.Name = "lblIban";
			this.lblIban.Size = new System.Drawing.Size(90, 37);
			this.lblIban.TabIndex = 11;
			this.lblIban.Text = "IBAN:";
			// 
			// lblNazivRacuna
			// 
			this.lblNazivRacuna.AutoSize = true;
			this.lblNazivRacuna.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNazivRacuna.Location = new System.Drawing.Point(8, 229);
			this.lblNazivRacuna.Name = "lblNazivRacuna";
			this.lblNazivRacuna.Size = new System.Drawing.Size(189, 37);
			this.lblNazivRacuna.TabIndex = 10;
			this.lblNazivRacuna.Text = "Naziv računa:";
			// 
			// lblMojiBankovniRacuni
			// 
			this.lblMojiBankovniRacuni.AutoSize = true;
			this.lblMojiBankovniRacuni.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMojiBankovniRacuni.Location = new System.Drawing.Point(173, 0);
			this.lblMojiBankovniRacuni.Name = "lblMojiBankovniRacuni";
			this.lblMojiBankovniRacuni.Size = new System.Drawing.Size(523, 65);
			this.lblMojiBankovniRacuni.TabIndex = 9;
			this.lblMojiBankovniRacuni.Text = "Dodaj bankovni račun";
			// 
			// btnOtkazi
			// 
			this.btnOtkazi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOtkazi.Location = new System.Drawing.Point(576, 474);
			this.btnOtkazi.Name = "btnOtkazi";
			this.btnOtkazi.Size = new System.Drawing.Size(231, 54);
			this.btnOtkazi.TabIndex = 5;
			this.btnOtkazi.Text = "Otkaži";
			this.btnOtkazi.UseVisualStyleBackColor = true;
			this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
			// 
			// btnDodajNoviRacun
			// 
			this.btnDodajNoviRacun.Enabled = false;
			this.btnDodajNoviRacun.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDodajNoviRacun.Location = new System.Drawing.Point(328, 474);
			this.btnDodajNoviRacun.Name = "btnDodajNoviRacun";
			this.btnDodajNoviRacun.Size = new System.Drawing.Size(231, 54);
			this.btnDodajNoviRacun.TabIndex = 4;
			this.btnDodajNoviRacun.Text = "Dodaj novi račun";
			this.btnDodajNoviRacun.UseVisualStyleBackColor = true;
			this.btnDodajNoviRacun.Click += new System.EventHandler(this.btnDodajNoviRacun_Click);
			// 
			// lblUpozorenjeIban
			// 
			this.lblUpozorenjeIban.AutoSize = true;
			this.lblUpozorenjeIban.ForeColor = System.Drawing.Color.Red;
			this.lblUpozorenjeIban.Location = new System.Drawing.Point(200, 270);
			this.lblUpozorenjeIban.Name = "lblUpozorenjeIban";
			this.lblUpozorenjeIban.Size = new System.Drawing.Size(126, 13);
			this.lblUpozorenjeIban.TabIndex = 16;
			this.lblUpozorenjeIban.Text = "IBAN mora imati 21 znak!";
			this.lblUpozorenjeIban.Visible = false;
			// 
			// FrmBankovniRacunDodaj
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 540);
			this.Controls.Add(this.lblUpozorenjeIban);
			this.Controls.Add(this.btnOtkazi);
			this.Controls.Add(this.btnDodajNoviRacun);
			this.Controls.Add(this.lblStanjeRacuna);
			this.Controls.Add(this.lblVrstaRacuna);
			this.Controls.Add(this.lblIban);
			this.Controls.Add(this.lblNazivRacuna);
			this.Controls.Add(this.lblMojiBankovniRacuni);
			this.Controls.Add(this.cboVrstaRacuna);
			this.Controls.Add(this.txtStanjeRacuna);
			this.Controls.Add(this.txtIban);
			this.Controls.Add(this.txtNazivRacuna);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmBankovniRacunDodaj";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dodaj bankovni račun";
			((System.ComponentModel.ISupportInitialize)(this.vrstaracunaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNazivRacuna;
		private System.Windows.Forms.TextBox txtIban;
		private System.Windows.Forms.TextBox txtStanjeRacuna;
		private System.Windows.Forms.ComboBox cboVrstaRacuna;
		private System.Windows.Forms.Label lblStanjeRacuna;
		private System.Windows.Forms.Label lblVrstaRacuna;
		private System.Windows.Forms.Label lblIban;
		private System.Windows.Forms.Label lblNazivRacuna;
		private System.Windows.Forms.Label lblMojiBankovniRacuni;
		private System.Windows.Forms.BindingSource vrstaracunaBindingSource;
		private System.Windows.Forms.Button btnOtkazi;
		private System.Windows.Forms.Button btnDodajNoviRacun;
		private System.Windows.Forms.Label lblUpozorenjeIban;
	}
}