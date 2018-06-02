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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
			this.gBoxMojeInvesticije = new System.Windows.Forms.GroupBox();
			this.btnObrisiInvesticiju = new System.Windows.Forms.Button();
			this.cBoxVrstaInvesticije = new System.Windows.Forms.ComboBox();
			this.vrstainvesticijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.txtBoxNazivInvesticije = new System.Windows.Forms.TextBox();
			this.lblVrstaInvesticije = new System.Windows.Forms.Label();
			this.lblNazivInvesticije = new System.Windows.Forms.Label();
			this.btnDodajInvesticiju = new System.Windows.Forms.Button();
			this.gBoxInvesticije = new System.Windows.Forms.GroupBox();
			this.lblPrikazKretVrj1 = new System.Windows.Forms.Label();
			this.lblPrikazUkVrj1 = new System.Windows.Forms.Label();
			this.lblPrikazVrj1 = new System.Windows.Forms.Label();
			this.lblPrikazKol = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lblKretanjeVrijednosti1 = new System.Windows.Forms.Label();
			this.lblKolicina1 = new System.Windows.Forms.Label();
			this.lblUkupnaVrijednost1 = new System.Windows.Forms.Label();
			this.lblVrijednost1 = new System.Windows.Forms.Label();
			this.gBoxInvesticije2 = new System.Windows.Forms.GroupBox();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lblKretanjeVrijednosti2 = new System.Windows.Forms.Label();
			this.lblKolicinaInvest2 = new System.Windows.Forms.Label();
			this.lblUkupnaVrijednost2 = new System.Windows.Forms.Label();
			this.lblVrijednostInvest2 = new System.Windows.Forms.Label();
			this.bankovniracunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.gBoxTransakcija.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.investicijaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transakcijainvesticijeBindingSource)).BeginInit();
			this.gBoxMojeInvesticije.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vrstainvesticijeBindingSource)).BeginInit();
			this.gBoxInvesticije.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.gBoxInvesticije2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource1)).BeginInit();
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
			// gBoxMojeInvesticije
			// 
			this.gBoxMojeInvesticije.Controls.Add(this.btnObrisiInvesticiju);
			this.gBoxMojeInvesticije.Controls.Add(this.cBoxVrstaInvesticije);
			this.gBoxMojeInvesticije.Controls.Add(this.txtBoxNazivInvesticije);
			this.gBoxMojeInvesticije.Controls.Add(this.lblVrstaInvesticije);
			this.gBoxMojeInvesticije.Controls.Add(this.lblNazivInvesticije);
			this.gBoxMojeInvesticije.Controls.Add(this.btnDodajInvesticiju);
			this.gBoxMojeInvesticije.Controls.Add(this.gBoxInvesticije);
			this.gBoxMojeInvesticije.Controls.Add(this.gBoxInvesticije2);
			this.gBoxMojeInvesticije.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.gBoxMojeInvesticije.Location = new System.Drawing.Point(1, 119);
			this.gBoxMojeInvesticije.Name = "gBoxMojeInvesticije";
			this.gBoxMojeInvesticije.Size = new System.Drawing.Size(990, 817);
			this.gBoxMojeInvesticije.TabIndex = 2;
			this.gBoxMojeInvesticije.TabStop = false;
			this.gBoxMojeInvesticije.Text = "Moje investicije";
			// 
			// btnObrisiInvesticiju
			// 
			this.btnObrisiInvesticiju.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnObrisiInvesticiju.Location = new System.Drawing.Point(805, 695);
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
			this.cBoxVrstaInvesticije.Location = new System.Drawing.Point(334, 729);
			this.cBoxVrstaInvesticije.Name = "cBoxVrstaInvesticije";
			this.cBoxVrstaInvesticije.Size = new System.Drawing.Size(198, 36);
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
			this.txtBoxNazivInvesticije.Location = new System.Drawing.Point(22, 729);
			this.txtBoxNazivInvesticije.Name = "txtBoxNazivInvesticije";
			this.txtBoxNazivInvesticije.Size = new System.Drawing.Size(225, 34);
			this.txtBoxNazivInvesticije.TabIndex = 6;
			// 
			// lblVrstaInvesticije
			// 
			this.lblVrstaInvesticije.AutoSize = true;
			this.lblVrstaInvesticije.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblVrstaInvesticije.Location = new System.Drawing.Point(329, 693);
			this.lblVrstaInvesticije.Name = "lblVrstaInvesticije";
			this.lblVrstaInvesticije.Size = new System.Drawing.Size(167, 28);
			this.lblVrstaInvesticije.TabIndex = 5;
			this.lblVrstaInvesticije.Text = "Vrsta investicije:";
			// 
			// lblNazivInvesticije
			// 
			this.lblNazivInvesticije.AutoSize = true;
			this.lblNazivInvesticije.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblNazivInvesticije.Location = new System.Drawing.Point(28, 691);
			this.lblNazivInvesticije.Name = "lblNazivInvesticije";
			this.lblNazivInvesticije.Size = new System.Drawing.Size(173, 28);
			this.lblNazivInvesticije.TabIndex = 5;
			this.lblNazivInvesticije.Text = "Naziv investicije:";
			// 
			// btnDodajInvesticiju
			// 
			this.btnDodajInvesticiju.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDodajInvesticiju.Location = new System.Drawing.Point(629, 695);
			this.btnDodajInvesticiju.Name = "btnDodajInvesticiju";
			this.btnDodajInvesticiju.Size = new System.Drawing.Size(144, 70);
			this.btnDodajInvesticiju.TabIndex = 4;
			this.btnDodajInvesticiju.Text = "Dodaj investiciju";
			this.btnDodajInvesticiju.UseVisualStyleBackColor = true;
			this.btnDodajInvesticiju.Click += new System.EventHandler(this.btnDodajInvesticiju_Click);
			// 
			// gBoxInvesticije
			// 
			this.gBoxInvesticije.Controls.Add(this.lblPrikazKretVrj1);
			this.gBoxInvesticije.Controls.Add(this.lblPrikazUkVrj1);
			this.gBoxInvesticije.Controls.Add(this.lblPrikazVrj1);
			this.gBoxInvesticije.Controls.Add(this.lblPrikazKol);
			this.gBoxInvesticije.Controls.Add(this.chart1);
			this.gBoxInvesticije.Controls.Add(this.lblKretanjeVrijednosti1);
			this.gBoxInvesticije.Controls.Add(this.lblKolicina1);
			this.gBoxInvesticije.Controls.Add(this.lblUkupnaVrijednost1);
			this.gBoxInvesticije.Controls.Add(this.lblVrijednost1);
			this.gBoxInvesticije.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.gBoxInvesticije.Location = new System.Drawing.Point(11, 133);
			this.gBoxInvesticije.Name = "gBoxInvesticije";
			this.gBoxInvesticije.Size = new System.Drawing.Size(468, 537);
			this.gBoxInvesticije.TabIndex = 3;
			this.gBoxInvesticije.TabStop = false;
			this.gBoxInvesticije.Text = "groupBox";
			// 
			// lblPrikazKretVrj1
			// 
			this.lblPrikazKretVrj1.AutoSize = true;
			this.lblPrikazKretVrj1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrikazKretVrj1.Location = new System.Drawing.Point(235, 487);
			this.lblPrikazKretVrj1.Name = "lblPrikazKretVrj1";
			this.lblPrikazKretVrj1.Size = new System.Drawing.Size(63, 28);
			this.lblPrikazKretVrj1.TabIndex = 2;
			this.lblPrikazKretVrj1.Text = "label1";
			// 
			// lblPrikazUkVrj1
			// 
			this.lblPrikazUkVrj1.AutoSize = true;
			this.lblPrikazUkVrj1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrikazUkVrj1.Location = new System.Drawing.Point(235, 446);
			this.lblPrikazUkVrj1.Name = "lblPrikazUkVrj1";
			this.lblPrikazUkVrj1.Size = new System.Drawing.Size(63, 28);
			this.lblPrikazUkVrj1.TabIndex = 2;
			this.lblPrikazUkVrj1.Text = "label1";
			// 
			// lblPrikazVrj1
			// 
			this.lblPrikazVrj1.AutoSize = true;
			this.lblPrikazVrj1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrikazVrj1.Location = new System.Drawing.Point(235, 402);
			this.lblPrikazVrj1.Name = "lblPrikazVrj1";
			this.lblPrikazVrj1.Size = new System.Drawing.Size(63, 28);
			this.lblPrikazVrj1.TabIndex = 2;
			this.lblPrikazVrj1.Text = "label1";
			// 
			// lblPrikazKol
			// 
			this.lblPrikazKol.AutoSize = true;
			this.lblPrikazKol.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrikazKol.Location = new System.Drawing.Point(235, 361);
			this.lblPrikazKol.Name = "lblPrikazKol";
			this.lblPrikazKol.Size = new System.Drawing.Size(63, 28);
			this.lblPrikazKol.TabIndex = 2;
			this.lblPrikazKol.Text = "label1";
			// 
			// chart1
			// 
			chartArea3.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chart1.Legends.Add(legend3);
			this.chart1.Location = new System.Drawing.Point(6, 43);
			this.chart1.Name = "chart1";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			this.chart1.Series.Add(series3);
			this.chart1.Size = new System.Drawing.Size(468, 300);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// lblKretanjeVrijednosti1
			// 
			this.lblKretanjeVrijednosti1.AutoSize = true;
			this.lblKretanjeVrijednosti1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblKretanjeVrijednosti1.Location = new System.Drawing.Point(25, 487);
			this.lblKretanjeVrijednosti1.Name = "lblKretanjeVrijednosti1";
			this.lblKretanjeVrijednosti1.Size = new System.Drawing.Size(204, 28);
			this.lblKretanjeVrijednosti1.TabIndex = 0;
			this.lblKretanjeVrijednosti1.Text = "Kretanje vrijednosti:";
			// 
			// lblKolicina1
			// 
			this.lblKolicina1.AutoSize = true;
			this.lblKolicina1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblKolicina1.Location = new System.Drawing.Point(136, 361);
			this.lblKolicina1.Name = "lblKolicina1";
			this.lblKolicina1.Size = new System.Drawing.Size(93, 28);
			this.lblKolicina1.TabIndex = 0;
			this.lblKolicina1.Text = "Količina:";
			// 
			// lblUkupnaVrijednost1
			// 
			this.lblUkupnaVrijednost1.AutoSize = true;
			this.lblUkupnaVrijednost1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblUkupnaVrijednost1.Location = new System.Drawing.Point(39, 446);
			this.lblUkupnaVrijednost1.Name = "lblUkupnaVrijednost1";
			this.lblUkupnaVrijednost1.Size = new System.Drawing.Size(190, 28);
			this.lblUkupnaVrijednost1.TabIndex = 0;
			this.lblUkupnaVrijednost1.Text = "Ukupna vrijednost:";
			// 
			// lblVrijednost1
			// 
			this.lblVrijednost1.AutoSize = true;
			this.lblVrijednost1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblVrijednost1.Location = new System.Drawing.Point(116, 402);
			this.lblVrijednost1.Name = "lblVrijednost1";
			this.lblVrijednost1.Size = new System.Drawing.Size(113, 28);
			this.lblVrijednost1.TabIndex = 0;
			this.lblVrijednost1.Text = "Vrijednost:";
			// 
			// gBoxInvesticije2
			// 
			this.gBoxInvesticije2.Controls.Add(this.chart2);
			this.gBoxInvesticije2.Controls.Add(this.lblKretanjeVrijednosti2);
			this.gBoxInvesticije2.Controls.Add(this.lblKolicinaInvest2);
			this.gBoxInvesticije2.Controls.Add(this.lblUkupnaVrijednost2);
			this.gBoxInvesticije2.Controls.Add(this.lblVrijednostInvest2);
			this.gBoxInvesticije2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.gBoxInvesticije2.Location = new System.Drawing.Point(508, 133);
			this.gBoxInvesticije2.Name = "gBoxInvesticije2";
			this.gBoxInvesticije2.Size = new System.Drawing.Size(468, 537);
			this.gBoxInvesticije2.TabIndex = 3;
			this.gBoxInvesticije2.TabStop = false;
			this.gBoxInvesticije2.Text = "groupBox1";
			// 
			// chart2
			// 
			chartArea4.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea4);
			legend4.Name = "Legend1";
			this.chart2.Legends.Add(legend4);
			this.chart2.Location = new System.Drawing.Point(6, 43);
			this.chart2.Name = "chart2";
			series4.ChartArea = "ChartArea1";
			series4.Legend = "Legend1";
			series4.Name = "Series1";
			this.chart2.Series.Add(series4);
			this.chart2.Size = new System.Drawing.Size(468, 300);
			this.chart2.TabIndex = 1;
			this.chart2.Text = "chart1";
			// 
			// lblKretanjeVrijednosti2
			// 
			this.lblKretanjeVrijednosti2.AutoSize = true;
			this.lblKretanjeVrijednosti2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblKretanjeVrijednosti2.Location = new System.Drawing.Point(25, 487);
			this.lblKretanjeVrijednosti2.Name = "lblKretanjeVrijednosti2";
			this.lblKretanjeVrijednosti2.Size = new System.Drawing.Size(204, 28);
			this.lblKretanjeVrijednosti2.TabIndex = 0;
			this.lblKretanjeVrijednosti2.Text = "Kretanje vrijednosti:";
			// 
			// lblKolicinaInvest2
			// 
			this.lblKolicinaInvest2.AutoSize = true;
			this.lblKolicinaInvest2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblKolicinaInvest2.Location = new System.Drawing.Point(136, 361);
			this.lblKolicinaInvest2.Name = "lblKolicinaInvest2";
			this.lblKolicinaInvest2.Size = new System.Drawing.Size(93, 28);
			this.lblKolicinaInvest2.TabIndex = 0;
			this.lblKolicinaInvest2.Text = "Količina:";
			// 
			// lblUkupnaVrijednost2
			// 
			this.lblUkupnaVrijednost2.AutoSize = true;
			this.lblUkupnaVrijednost2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblUkupnaVrijednost2.Location = new System.Drawing.Point(39, 446);
			this.lblUkupnaVrijednost2.Name = "lblUkupnaVrijednost2";
			this.lblUkupnaVrijednost2.Size = new System.Drawing.Size(190, 28);
			this.lblUkupnaVrijednost2.TabIndex = 0;
			this.lblUkupnaVrijednost2.Text = "Ukupna vrijednost:";
			// 
			// lblVrijednostInvest2
			// 
			this.lblVrijednostInvest2.AutoSize = true;
			this.lblVrijednostInvest2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblVrijednostInvest2.Location = new System.Drawing.Point(116, 402);
			this.lblVrijednostInvest2.Name = "lblVrijednostInvest2";
			this.lblVrijednostInvest2.Size = new System.Drawing.Size(113, 28);
			this.lblVrijednostInvest2.TabIndex = 0;
			this.lblVrijednostInvest2.Text = "Vrijednost:";
			// 
			// bankovniracunBindingSource1
			// 
			this.bankovniracunBindingSource1.DataSource = typeof(PocetniZaslon.Bankovni_racun);
			// 
			// FrmInvesticijskiPortfolio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1640, 948);
			this.Controls.Add(this.gBoxMojeInvesticije);
			this.Controls.Add(this.gBoxTransakcija);
			this.Controls.Add(this.lblInvesticijskiPortfolio);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmInvesticijskiPortfolio";
			this.Text = "FrmInvesticijskiPortfolio";
			this.gBoxTransakcija.ResumeLayout(false);
			this.gBoxTransakcija.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.investicijaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transakcijainvesticijeBindingSource)).EndInit();
			this.gBoxMojeInvesticije.ResumeLayout(false);
			this.gBoxMojeInvesticije.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.vrstainvesticijeBindingSource)).EndInit();
			this.gBoxInvesticije.ResumeLayout(false);
			this.gBoxInvesticije.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.gBoxInvesticije2.ResumeLayout(false);
			this.gBoxInvesticije2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblInvesticijskiPortfolio;
		private System.Windows.Forms.GroupBox gBoxTransakcija;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.GroupBox gBoxMojeInvesticije;
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
		private System.Windows.Forms.GroupBox gBoxInvesticije2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Label lblKretanjeVrijednosti2;
		private System.Windows.Forms.Label lblKolicinaInvest2;
		private System.Windows.Forms.Label lblUkupnaVrijednost2;
		private System.Windows.Forms.Label lblVrijednostInvest2;
		private System.Windows.Forms.BindingSource bankovniracunBindingSource;
		private System.Windows.Forms.BindingSource bankovniracunBindingSource1;
		private System.Windows.Forms.Label lblNazivInvesticije;
		private System.Windows.Forms.Button btnDodajInvesticiju;
		private System.Windows.Forms.TextBox txtBoxNazivInvesticije;
		private System.Windows.Forms.Label lblVrstaInvesticije;
		private System.Windows.Forms.ComboBox cBoxVrstaInvesticije;
		private System.Windows.Forms.BindingSource vrstainvesticijeBindingSource;
		private System.Windows.Forms.GroupBox gBoxInvesticije;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label lblKretanjeVrijednosti1;
		private System.Windows.Forms.Label lblKolicina1;
		private System.Windows.Forms.Label lblUkupnaVrijednost1;
		private System.Windows.Forms.Label lblVrijednost1;
		private System.Windows.Forms.ComboBox cBoxNazivInvesticije;
		private System.Windows.Forms.BindingSource investicijaBindingSource;
		private System.Windows.Forms.TextBox txtBoxIznosTransInv;
		private System.Windows.Forms.BindingSource transakcijainvesticijeBindingSource;
		private System.Windows.Forms.Button btnObrisiInvesticiju;
		private System.Windows.Forms.Label lblPrikazKretVrj1;
		private System.Windows.Forms.Label lblPrikazUkVrj1;
		private System.Windows.Forms.Label lblPrikazVrj1;
		private System.Windows.Forms.Label lblPrikazKol;
	}
}