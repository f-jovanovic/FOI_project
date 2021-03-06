﻿namespace PocetniZaslon.MDI_Forme
{
	partial class FrmInvesticijskiPortfolio
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
            this.lblInvesticijskiPortfolio = new System.Windows.Forms.Label();
            this.gBoxTransakcija = new System.Windows.Forms.GroupBox();
            this.lblKriviTipPodatakaIznos = new System.Windows.Forms.Label();
            this.lblKriviTipPodatakaKolicina = new System.Windows.Forms.Label();
            this.cboNazivInvesticije = new System.Windows.Forms.ComboBox();
            this.investicijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboBankovniRačun = new System.Windows.Forms.ComboBox();
            this.bankovniracunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtIznosTransInv = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnIzvrsiTransakciju = new System.Windows.Forms.Button();
            this.rBtnProdaj = new System.Windows.Forms.RadioButton();
            this.rBtnKupi = new System.Windows.Forms.RadioButton();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblBankovniRacun = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.vrstainvesticijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVlastiteInvesticije = new System.Windows.Forms.DataGridView();
            this.stanjeinvesticijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transakcijainvesticijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankovniracunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vrstainvesticijeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnDohvati = new System.Windows.Forms.Button();
            this.lblTekst = new System.Windows.Forms.Label();
            this.gBoxTransakcija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.investicijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstainvesticijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVlastiteInvesticije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeinvesticijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijainvesticijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstainvesticijeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvesticijskiPortfolio
            // 
            this.lblInvesticijskiPortfolio.AutoSize = true;
            this.lblInvesticijskiPortfolio.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblInvesticijskiPortfolio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblInvesticijskiPortfolio.Location = new System.Drawing.Point(364, 16);
            this.lblInvesticijskiPortfolio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvesticijskiPortfolio.Name = "lblInvesticijskiPortfolio";
            this.lblInvesticijskiPortfolio.Size = new System.Drawing.Size(402, 51);
            this.lblInvesticijskiPortfolio.TabIndex = 0;
            this.lblInvesticijskiPortfolio.Text = "Investicijski portfolio";
            // 
            // gBoxTransakcija
            // 
            this.gBoxTransakcija.Controls.Add(this.lblKriviTipPodatakaIznos);
            this.gBoxTransakcija.Controls.Add(this.lblKriviTipPodatakaKolicina);
            this.gBoxTransakcija.Controls.Add(this.cboNazivInvesticije);
            this.gBoxTransakcija.Controls.Add(this.cboBankovniRačun);
            this.gBoxTransakcija.Controls.Add(this.dtpDatum);
            this.gBoxTransakcija.Controls.Add(this.txtIznosTransInv);
            this.gBoxTransakcija.Controls.Add(this.txtKolicina);
            this.gBoxTransakcija.Controls.Add(this.btnIzvrsiTransakciju);
            this.gBoxTransakcija.Controls.Add(this.rBtnProdaj);
            this.gBoxTransakcija.Controls.Add(this.rBtnKupi);
            this.gBoxTransakcija.Controls.Add(this.lblIznos);
            this.gBoxTransakcija.Controls.Add(this.lblBankovniRacun);
            this.gBoxTransakcija.Controls.Add(this.lblDatum);
            this.gBoxTransakcija.Controls.Add(this.lblKolicina);
            this.gBoxTransakcija.Controls.Add(this.lblNaziv);
            this.gBoxTransakcija.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gBoxTransakcija.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gBoxTransakcija.Location = new System.Drawing.Point(768, 97);
            this.gBoxTransakcija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxTransakcija.Name = "gBoxTransakcija";
            this.gBoxTransakcija.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxTransakcija.Size = new System.Drawing.Size(453, 664);
            this.gBoxTransakcija.TabIndex = 1;
            this.gBoxTransakcija.TabStop = false;
            this.gBoxTransakcija.Text = "Transakcija";
            // 
            // lblKriviTipPodatakaIznos
            // 
            this.lblKriviTipPodatakaIznos.AutoSize = true;
            this.lblKriviTipPodatakaIznos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKriviTipPodatakaIznos.ForeColor = System.Drawing.Color.Red;
            this.lblKriviTipPodatakaIznos.Location = new System.Drawing.Point(206, 554);
            this.lblKriviTipPodatakaIznos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKriviTipPodatakaIznos.Name = "lblKriviTipPodatakaIznos";
            this.lblKriviTipPodatakaIznos.Size = new System.Drawing.Size(211, 21);
            this.lblKriviTipPodatakaIznos.TabIndex = 11;
            this.lblKriviTipPodatakaIznos.Text = "Unijeli ste krivi tip podataka";
            this.lblKriviTipPodatakaIznos.Visible = false;
            // 
            // lblKriviTipPodatakaKolicina
            // 
            this.lblKriviTipPodatakaKolicina.AutoSize = true;
            this.lblKriviTipPodatakaKolicina.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKriviTipPodatakaKolicina.ForeColor = System.Drawing.Color.Red;
            this.lblKriviTipPodatakaKolicina.Location = new System.Drawing.Point(206, 482);
            this.lblKriviTipPodatakaKolicina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKriviTipPodatakaKolicina.Name = "lblKriviTipPodatakaKolicina";
            this.lblKriviTipPodatakaKolicina.Size = new System.Drawing.Size(211, 21);
            this.lblKriviTipPodatakaKolicina.TabIndex = 11;
            this.lblKriviTipPodatakaKolicina.Text = "Unijeli ste krivi tip podataka";
            this.lblKriviTipPodatakaKolicina.Visible = false;
            // 
            // cboNazivInvesticije
            // 
            this.cboNazivInvesticije.DataSource = this.investicijaBindingSource;
            this.cboNazivInvesticije.DisplayMember = "naziv_investicije";
            this.cboNazivInvesticije.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cboNazivInvesticije.FormattingEnabled = true;
            this.cboNazivInvesticije.Location = new System.Drawing.Point(200, 194);
            this.cboNazivInvesticije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNazivInvesticije.Name = "cboNazivInvesticije";
            this.cboNazivInvesticije.Size = new System.Drawing.Size(206, 29);
            this.cboNazivInvesticije.TabIndex = 2;
            this.cboNazivInvesticije.ValueMember = "id_investicije";
            this.cboNazivInvesticije.SelectedIndexChanged += new System.EventHandler(this.cBoxNazivInvesticije_SelectedIndexChanged);
            // 
            // investicijaBindingSource
            // 
            this.investicijaBindingSource.DataSource = typeof(PocetniZaslon.Investicija);
            // 
            // cboBankovniRačun
            // 
            this.cboBankovniRačun.DataSource = this.bankovniracunBindingSource;
            this.cboBankovniRačun.DisplayMember = "naziv_racuna";
            this.cboBankovniRačun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cboBankovniRačun.FormattingEnabled = true;
            this.cboBankovniRačun.Location = new System.Drawing.Point(200, 365);
            this.cboBankovniRačun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBankovniRačun.Name = "cboBankovniRačun";
            this.cboBankovniRačun.Size = new System.Drawing.Size(206, 29);
            this.cboBankovniRačun.TabIndex = 4;
            this.cboBankovniRačun.ValueMember = "iban";
            // 
            // bankovniracunBindingSource
            // 
            this.bankovniracunBindingSource.DataSource = typeof(PocetniZaslon.Bankovni_racun);
            // 
            // dtpDatum
            // 
            this.dtpDatum.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Location = new System.Drawing.Point(200, 272);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(206, 29);
            this.dtpDatum.TabIndex = 3;
            // 
            // txtIznosTransInv
            // 
            this.txtIznosTransInv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIznosTransInv.Location = new System.Drawing.Point(200, 524);
            this.txtIznosTransInv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIznosTransInv.Name = "txtIznosTransInv";
            this.txtIznosTransInv.Size = new System.Drawing.Size(206, 29);
            this.txtIznosTransInv.TabIndex = 6;
            this.txtIznosTransInv.TextChanged += new System.EventHandler(this.txtBoxIznosTransInv_TextChanged);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtKolicina.Location = new System.Drawing.Point(200, 452);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(206, 29);
            this.txtKolicina.TabIndex = 5;
            this.txtKolicina.TextChanged += new System.EventHandler(this.txtBoxKolicina_TextChanged);
            // 
            // btnIzvrsiTransakciju
            // 
            this.btnIzvrsiTransakciju.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIzvrsiTransakciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvrsiTransakciju.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnIzvrsiTransakciju.ForeColor = System.Drawing.Color.White;
            this.btnIzvrsiTransakciju.Location = new System.Drawing.Point(96, 618);
            this.btnIzvrsiTransakciju.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzvrsiTransakciju.Name = "btnIzvrsiTransakciju";
            this.btnIzvrsiTransakciju.Size = new System.Drawing.Size(302, 41);
            this.btnIzvrsiTransakciju.TabIndex = 7;
            this.btnIzvrsiTransakciju.Text = "Izvrši transakciju";
            this.btnIzvrsiTransakciju.UseVisualStyleBackColor = false;
            this.btnIzvrsiTransakciju.Click += new System.EventHandler(this.btnIzvrsiTransakciju_Click);
            // 
            // rBtnProdaj
            // 
            this.rBtnProdaj.AutoSize = true;
            this.rBtnProdaj.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.rBtnProdaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rBtnProdaj.Location = new System.Drawing.Point(266, 76);
            this.rBtnProdaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtnProdaj.Name = "rBtnProdaj";
            this.rBtnProdaj.Size = new System.Drawing.Size(99, 34);
            this.rBtnProdaj.TabIndex = 1;
            this.rBtnProdaj.TabStop = true;
            this.rBtnProdaj.Text = "Prodaj";
            this.rBtnProdaj.UseVisualStyleBackColor = true;
            // 
            // rBtnKupi
            // 
            this.rBtnKupi.AutoSize = true;
            this.rBtnKupi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.rBtnKupi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rBtnKupi.Location = new System.Drawing.Point(87, 76);
            this.rBtnKupi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtnKupi.Name = "rBtnKupi";
            this.rBtnKupi.Size = new System.Drawing.Size(78, 34);
            this.rBtnKupi.TabIndex = 0;
            this.rBtnKupi.TabStop = true;
            this.rBtnKupi.Text = "Kupi";
            this.rBtnKupi.UseVisualStyleBackColor = true;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblIznos.Location = new System.Drawing.Point(104, 524);
            this.lblIznos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(54, 21);
            this.lblIznos.TabIndex = 3;
            this.lblIznos.Text = "Iznos:";
            // 
            // lblBankovniRacun
            // 
            this.lblBankovniRacun.AutoSize = true;
            this.lblBankovniRacun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBankovniRacun.Location = new System.Drawing.Point(30, 367);
            this.lblBankovniRacun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankovniRacun.Name = "lblBankovniRacun";
            this.lblBankovniRacun.Size = new System.Drawing.Size(133, 21);
            this.lblBankovniRacun.TabIndex = 3;
            this.lblBankovniRacun.Text = "Bankovni račun:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDatum.Location = new System.Drawing.Point(92, 276);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(66, 21);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "Datum:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblKolicina.Location = new System.Drawing.Point(87, 454);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(72, 21);
            this.lblKolicina.TabIndex = 3;
            this.lblKolicina.Text = "Količina";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNaziv.Location = new System.Drawing.Point(100, 197);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(58, 21);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Naziv:";
            // 
            // vrstainvesticijeBindingSource
            // 
            this.vrstainvesticijeBindingSource.DataSource = typeof(PocetniZaslon.Vrsta_investicije);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(21, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Moje investicije:";
            // 
            // dgvVlastiteInvesticije
            // 
            this.dgvVlastiteInvesticije.AllowUserToAddRows = false;
            this.dgvVlastiteInvesticije.AllowUserToDeleteRows = false;
            this.dgvVlastiteInvesticije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVlastiteInvesticije.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvVlastiteInvesticije.BackgroundColor = System.Drawing.Color.White;
            this.dgvVlastiteInvesticije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVlastiteInvesticije.Location = new System.Drawing.Point(26, 205);
            this.dgvVlastiteInvesticije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvVlastiteInvesticije.Name = "dgvVlastiteInvesticije";
            this.dgvVlastiteInvesticije.ReadOnly = true;
            this.dgvVlastiteInvesticije.RowTemplate.Height = 24;
            this.dgvVlastiteInvesticije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVlastiteInvesticije.Size = new System.Drawing.Size(734, 526);
            this.dgvVlastiteInvesticije.TabIndex = 10;
            // 
            // stanjeinvesticijeBindingSource
            // 
            this.stanjeinvesticijeBindingSource.DataSource = typeof(PocetniZaslon.Stanje_investicije);
            // 
            // transakcijainvesticijeBindingSource
            // 
            this.transakcijainvesticijeBindingSource.DataSource = typeof(PocetniZaslon.Transakcija_investicije);
            // 
            // bankovniracunBindingSource1
            // 
            this.bankovniracunBindingSource1.DataSource = typeof(PocetniZaslon.Bankovni_racun);
            // 
            // vrstainvesticijeBindingSource1
            // 
            this.vrstainvesticijeBindingSource1.DataSource = typeof(PocetniZaslon.Vrsta_investicije);
            // 
            // btnDohvati
            // 
            this.btnDohvati.BackColor = System.Drawing.Color.White;
            this.btnDohvati.FlatAppearance.BorderSize = 2;
            this.btnDohvati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDohvati.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDohvati.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDohvati.Location = new System.Drawing.Point(632, 97);
            this.btnDohvati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDohvati.Name = "btnDohvati";
            this.btnDohvati.Size = new System.Drawing.Size(128, 75);
            this.btnDohvati.TabIndex = 11;
            this.btnDohvati.Text = "Dohvati današnja stanja";
            this.btnDohvati.UseVisualStyleBackColor = false;
            this.btnDohvati.Click += new System.EventHandler(this.btnDohvati_Click);
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblTekst.Location = new System.Drawing.Point(505, 188);
            this.lblTekst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(255, 13);
            this.lblTekst.TabIndex = 12;
            this.lblTekst.Text = "Vrijednosti dionica za današnji dan su dohvaćene";
            // 
            // FrmInvesticijskiPortfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 770);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.btnDohvati);
            this.Controls.Add(this.dgvVlastiteInvesticije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBoxTransakcija);
            this.Controls.Add(this.lblInvesticijskiPortfolio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmInvesticijskiPortfolio";
            this.Text = "2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInvesticijskiPortfolio_FormClosing);
            this.Load += new System.EventHandler(this.FrmInvesticijskiPortfolio_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmInvesticijskiPortfolio_HelpRequested);
            this.gBoxTransakcija.ResumeLayout(false);
            this.gBoxTransakcija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.investicijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstainvesticijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVlastiteInvesticije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeinvesticijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijainvesticijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstainvesticijeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblInvesticijskiPortfolio;
		private System.Windows.Forms.GroupBox gBoxTransakcija;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.RadioButton rBtnProdaj;
		private System.Windows.Forms.RadioButton rBtnKupi;
		private System.Windows.Forms.Label lblIznos;
		private System.Windows.Forms.Label lblBankovniRacun;
		private System.Windows.Forms.Label lblDatum;
		private System.Windows.Forms.Label lblKolicina;
		private System.Windows.Forms.Label lblNaziv;
		private System.Windows.Forms.ComboBox cboBankovniRačun;
		private System.Windows.Forms.DateTimePicker dtpDatum;
		private System.Windows.Forms.TextBox txtKolicina;
		private System.Windows.Forms.Button btnIzvrsiTransakciju;
		private System.Windows.Forms.BindingSource bankovniracunBindingSource;
		private System.Windows.Forms.BindingSource bankovniracunBindingSource1;
		private System.Windows.Forms.BindingSource vrstainvesticijeBindingSource;
		private System.Windows.Forms.ComboBox cboNazivInvesticije;
		private System.Windows.Forms.BindingSource investicijaBindingSource;
		private System.Windows.Forms.TextBox txtIznosTransInv;
		private System.Windows.Forms.BindingSource transakcijainvesticijeBindingSource;
		private System.Windows.Forms.BindingSource vrstainvesticijeBindingSource1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvVlastiteInvesticije;
		private System.Windows.Forms.BindingSource stanjeinvesticijeBindingSource;
		private System.Windows.Forms.Label lblKriviTipPodatakaKolicina;
		private System.Windows.Forms.Label lblKriviTipPodatakaIznos;
		private System.Windows.Forms.Button btnDohvati;
		private System.Windows.Forms.Label lblTekst;
	}
}