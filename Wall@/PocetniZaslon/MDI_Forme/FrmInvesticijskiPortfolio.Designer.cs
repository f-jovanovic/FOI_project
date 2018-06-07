namespace PocetniZaslon.MDI_Forme
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
			this.cBoxNazivInvesticije = new System.Windows.Forms.ComboBox();
			this.investicijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBoxBankovniRačun = new System.Windows.Forms.ComboBox();
			this.bankovniracunBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dateDatum = new System.Windows.Forms.DateTimePicker();
			this.txtBoxIznosTransInv = new System.Windows.Forms.TextBox();
			this.txtBoxKolicina = new System.Windows.Forms.TextBox();
			this.btnIzvrsiTransakciju = new System.Windows.Forms.Button();
			this.rBtnProdaj = new System.Windows.Forms.RadioButton();
			this.rBtnKupi = new System.Windows.Forms.RadioButton();
			this.lblIznos = new System.Windows.Forms.Label();
			this.lblBankovniRacun = new System.Windows.Forms.Label();
			this.lblDatum = new System.Windows.Forms.Label();
			this.lblKolicina = new System.Windows.Forms.Label();
			this.lblNaziv = new System.Windows.Forms.Label();
			this.transakcijainvesticijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.btnObrisiInvesticiju = new System.Windows.Forms.Button();
			this.cBoxVrstaInvesticije = new System.Windows.Forms.ComboBox();
			this.vrstainvesticijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.txtBoxNazivInvesticije = new System.Windows.Forms.TextBox();
			this.lblVrstaInvesticije = new System.Windows.Forms.Label();
			this.lblNazivInvesticije = new System.Windows.Forms.Label();
			this.btnDodajInvesticiju = new System.Windows.Forms.Button();
			this.bankovniracunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.vrstainvesticijeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.dgwVlastiteInvesticije = new System.Windows.Forms.DataGridView();
			this.stanjeinvesticijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idstanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idinvesticijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vrijednostinvesticijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vrijemestanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.investicijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gBoxTransakcija.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.investicijaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transakcijainvesticijeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vrstainvesticijeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vrstainvesticijeBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgwVlastiteInvesticije)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stanjeinvesticijeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblInvesticijskiPortfolio
			// 
			this.lblInvesticijskiPortfolio.AutoSize = true;
			this.lblInvesticijskiPortfolio.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
			this.lblInvesticijskiPortfolio.Location = new System.Drawing.Point(485, 20);
			this.lblInvesticijskiPortfolio.Name = "lblInvesticijskiPortfolio";
			this.lblInvesticijskiPortfolio.Size = new System.Drawing.Size(492, 62);
			this.lblInvesticijskiPortfolio.TabIndex = 0;
			this.lblInvesticijskiPortfolio.Text = "Investicijski portfolio";
			// 
			// gBoxTransakcija
			// 
			this.gBoxTransakcija.Controls.Add(this.cBoxNazivInvesticije);
			this.gBoxTransakcija.Controls.Add(this.comboBoxBankovniRačun);
			this.gBoxTransakcija.Controls.Add(this.dateDatum);
			this.gBoxTransakcija.Controls.Add(this.txtBoxIznosTransInv);
			this.gBoxTransakcija.Controls.Add(this.txtBoxKolicina);
			this.gBoxTransakcija.Controls.Add(this.btnIzvrsiTransakciju);
			this.gBoxTransakcija.Controls.Add(this.rBtnProdaj);
			this.gBoxTransakcija.Controls.Add(this.rBtnKupi);
			this.gBoxTransakcija.Controls.Add(this.lblIznos);
			this.gBoxTransakcija.Controls.Add(this.lblBankovniRacun);
			this.gBoxTransakcija.Controls.Add(this.lblDatum);
			this.gBoxTransakcija.Controls.Add(this.lblKolicina);
			this.gBoxTransakcija.Controls.Add(this.lblNaziv);
			this.gBoxTransakcija.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.gBoxTransakcija.Location = new System.Drawing.Point(1024, 119);
			this.gBoxTransakcija.Name = "gBoxTransakcija";
			this.gBoxTransakcija.Size = new System.Drawing.Size(604, 817);
			this.gBoxTransakcija.TabIndex = 1;
			this.gBoxTransakcija.TabStop = false;
			this.gBoxTransakcija.Text = "Transakcija";
			// 
			// cBoxNazivInvesticije
			// 
			this.cBoxNazivInvesticije.DataSource = this.investicijaBindingSource;
			this.cBoxNazivInvesticije.DisplayMember = "naziv_investicije";
			this.cBoxNazivInvesticije.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.cBoxNazivInvesticije.FormattingEnabled = true;
			this.cBoxNazivInvesticije.Location = new System.Drawing.Point(267, 239);
			this.cBoxNazivInvesticije.Name = "cBoxNazivInvesticije";
			this.cBoxNazivInvesticije.Size = new System.Drawing.Size(273, 36);
			this.cBoxNazivInvesticije.TabIndex = 9;
			this.cBoxNazivInvesticije.ValueMember = "id_investicije";
			// 
			// investicijaBindingSource
			// 
			this.investicijaBindingSource.DataSource = typeof(PocetniZaslon.Investicija);
			// 
			// comboBoxBankovniRačun
			// 
			this.comboBoxBankovniRačun.DataSource = this.bankovniracunBindingSource;
			this.comboBoxBankovniRačun.DisplayMember = "naziv_racuna";
			this.comboBoxBankovniRačun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.comboBoxBankovniRačun.FormattingEnabled = true;
			this.comboBoxBankovniRačun.Location = new System.Drawing.Point(267, 449);
			this.comboBoxBankovniRačun.Name = "comboBoxBankovniRačun";
			this.comboBoxBankovniRačun.Size = new System.Drawing.Size(274, 36);
			this.comboBoxBankovniRačun.TabIndex = 8;
			this.comboBoxBankovniRačun.ValueMember = "iban";
			// 
			// bankovniracunBindingSource
			// 
			this.bankovniracunBindingSource.DataSource = typeof(PocetniZaslon.Bankovni_racun);
			// 
			// dateDatum
			// 
			this.dateDatum.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateDatum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateDatum.Location = new System.Drawing.Point(267, 335);
			this.dateDatum.Name = "dateDatum";
			this.dateDatum.Size = new System.Drawing.Size(274, 34);
			this.dateDatum.TabIndex = 7;
			// 
			// txtBoxIznosTransInv
			// 
			this.txtBoxIznosTransInv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBoxIznosTransInv.Location = new System.Drawing.Point(266, 654);
			this.txtBoxIznosTransInv.Name = "txtBoxIznosTransInv";
			this.txtBoxIznosTransInv.Size = new System.Drawing.Size(274, 34);
			this.txtBoxIznosTransInv.TabIndex = 6;
			// 
			// txtBoxKolicina
			// 
			this.txtBoxKolicina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.txtBoxKolicina.Location = new System.Drawing.Point(267, 556);
			this.txtBoxKolicina.Name = "txtBoxKolicina";
			this.txtBoxKolicina.Size = new System.Drawing.Size(274, 34);
			this.txtBoxKolicina.TabIndex = 6;
			// 
			// btnIzvrsiTransakciju
			// 
			this.btnIzvrsiTransakciju.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.btnIzvrsiTransakciju.Location = new System.Drawing.Point(128, 747);
			this.btnIzvrsiTransakciju.Name = "btnIzvrsiTransakciju";
			this.btnIzvrsiTransakciju.Size = new System.Drawing.Size(402, 50);
			this.btnIzvrsiTransakciju.TabIndex = 5;
			this.btnIzvrsiTransakciju.Text = "Izvrši transakciju";
			this.btnIzvrsiTransakciju.UseVisualStyleBackColor = true;
			this.btnIzvrsiTransakciju.Click += new System.EventHandler(this.btnIzvrsiTransakciju_Click);
			// 
			// rBtnProdaj
			// 
			this.rBtnProdaj.AutoSize = true;
			this.rBtnProdaj.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.rBtnProdaj.Location = new System.Drawing.Point(354, 93);
			this.rBtnProdaj.Name = "rBtnProdaj";
			this.rBtnProdaj.Size = new System.Drawing.Size(123, 41);
			this.rBtnProdaj.TabIndex = 4;
			this.rBtnProdaj.TabStop = true;
			this.rBtnProdaj.Text = "Prodaj";
			this.rBtnProdaj.UseVisualStyleBackColor = true;
			// 
			// rBtnKupi
			// 
			this.rBtnKupi.AutoSize = true;
			this.rBtnKupi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.rBtnKupi.Location = new System.Drawing.Point(116, 93);
			this.rBtnKupi.Name = "rBtnKupi";
			this.rBtnKupi.Size = new System.Drawing.Size(97, 41);
			this.rBtnKupi.TabIndex = 4;
			this.rBtnKupi.TabStop = true;
			this.rBtnKupi.Text = "Kupi";
			this.rBtnKupi.UseVisualStyleBackColor = true;
			this.rBtnKupi.CheckedChanged += new System.EventHandler(this.rBtnKupi_CheckedChanged);
			// 
			// lblIznos
			// 
			this.lblIznos.AutoSize = true;
			this.lblIznos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblIznos.Location = new System.Drawing.Point(138, 657);
			this.lblIznos.Name = "lblIznos";
			this.lblIznos.Size = new System.Drawing.Size(66, 28);
			this.lblIznos.TabIndex = 3;
			this.lblIznos.Text = "Iznos:";
			// 
			// lblBankovniRacun
			// 
			this.lblBankovniRacun.AutoSize = true;
			this.lblBankovniRacun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblBankovniRacun.Location = new System.Drawing.Point(40, 452);
			this.lblBankovniRacun.Name = "lblBankovniRacun";
			this.lblBankovniRacun.Size = new System.Drawing.Size(164, 28);
			this.lblBankovniRacun.TabIndex = 3;
			this.lblBankovniRacun.Text = "Bankovni račun:";
			// 
			// lblDatum
			// 
			this.lblDatum.AutoSize = true;
			this.lblDatum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblDatum.Location = new System.Drawing.Point(123, 340);
			this.lblDatum.Name = "lblDatum";
			this.lblDatum.Size = new System.Drawing.Size(81, 28);
			this.lblDatum.TabIndex = 3;
			this.lblDatum.Text = "Datum:";
			// 
			// lblKolicina
			// 
			this.lblKolicina.AutoSize = true;
			this.lblKolicina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblKolicina.Location = new System.Drawing.Point(116, 559);
			this.lblKolicina.Name = "lblKolicina";
			this.lblKolicina.Size = new System.Drawing.Size(88, 28);
			this.lblKolicina.TabIndex = 3;
			this.lblKolicina.Text = "Količina";
			// 
			// lblNaziv
			// 
			this.lblNaziv.AutoSize = true;
			this.lblNaziv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblNaziv.Location = new System.Drawing.Point(133, 242);
			this.lblNaziv.Name = "lblNaziv";
			this.lblNaziv.Size = new System.Drawing.Size(71, 28);
			this.lblNaziv.TabIndex = 3;
			this.lblNaziv.Text = "Naziv:";
			// 
			// transakcijainvesticijeBindingSource
			// 
			this.transakcijainvesticijeBindingSource.DataSource = typeof(PocetniZaslon.Transakcija_investicije);
			// 
			// btnObrisiInvesticiju
			// 
			this.btnObrisiInvesticiju.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObrisiInvesticiju.Location = new System.Drawing.Point(706, 817);
			this.btnObrisiInvesticiju.Name = "btnObrisiInvesticiju";
			this.btnObrisiInvesticiju.Size = new System.Drawing.Size(144, 70);
			this.btnObrisiInvesticiju.TabIndex = 8;
			this.btnObrisiInvesticiju.Text = "Obriši investiciju";
			this.btnObrisiInvesticiju.UseVisualStyleBackColor = true;
			this.btnObrisiInvesticiju.Click += new System.EventHandler(this.btnObrisiInvesticiju_Click);
			// 
			// cBoxVrstaInvesticije
			// 
			this.cBoxVrstaInvesticije.DataSource = this.vrstainvesticijeBindingSource;
			this.cBoxVrstaInvesticije.DisplayMember = "naziv_vrste_investicije";
			this.cBoxVrstaInvesticije.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.cBoxVrstaInvesticije.FormattingEnabled = true;
			this.cBoxVrstaInvesticije.Location = new System.Drawing.Point(336, 835);
			this.cBoxVrstaInvesticije.Name = "cBoxVrstaInvesticije";
			this.cBoxVrstaInvesticije.Size = new System.Drawing.Size(225, 36);
			this.cBoxVrstaInvesticije.TabIndex = 7;
			this.cBoxVrstaInvesticije.ValueMember = "id_vrsta_investicije";
			// 
			// vrstainvesticijeBindingSource
			// 
			this.vrstainvesticijeBindingSource.DataSource = typeof(PocetniZaslon.Vrsta_investicije);
			// 
			// txtBoxNazivInvesticije
			// 
			this.txtBoxNazivInvesticije.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.txtBoxNazivInvesticije.Location = new System.Drawing.Point(336, 732);
			this.txtBoxNazivInvesticije.Name = "txtBoxNazivInvesticije";
			this.txtBoxNazivInvesticije.Size = new System.Drawing.Size(225, 34);
			this.txtBoxNazivInvesticije.TabIndex = 6;
			// 
			// lblVrstaInvesticije
			// 
			this.lblVrstaInvesticije.AutoSize = true;
			this.lblVrstaInvesticije.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblVrstaInvesticije.Location = new System.Drawing.Point(102, 838);
			this.lblVrstaInvesticije.Name = "lblVrstaInvesticije";
			this.lblVrstaInvesticije.Size = new System.Drawing.Size(167, 28);
			this.lblVrstaInvesticije.TabIndex = 5;
			this.lblVrstaInvesticije.Text = "Vrsta investicije:";
			// 
			// lblNazivInvesticije
			// 
			this.lblNazivInvesticije.AutoSize = true;
			this.lblNazivInvesticije.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblNazivInvesticije.Location = new System.Drawing.Point(102, 732);
			this.lblNazivInvesticije.Name = "lblNazivInvesticije";
			this.lblNazivInvesticije.Size = new System.Drawing.Size(173, 28);
			this.lblNazivInvesticije.TabIndex = 5;
			this.lblNazivInvesticije.Text = "Naziv investicije:";
			// 
			// btnDodajInvesticiju
			// 
			this.btnDodajInvesticiju.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDodajInvesticiju.Location = new System.Drawing.Point(706, 714);
			this.btnDodajInvesticiju.Name = "btnDodajInvesticiju";
			this.btnDodajInvesticiju.Size = new System.Drawing.Size(144, 70);
			this.btnDodajInvesticiju.TabIndex = 4;
			this.btnDodajInvesticiju.Text = "Dodaj investiciju";
			this.btnDodajInvesticiju.UseVisualStyleBackColor = true;
			this.btnDodajInvesticiju.Click += new System.EventHandler(this.btnDodajInvesticiju_Click);
			// 
			// bankovniracunBindingSource1
			// 
			this.bankovniracunBindingSource1.DataSource = typeof(PocetniZaslon.Bankovni_racun);
			// 
			// vrstainvesticijeBindingSource1
			// 
			this.vrstainvesticijeBindingSource1.DataSource = typeof(PocetniZaslon.Vrsta_investicije);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(28, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(247, 41);
			this.label1.TabIndex = 9;
			this.label1.Text = "Moje investicije:";
			// 
			// dgwVlastiteInvesticije
			// 
			this.dgwVlastiteInvesticije.AutoGenerateColumns = false;
			this.dgwVlastiteInvesticije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwVlastiteInvesticije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstanjaDataGridViewTextBoxColumn,
            this.idinvesticijeDataGridViewTextBoxColumn,
            this.vrijednostinvesticijeDataGridViewTextBoxColumn,
            this.vrijemestanjaDataGridViewTextBoxColumn,
            this.investicijaDataGridViewTextBoxColumn});
			this.dgwVlastiteInvesticije.DataSource = this.stanjeinvesticijeBindingSource;
			this.dgwVlastiteInvesticije.Location = new System.Drawing.Point(29, 197);
			this.dgwVlastiteInvesticije.Name = "dgwVlastiteInvesticije";
			this.dgwVlastiteInvesticije.RowTemplate.Height = 24;
			this.dgwVlastiteInvesticije.Size = new System.Drawing.Size(979, 509);
			this.dgwVlastiteInvesticije.TabIndex = 10;
			// 
			// stanjeinvesticijeBindingSource
			// 
			this.stanjeinvesticijeBindingSource.DataSource = typeof(PocetniZaslon.Stanje_investicije);
			// 
			// idstanjaDataGridViewTextBoxColumn
			// 
			this.idstanjaDataGridViewTextBoxColumn.DataPropertyName = "id_stanja";
			this.idstanjaDataGridViewTextBoxColumn.HeaderText = "id_stanja";
			this.idstanjaDataGridViewTextBoxColumn.Name = "idstanjaDataGridViewTextBoxColumn";
			// 
			// idinvesticijeDataGridViewTextBoxColumn
			// 
			this.idinvesticijeDataGridViewTextBoxColumn.DataPropertyName = "id_investicije";
			this.idinvesticijeDataGridViewTextBoxColumn.HeaderText = "id_investicije";
			this.idinvesticijeDataGridViewTextBoxColumn.Name = "idinvesticijeDataGridViewTextBoxColumn";
			// 
			// vrijednostinvesticijeDataGridViewTextBoxColumn
			// 
			this.vrijednostinvesticijeDataGridViewTextBoxColumn.DataPropertyName = "vrijednost_investicije";
			this.vrijednostinvesticijeDataGridViewTextBoxColumn.HeaderText = "vrijednost_investicije";
			this.vrijednostinvesticijeDataGridViewTextBoxColumn.Name = "vrijednostinvesticijeDataGridViewTextBoxColumn";
			// 
			// vrijemestanjaDataGridViewTextBoxColumn
			// 
			this.vrijemestanjaDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_stanja";
			this.vrijemestanjaDataGridViewTextBoxColumn.HeaderText = "vrijeme_stanja";
			this.vrijemestanjaDataGridViewTextBoxColumn.Name = "vrijemestanjaDataGridViewTextBoxColumn";
			// 
			// investicijaDataGridViewTextBoxColumn
			// 
			this.investicijaDataGridViewTextBoxColumn.DataPropertyName = "Investicija";
			this.investicijaDataGridViewTextBoxColumn.HeaderText = "Investicija";
			this.investicijaDataGridViewTextBoxColumn.Name = "investicijaDataGridViewTextBoxColumn";
			// 
			// FrmInvesticijskiPortfolio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1640, 948);
			this.Controls.Add(this.dgwVlastiteInvesticije);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnObrisiInvesticiju);
			this.Controls.Add(this.cBoxVrstaInvesticije);
			this.Controls.Add(this.gBoxTransakcija);
			this.Controls.Add(this.txtBoxNazivInvesticije);
			this.Controls.Add(this.lblInvesticijskiPortfolio);
			this.Controls.Add(this.lblVrstaInvesticije);
			this.Controls.Add(this.btnDodajInvesticiju);
			this.Controls.Add(this.lblNazivInvesticije);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmInvesticijskiPortfolio";
			this.Text = "FrmInvesticijskiPortfolio";
			this.Load += new System.EventHandler(this.FrmInvesticijskiPortfolio_Load);
			this.gBoxTransakcija.ResumeLayout(false);
			this.gBoxTransakcija.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.investicijaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transakcijainvesticijeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vrstainvesticijeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vrstainvesticijeBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgwVlastiteInvesticije)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stanjeinvesticijeBindingSource)).EndInit();
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
		private System.Windows.Forms.ComboBox comboBoxBankovniRačun;
		private System.Windows.Forms.DateTimePicker dateDatum;
		private System.Windows.Forms.TextBox txtBoxKolicina;
		private System.Windows.Forms.Button btnIzvrsiTransakciju;
		private System.Windows.Forms.BindingSource bankovniracunBindingSource;
		private System.Windows.Forms.BindingSource bankovniracunBindingSource1;
		private System.Windows.Forms.Label lblNazivInvesticije;
		private System.Windows.Forms.Button btnDodajInvesticiju;
		private System.Windows.Forms.TextBox txtBoxNazivInvesticije;
		private System.Windows.Forms.Label lblVrstaInvesticije;
		private System.Windows.Forms.ComboBox cBoxVrstaInvesticije;
		private System.Windows.Forms.BindingSource vrstainvesticijeBindingSource;
		private System.Windows.Forms.ComboBox cBoxNazivInvesticije;
		private System.Windows.Forms.BindingSource investicijaBindingSource;
		private System.Windows.Forms.TextBox txtBoxIznosTransInv;
		private System.Windows.Forms.BindingSource transakcijainvesticijeBindingSource;
		private System.Windows.Forms.Button btnObrisiInvesticiju;
		private System.Windows.Forms.BindingSource vrstainvesticijeBindingSource1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgwVlastiteInvesticije;
		private System.Windows.Forms.DataGridViewTextBoxColumn idstanjaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idinvesticijeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn vrijednostinvesticijeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn vrijemestanjaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn investicijaDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource stanjeinvesticijeBindingSource;
	}
}