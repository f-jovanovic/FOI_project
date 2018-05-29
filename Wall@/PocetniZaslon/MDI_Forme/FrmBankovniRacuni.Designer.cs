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
			this.lblMojiBankovniRacuni.Location = new System.Drawing.Point(173, 0);
			this.lblMojiBankovniRacuni.Name = "lblMojiBankovniRacuni";
			this.lblMojiBankovniRacuni.Size = new System.Drawing.Size(506, 65);
			this.lblMojiBankovniRacuni.TabIndex = 0;
			this.lblMojiBankovniRacuni.Text = "Moji bankovni računi";
			// 
			// lblOdaberiteRacun
			// 
			this.lblOdaberiteRacun.AutoSize = true;
			this.lblOdaberiteRacun.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOdaberiteRacun.Location = new System.Drawing.Point(0, 230);
			this.lblOdaberiteRacun.Name = "lblOdaberiteRacun";
			this.lblOdaberiteRacun.Size = new System.Drawing.Size(231, 37);
			this.lblOdaberiteRacun.TabIndex = 1;
			this.lblOdaberiteRacun.Text = "Odaberite račun:";
			// 
			// lblIban
			// 
			this.lblIban.AutoSize = true;
			this.lblIban.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIban.Location = new System.Drawing.Point(141, 350);
			this.lblIban.Name = "lblIban";
			this.lblIban.Size = new System.Drawing.Size(90, 37);
			this.lblIban.TabIndex = 2;
			this.lblIban.Text = "IBAN:";
			// 
			// lblVrstaRacuna
			// 
			this.lblVrstaRacuna.AutoSize = true;
			this.lblVrstaRacuna.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVrstaRacuna.Location = new System.Drawing.Point(48, 400);
			this.lblVrstaRacuna.Name = "lblVrstaRacuna";
			this.lblVrstaRacuna.Size = new System.Drawing.Size(183, 37);
			this.lblVrstaRacuna.TabIndex = 3;
			this.lblVrstaRacuna.Text = "Vrsta računa:";
			// 
			// lblStanjeRacuna
			// 
			this.lblStanjeRacuna.AutoSize = true;
			this.lblStanjeRacuna.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStanjeRacuna.Location = new System.Drawing.Point(35, 450);
			this.lblStanjeRacuna.Name = "lblStanjeRacuna";
			this.lblStanjeRacuna.Size = new System.Drawing.Size(196, 37);
			this.lblStanjeRacuna.TabIndex = 4;
			this.lblStanjeRacuna.Text = "Stanje računa:";
			// 
			// cboRacun
			// 
			this.cboRacun.DataSource = this.bankovniracunBindingSource;
			this.cboRacun.DisplayMember = "naziv_racuna";
			this.cboRacun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboRacun.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboRacun.FormattingEnabled = true;
			this.cboRacun.Location = new System.Drawing.Point(237, 234);
			this.cboRacun.Name = "cboRacun";
			this.cboRacun.Size = new System.Drawing.Size(604, 40);
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
			this.btnDodajNoviRacun.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDodajNoviRacun.Location = new System.Drawing.Point(610, 513);
			this.btnDodajNoviRacun.Name = "btnDodajNoviRacun";
			this.btnDodajNoviRacun.Size = new System.Drawing.Size(231, 54);
			this.btnDodajNoviRacun.TabIndex = 6;
			this.btnDodajNoviRacun.Text = "Dodaj novi račun";
			this.btnDodajNoviRacun.UseVisualStyleBackColor = true;
			this.btnDodajNoviRacun.Click += new System.EventHandler(this.btnDodajNoviRacun_Click);
			// 
			// lblIbanOdabranogRacuna
			// 
			this.lblIbanOdabranogRacuna.AutoSize = true;
			this.lblIbanOdabranogRacuna.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIbanOdabranogRacuna.Location = new System.Drawing.Point(231, 354);
			this.lblIbanOdabranogRacuna.Name = "lblIbanOdabranogRacuna";
			this.lblIbanOdabranogRacuna.Size = new System.Drawing.Size(57, 32);
			this.lblIbanOdabranogRacuna.TabIndex = 7;
			this.lblIbanOdabranogRacuna.Text = "N/A";
			// 
			// lblVrstaOdabranogRacuna
			// 
			this.lblVrstaOdabranogRacuna.AutoSize = true;
			this.lblVrstaOdabranogRacuna.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVrstaOdabranogRacuna.Location = new System.Drawing.Point(231, 404);
			this.lblVrstaOdabranogRacuna.Name = "lblVrstaOdabranogRacuna";
			this.lblVrstaOdabranogRacuna.Size = new System.Drawing.Size(57, 32);
			this.lblVrstaOdabranogRacuna.TabIndex = 8;
			this.lblVrstaOdabranogRacuna.Text = "N/A";
			// 
			// lblStanjeOdabranogRacuna
			// 
			this.lblStanjeOdabranogRacuna.AutoSize = true;
			this.lblStanjeOdabranogRacuna.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStanjeOdabranogRacuna.Location = new System.Drawing.Point(231, 454);
			this.lblStanjeOdabranogRacuna.Name = "lblStanjeOdabranogRacuna";
			this.lblStanjeOdabranogRacuna.Size = new System.Drawing.Size(57, 32);
			this.lblStanjeOdabranogRacuna.TabIndex = 9;
			this.lblStanjeOdabranogRacuna.Text = "N/A";
			// 
			// btnUredi
			// 
			this.btnUredi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUredi.Location = new System.Drawing.Point(680, 280);
			this.btnUredi.Name = "btnUredi";
			this.btnUredi.Size = new System.Drawing.Size(75, 23);
			this.btnUredi.TabIndex = 11;
			this.btnUredi.Text = "Uredi račun";
			this.btnUredi.UseVisualStyleBackColor = true;
			this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
			// 
			// btnObrisi
			// 
			this.btnObrisi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObrisi.Location = new System.Drawing.Point(766, 280);
			this.btnObrisi.Name = "btnObrisi";
			this.btnObrisi.Size = new System.Drawing.Size(75, 23);
			this.btnObrisi.TabIndex = 12;
			this.btnObrisi.Text = "Obriši račun";
			this.btnObrisi.UseVisualStyleBackColor = true;
			this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
			// 
			// FrmBankovniRacuni
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 579);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmBankovniRacuni";
			this.Text = "FrmBankovniRacuni";
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