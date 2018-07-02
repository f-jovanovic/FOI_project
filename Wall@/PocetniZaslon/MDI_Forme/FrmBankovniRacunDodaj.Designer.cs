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
            this.txtNazivRacuna.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNazivRacuna.Location = new System.Drawing.Point(271, 283);
            this.txtNazivRacuna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNazivRacuna.Name = "txtNazivRacuna";
            this.txtNazivRacuna.Size = new System.Drawing.Size(804, 47);
            this.txtNazivRacuna.TabIndex = 0;
            this.txtNazivRacuna.TextChanged += new System.EventHandler(this.TxtNazivRacuna_TextChanged);
            // 
            // txtIban
            // 
            this.txtIban.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIban.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIban.Location = new System.Drawing.Point(271, 352);
            this.txtIban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(804, 47);
            this.txtIban.TabIndex = 1;
            this.txtIban.TextChanged += new System.EventHandler(this.TxtIban_TextChanged);
            // 
            // txtStanjeRacuna
            // 
            this.txtStanjeRacuna.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStanjeRacuna.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStanjeRacuna.Location = new System.Drawing.Point(271, 475);
            this.txtStanjeRacuna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStanjeRacuna.Name = "txtStanjeRacuna";
            this.txtStanjeRacuna.Size = new System.Drawing.Size(804, 47);
            this.txtStanjeRacuna.TabIndex = 3;
            this.txtStanjeRacuna.TextChanged += new System.EventHandler(this.txtStanjeRacuna_TextChanged);
            // 
            // cboVrstaRacuna
            // 
            this.cboVrstaRacuna.DataSource = this.vrstaracunaBindingSource;
            this.cboVrstaRacuna.DisplayMember = "naziv_vrste_racuna";
            this.cboVrstaRacuna.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVrstaRacuna.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVrstaRacuna.FormattingEnabled = true;
            this.cboVrstaRacuna.Location = new System.Drawing.Point(271, 414);
            this.cboVrstaRacuna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboVrstaRacuna.Name = "cboVrstaRacuna";
            this.cboVrstaRacuna.Size = new System.Drawing.Size(804, 49);
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
            this.lblStanjeRacuna.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStanjeRacuna.Location = new System.Drawing.Point(1, 474);
            this.lblStanjeRacuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanjeRacuna.Name = "lblStanjeRacuna";
            this.lblStanjeRacuna.Size = new System.Drawing.Size(244, 46);
            this.lblStanjeRacuna.TabIndex = 13;
            this.lblStanjeRacuna.Text = "Stanje računa:";
            // 
            // lblVrstaRacuna
            // 
            this.lblVrstaRacuna.AutoSize = true;
            this.lblVrstaRacuna.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrstaRacuna.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVrstaRacuna.Location = new System.Drawing.Point(19, 412);
            this.lblVrstaRacuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVrstaRacuna.Name = "lblVrstaRacuna";
            this.lblVrstaRacuna.Size = new System.Drawing.Size(228, 46);
            this.lblVrstaRacuna.TabIndex = 12;
            this.lblVrstaRacuna.Text = "Vrsta računa:";
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIban.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIban.Location = new System.Drawing.Point(134, 352);
            this.lblIban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(113, 46);
            this.lblIban.TabIndex = 11;
            this.lblIban.Text = "IBAN:";
            // 
            // lblNazivRacuna
            // 
            this.lblNazivRacuna.AutoSize = true;
            this.lblNazivRacuna.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivRacuna.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNazivRacuna.Location = new System.Drawing.Point(12, 284);
            this.lblNazivRacuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazivRacuna.Name = "lblNazivRacuna";
            this.lblNazivRacuna.Size = new System.Drawing.Size(235, 46);
            this.lblNazivRacuna.TabIndex = 10;
            this.lblNazivRacuna.Text = "Naziv računa:";
            // 
            // lblMojiBankovniRacuni
            // 
            this.lblMojiBankovniRacuni.AutoSize = true;
            this.lblMojiBankovniRacuni.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMojiBankovniRacuni.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMojiBankovniRacuni.Location = new System.Drawing.Point(231, 0);
            this.lblMojiBankovniRacuni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMojiBankovniRacuni.Name = "lblMojiBankovniRacuni";
            this.lblMojiBankovniRacuni.Size = new System.Drawing.Size(653, 81);
            this.lblMojiBankovniRacuni.TabIndex = 9;
            this.lblMojiBankovniRacuni.Text = "Dodaj bankovni račun";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOtkazi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOtkazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtkazi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.ForeColor = System.Drawing.Color.White;
            this.btnOtkazi.Location = new System.Drawing.Point(768, 583);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(308, 66);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnDodajNoviRacun
            // 
            this.btnDodajNoviRacun.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDodajNoviRacun.Enabled = false;
            this.btnDodajNoviRacun.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDodajNoviRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajNoviRacun.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNoviRacun.ForeColor = System.Drawing.Color.White;
            this.btnDodajNoviRacun.Location = new System.Drawing.Point(437, 583);
            this.btnDodajNoviRacun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajNoviRacun.Name = "btnDodajNoviRacun";
            this.btnDodajNoviRacun.Size = new System.Drawing.Size(308, 66);
            this.btnDodajNoviRacun.TabIndex = 4;
            this.btnDodajNoviRacun.Text = "Dodaj novi račun";
            this.btnDodajNoviRacun.UseVisualStyleBackColor = false;
            this.btnDodajNoviRacun.Click += new System.EventHandler(this.btnDodajNoviRacun_Click);
            // 
            // lblUpozorenjeIban
            // 
            this.lblUpozorenjeIban.AutoSize = true;
            this.lblUpozorenjeIban.ForeColor = System.Drawing.Color.Red;
            this.lblUpozorenjeIban.Location = new System.Drawing.Point(267, 332);
            this.lblUpozorenjeIban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpozorenjeIban.Name = "lblUpozorenjeIban";
            this.lblUpozorenjeIban.Size = new System.Drawing.Size(165, 17);
            this.lblUpozorenjeIban.TabIndex = 16;
            this.lblUpozorenjeIban.Text = "IBAN mora imati 21 znak!";
            this.lblUpozorenjeIban.Visible = false;
            // 
            // FrmBankovniRacunDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 665);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBankovniRacunDodaj";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wall@ | Dodaj bankovni račun";
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