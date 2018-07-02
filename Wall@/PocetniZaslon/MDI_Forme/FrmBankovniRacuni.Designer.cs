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
            this.components = new System.ComponentModel.Container();
            this.lblMojiBankovniRacuni = new System.Windows.Forms.Label();
            this.lblOdaberiteRacun = new System.Windows.Forms.Label();
            this.lblIban = new System.Windows.Forms.Label();
            this.lblVrstaRacuna = new System.Windows.Forms.Label();
            this.lblStanjeRacuna = new System.Windows.Forms.Label();
            this.cboRacun = new System.Windows.Forms.ComboBox();
            this.bankovniracunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajNoviRacun = new System.Windows.Forms.Button();
            this.lblIbanOdabranogRacuna = new System.Windows.Forms.Label();
            this.lblVrstaOdabranogRacuna = new System.Windows.Forms.Label();
            this.lblStanjeOdabranogRacuna = new System.Windows.Forms.Label();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMojiBankovniRacuni
            // 
            this.lblMojiBankovniRacuni.AutoSize = true;
            this.lblMojiBankovniRacuni.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMojiBankovniRacuni.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMojiBankovniRacuni.Location = new System.Drawing.Point(231, 0);
            this.lblMojiBankovniRacuni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMojiBankovniRacuni.Name = "lblMojiBankovniRacuni";
            this.lblMojiBankovniRacuni.Size = new System.Drawing.Size(631, 81);
            this.lblMojiBankovniRacuni.TabIndex = 0;
            this.lblMojiBankovniRacuni.Text = "Moji bankovni računi";
            // 
            // lblOdaberiteRacun
            // 
            this.lblOdaberiteRacun.AutoSize = true;
            this.lblOdaberiteRacun.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdaberiteRacun.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOdaberiteRacun.Location = new System.Drawing.Point(4, 287);
            this.lblOdaberiteRacun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaberiteRacun.Name = "lblOdaberiteRacun";
            this.lblOdaberiteRacun.Size = new System.Drawing.Size(287, 46);
            this.lblOdaberiteRacun.TabIndex = 1;
            this.lblOdaberiteRacun.Text = "Odaberite račun:";
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIban.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIban.Location = new System.Drawing.Point(178, 431);
            this.lblIban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(113, 46);
            this.lblIban.TabIndex = 2;
            this.lblIban.Text = "IBAN:";
            // 
            // lblVrstaRacuna
            // 
            this.lblVrstaRacuna.AutoSize = true;
            this.lblVrstaRacuna.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrstaRacuna.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVrstaRacuna.Location = new System.Drawing.Point(64, 492);
            this.lblVrstaRacuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVrstaRacuna.Name = "lblVrstaRacuna";
            this.lblVrstaRacuna.Size = new System.Drawing.Size(228, 46);
            this.lblVrstaRacuna.TabIndex = 3;
            this.lblVrstaRacuna.Text = "Vrsta računa:";
            // 
            // lblStanjeRacuna
            // 
            this.lblStanjeRacuna.AutoSize = true;
            this.lblStanjeRacuna.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStanjeRacuna.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStanjeRacuna.Location = new System.Drawing.Point(47, 554);
            this.lblStanjeRacuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanjeRacuna.Name = "lblStanjeRacuna";
            this.lblStanjeRacuna.Size = new System.Drawing.Size(244, 46);
            this.lblStanjeRacuna.TabIndex = 4;
            this.lblStanjeRacuna.Text = "Stanje računa:";
            // 
            // cboRacun
            // 
            this.cboRacun.BackColor = System.Drawing.Color.White;
            this.cboRacun.DataSource = this.bankovniracunBindingSource;
            this.cboRacun.DisplayMember = "naziv_racuna";
            this.cboRacun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRacun.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRacun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboRacun.FormattingEnabled = true;
            this.cboRacun.Location = new System.Drawing.Point(316, 288);
            this.cboRacun.Margin = new System.Windows.Forms.Padding(4);
            this.cboRacun.Name = "cboRacun";
            this.cboRacun.Size = new System.Drawing.Size(804, 49);
            this.cboRacun.TabIndex = 5;
            this.cboRacun.ValueMember = "iban";
            // 
            // bankovniracunBindingSource
            // 
            this.bankovniracunBindingSource.DataSource = typeof(PocetniZaslon.Bankovni_racun);
            this.bankovniracunBindingSource.CurrentChanged += new System.EventHandler(this.bankovniracunBindingSource_CurrentChanged);
            // 
            // btnDodajNoviRacun
            // 
            this.btnDodajNoviRacun.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDodajNoviRacun.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDodajNoviRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajNoviRacun.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNoviRacun.ForeColor = System.Drawing.Color.White;
            this.btnDodajNoviRacun.Location = new System.Drawing.Point(813, 631);
            this.btnDodajNoviRacun.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajNoviRacun.Name = "btnDodajNoviRacun";
            this.btnDodajNoviRacun.Size = new System.Drawing.Size(308, 66);
            this.btnDodajNoviRacun.TabIndex = 6;
            this.btnDodajNoviRacun.Text = "Dodaj novi račun";
            this.btnDodajNoviRacun.UseVisualStyleBackColor = false;
            this.btnDodajNoviRacun.Click += new System.EventHandler(this.btnDodajNoviRacun_Click);
            // 
            // lblIbanOdabranogRacuna
            // 
            this.lblIbanOdabranogRacuna.AutoSize = true;
            this.lblIbanOdabranogRacuna.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIbanOdabranogRacuna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIbanOdabranogRacuna.Location = new System.Drawing.Point(308, 435);
            this.lblIbanOdabranogRacuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIbanOdabranogRacuna.Name = "lblIbanOdabranogRacuna";
            this.lblIbanOdabranogRacuna.Size = new System.Drawing.Size(71, 41);
            this.lblIbanOdabranogRacuna.TabIndex = 7;
            this.lblIbanOdabranogRacuna.Text = "N/A";
            // 
            // lblVrstaOdabranogRacuna
            // 
            this.lblVrstaOdabranogRacuna.AutoSize = true;
            this.lblVrstaOdabranogRacuna.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrstaOdabranogRacuna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVrstaOdabranogRacuna.Location = new System.Drawing.Point(308, 496);
            this.lblVrstaOdabranogRacuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVrstaOdabranogRacuna.Name = "lblVrstaOdabranogRacuna";
            this.lblVrstaOdabranogRacuna.Size = new System.Drawing.Size(71, 41);
            this.lblVrstaOdabranogRacuna.TabIndex = 8;
            this.lblVrstaOdabranogRacuna.Text = "N/A";
            // 
            // lblStanjeOdabranogRacuna
            // 
            this.lblStanjeOdabranogRacuna.AutoSize = true;
            this.lblStanjeOdabranogRacuna.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStanjeOdabranogRacuna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStanjeOdabranogRacuna.Location = new System.Drawing.Point(308, 558);
            this.lblStanjeOdabranogRacuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanjeOdabranogRacuna.Name = "lblStanjeOdabranogRacuna";
            this.lblStanjeOdabranogRacuna.Size = new System.Drawing.Size(71, 41);
            this.lblStanjeOdabranogRacuna.TabIndex = 9;
            this.lblStanjeOdabranogRacuna.Text = "N/A";
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUredi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUredi.ForeColor = System.Drawing.Color.White;
            this.btnUredi.Location = new System.Drawing.Point(907, 345);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(4);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(100, 28);
            this.btnUredi.TabIndex = 11;
            this.btnUredi.Text = "Uredi račun";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnObrisi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(1021, 345);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 28);
            this.btnObrisi.TabIndex = 12;
            this.btnObrisi.Text = "Obriši račun";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FrmBankovniRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 713);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.lblStanjeOdabranogRacuna);
            this.Controls.Add(this.lblVrstaOdabranogRacuna);
            this.Controls.Add(this.lblIbanOdabranogRacuna);
            this.Controls.Add(this.btnDodajNoviRacun);
            this.Controls.Add(this.cboRacun);
            this.Controls.Add(this.lblStanjeRacuna);
            this.Controls.Add(this.lblVrstaRacuna);
            this.Controls.Add(this.lblIban);
            this.Controls.Add(this.lblOdaberiteRacun);
            this.Controls.Add(this.lblMojiBankovniRacuni);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBankovniRacuni";
            this.Text = "FrmBankovniRacuni";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmBankovniRacuni_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).EndInit();
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
		private System.Windows.Forms.Label lblIbanOdabranogRacuna;
		private System.Windows.Forms.Label lblVrstaOdabranogRacuna;
		private System.Windows.Forms.Label lblStanjeOdabranogRacuna;
		private System.Windows.Forms.BindingSource bankovniracunBindingSource;
		private System.Windows.Forms.Button btnUredi;
		private System.Windows.Forms.Button btnObrisi;
	}
}