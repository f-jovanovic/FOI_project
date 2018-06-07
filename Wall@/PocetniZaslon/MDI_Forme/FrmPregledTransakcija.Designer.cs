namespace PocetniZaslon.MDI_Forme
{
	partial class FrmPregledTransakcija
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
			this.dgvPregledTransakcija = new System.Windows.Forms.DataGridView();
			this.bindingSourcePregledTransakcija = new System.Windows.Forms.BindingSource(this.components);
			this.lblPregledTransakcija = new System.Windows.Forms.Label();
			this.chkObicneTransakcije = new System.Windows.Forms.CheckBox();
			this.chkTransakcijeInvesticija = new System.Windows.Forms.CheckBox();
			this.dgvBankovniRacuni = new System.Windows.Forms.DataGridView();
			this.ibanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nazivracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idvrstaracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.BindingSourceVrstaRacuna = new System.Windows.Forms.BindingSource(this.components);
			this.stanjeracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vrstaracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transakcijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transakcijainvesticijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceBankovniRacuni = new System.Windows.Forms.BindingSource(this.components);
			this.chkRashodi = new System.Windows.Forms.CheckBox();
			this.chkPrihodi = new System.Windows.Forms.CheckBox();
			this.dgvKategorije = new System.Windows.Forms.DataGridView();
			this.bindingSourceKategorije = new System.Windows.Forms.BindingSource(this.components);
			this.chkVrijeme = new System.Windows.Forms.CheckBox();
			this.dtpVrijemeOd = new System.Windows.Forms.DateTimePicker();
			this.dtpVrijemeDo = new System.Windows.Forms.DateTimePicker();
			this.lblVrstaTransakcije = new System.Windows.Forms.Label();
			this.lblVrijeme = new System.Windows.Forms.Label();
			this.lblBankovniRacuni = new System.Windows.Forms.Label();
			this.lblKategorije = new System.Windows.Forms.Label();
			this.bindingSourceVrstaTransakcije = new System.Windows.Forms.BindingSource(this.components);
			this.idkategorijetransakcijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nazivkategorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idvrstatransakcijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.idkorisnikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vrstatransakcijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transakcijaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.korisnikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvPregledTransakcija)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourcePregledTransakcija)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBankovniRacuni)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BindingSourceVrstaRacuna)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceBankovniRacuni)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceKategorije)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceVrstaTransakcije)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPregledTransakcija
			// 
			this.dgvPregledTransakcija.AutoGenerateColumns = false;
			this.dgvPregledTransakcija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPregledTransakcija.DataSource = this.bindingSourcePregledTransakcija;
			this.dgvPregledTransakcija.Location = new System.Drawing.Point(2, 84);
			this.dgvPregledTransakcija.Name = "dgvPregledTransakcija";
			this.dgvPregledTransakcija.Size = new System.Drawing.Size(1056, 653);
			this.dgvPregledTransakcija.TabIndex = 0;
			// 
			// lblPregledTransakcija
			// 
			this.lblPregledTransakcija.AutoSize = true;
			this.lblPregledTransakcija.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPregledTransakcija.Location = new System.Drawing.Point(215, 9);
			this.lblPregledTransakcija.Name = "lblPregledTransakcija";
			this.lblPregledTransakcija.Size = new System.Drawing.Size(458, 65);
			this.lblPregledTransakcija.TabIndex = 1;
			this.lblPregledTransakcija.Text = "Pregled transakcija";
			// 
			// chkObicneTransakcije
			// 
			this.chkObicneTransakcije.AutoSize = true;
			this.chkObicneTransakcije.Checked = true;
			this.chkObicneTransakcije.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkObicneTransakcije.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkObicneTransakcije.Location = new System.Drawing.Point(1121, 124);
			this.chkObicneTransakcije.Name = "chkObicneTransakcije";
			this.chkObicneTransakcije.Size = new System.Drawing.Size(149, 24);
			this.chkObicneTransakcije.TabIndex = 0;
			this.chkObicneTransakcije.Text = "Obične transakcije";
			this.chkObicneTransakcije.UseVisualStyleBackColor = true;
			this.chkObicneTransakcije.CheckedChanged += new System.EventHandler(this.chkObicneTransakcije_CheckedChanged);
			// 
			// chkTransakcijeInvesticija
			// 
			this.chkTransakcijeInvesticija.AutoSize = true;
			this.chkTransakcijeInvesticija.Checked = true;
			this.chkTransakcijeInvesticija.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTransakcijeInvesticija.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkTransakcijeInvesticija.Location = new System.Drawing.Point(1121, 154);
			this.chkTransakcijeInvesticija.Name = "chkTransakcijeInvesticija";
			this.chkTransakcijeInvesticija.Size = new System.Drawing.Size(169, 24);
			this.chkTransakcijeInvesticija.TabIndex = 1;
			this.chkTransakcijeInvesticija.Text = "Transakcije investicija";
			this.chkTransakcijeInvesticija.UseVisualStyleBackColor = true;
			this.chkTransakcijeInvesticija.CheckedChanged += new System.EventHandler(this.chkTransakcijeInvesticija_CheckedChanged);
			// 
			// dgvBankovniRacuni
			// 
			this.dgvBankovniRacuni.AutoGenerateColumns = false;
			this.dgvBankovniRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBankovniRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ibanDataGridViewTextBoxColumn,
            this.idkorisnikDataGridViewTextBoxColumn,
            this.nazivracunaDataGridViewTextBoxColumn,
            this.idvrstaracunaDataGridViewTextBoxColumn,
            this.stanjeracunaDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.vrstaracunaDataGridViewTextBoxColumn,
            this.transakcijaDataGridViewTextBoxColumn,
            this.transakcijainvesticijeDataGridViewTextBoxColumn});
			this.dgvBankovniRacuni.DataSource = this.bindingSourceBankovniRacuni;
			this.dgvBankovniRacuni.Location = new System.Drawing.Point(1101, 428);
			this.dgvBankovniRacuni.Name = "dgvBankovniRacuni";
			this.dgvBankovniRacuni.Size = new System.Drawing.Size(379, 119);
			this.dgvBankovniRacuni.TabIndex = 4;
			// 
			// ibanDataGridViewTextBoxColumn
			// 
			this.ibanDataGridViewTextBoxColumn.DataPropertyName = "iban";
			this.ibanDataGridViewTextBoxColumn.HeaderText = "iban";
			this.ibanDataGridViewTextBoxColumn.Name = "ibanDataGridViewTextBoxColumn";
			this.ibanDataGridViewTextBoxColumn.Visible = false;
			// 
			// idkorisnikDataGridViewTextBoxColumn
			// 
			this.idkorisnikDataGridViewTextBoxColumn.DataPropertyName = "id_korisnik";
			this.idkorisnikDataGridViewTextBoxColumn.HeaderText = "id_korisnik";
			this.idkorisnikDataGridViewTextBoxColumn.Name = "idkorisnikDataGridViewTextBoxColumn";
			this.idkorisnikDataGridViewTextBoxColumn.Visible = false;
			// 
			// nazivracunaDataGridViewTextBoxColumn
			// 
			this.nazivracunaDataGridViewTextBoxColumn.DataPropertyName = "naziv_racuna";
			this.nazivracunaDataGridViewTextBoxColumn.HeaderText = "naziv_racuna";
			this.nazivracunaDataGridViewTextBoxColumn.Name = "nazivracunaDataGridViewTextBoxColumn";
			// 
			// idvrstaracunaDataGridViewTextBoxColumn
			// 
			this.idvrstaracunaDataGridViewTextBoxColumn.DataPropertyName = "id_vrsta_racuna";
			this.idvrstaracunaDataGridViewTextBoxColumn.DataSource = this.BindingSourceVrstaRacuna;
			this.idvrstaracunaDataGridViewTextBoxColumn.DisplayMember = "naziv_vrste_racuna";
			this.idvrstaracunaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.idvrstaracunaDataGridViewTextBoxColumn.HeaderText = "Vrsta računa";
			this.idvrstaracunaDataGridViewTextBoxColumn.Name = "idvrstaracunaDataGridViewTextBoxColumn";
			this.idvrstaracunaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.idvrstaracunaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.idvrstaracunaDataGridViewTextBoxColumn.ValueMember = "id_vrsta_racuna";
			// 
			// BindingSourceVrstaRacuna
			// 
			this.BindingSourceVrstaRacuna.DataSource = typeof(PocetniZaslon.Vrsta_racuna);
			// 
			// stanjeracunaDataGridViewTextBoxColumn
			// 
			this.stanjeracunaDataGridViewTextBoxColumn.DataPropertyName = "stanje_racuna";
			this.stanjeracunaDataGridViewTextBoxColumn.HeaderText = "stanje_racuna";
			this.stanjeracunaDataGridViewTextBoxColumn.Name = "stanjeracunaDataGridViewTextBoxColumn";
			// 
			// korisnikDataGridViewTextBoxColumn
			// 
			this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
			this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
			this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
			this.korisnikDataGridViewTextBoxColumn.Visible = false;
			// 
			// vrstaracunaDataGridViewTextBoxColumn
			// 
			this.vrstaracunaDataGridViewTextBoxColumn.DataPropertyName = "Vrsta_racuna";
			this.vrstaracunaDataGridViewTextBoxColumn.HeaderText = "Vrsta_racuna";
			this.vrstaracunaDataGridViewTextBoxColumn.Name = "vrstaracunaDataGridViewTextBoxColumn";
			this.vrstaracunaDataGridViewTextBoxColumn.Visible = false;
			// 
			// transakcijaDataGridViewTextBoxColumn
			// 
			this.transakcijaDataGridViewTextBoxColumn.DataPropertyName = "Transakcija";
			this.transakcijaDataGridViewTextBoxColumn.HeaderText = "Transakcija";
			this.transakcijaDataGridViewTextBoxColumn.Name = "transakcijaDataGridViewTextBoxColumn";
			this.transakcijaDataGridViewTextBoxColumn.Visible = false;
			// 
			// transakcijainvesticijeDataGridViewTextBoxColumn
			// 
			this.transakcijainvesticijeDataGridViewTextBoxColumn.DataPropertyName = "Transakcija_investicije";
			this.transakcijainvesticijeDataGridViewTextBoxColumn.HeaderText = "Transakcija_investicije";
			this.transakcijainvesticijeDataGridViewTextBoxColumn.Name = "transakcijainvesticijeDataGridViewTextBoxColumn";
			this.transakcijainvesticijeDataGridViewTextBoxColumn.Visible = false;
			// 
			// bindingSourceBankovniRacuni
			// 
			this.bindingSourceBankovniRacuni.DataSource = typeof(PocetniZaslon.Bankovni_racun);
			// 
			// chkRashodi
			// 
			this.chkRashodi.AutoSize = true;
			this.chkRashodi.Checked = true;
			this.chkRashodi.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRashodi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkRashodi.Location = new System.Drawing.Point(1121, 213);
			this.chkRashodi.Name = "chkRashodi";
			this.chkRashodi.Size = new System.Drawing.Size(81, 24);
			this.chkRashodi.TabIndex = 3;
			this.chkRashodi.Text = "Rashodi";
			this.chkRashodi.UseVisualStyleBackColor = true;
			this.chkRashodi.CheckedChanged += new System.EventHandler(this.chkRashodi_CheckedChanged);
			// 
			// chkPrihodi
			// 
			this.chkPrihodi.AutoSize = true;
			this.chkPrihodi.Checked = true;
			this.chkPrihodi.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkPrihodi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkPrihodi.Location = new System.Drawing.Point(1121, 183);
			this.chkPrihodi.Name = "chkPrihodi";
			this.chkPrihodi.Size = new System.Drawing.Size(75, 24);
			this.chkPrihodi.TabIndex = 2;
			this.chkPrihodi.Text = "Prihodi";
			this.chkPrihodi.UseVisualStyleBackColor = true;
			this.chkPrihodi.CheckedChanged += new System.EventHandler(this.chkPrihodi_CheckedChanged);
			// 
			// dgvKategorije
			// 
			this.dgvKategorije.AutoGenerateColumns = false;
			this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKategorije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkategorijetransakcijeDataGridViewTextBoxColumn,
            this.nazivkategorijeDataGridViewTextBoxColumn,
            this.idvrstatransakcijeDataGridViewTextBoxColumn,
            this.idkorisnikDataGridViewTextBoxColumn1,
            this.vrstatransakcijeDataGridViewTextBoxColumn,
            this.transakcijaDataGridViewTextBoxColumn1,
            this.korisnikDataGridViewTextBoxColumn1});
			this.dgvKategorije.DataSource = this.bindingSourceKategorije;
			this.dgvKategorije.Location = new System.Drawing.Point(1101, 590);
			this.dgvKategorije.Name = "dgvKategorije";
			this.dgvKategorije.Size = new System.Drawing.Size(379, 147);
			this.dgvKategorije.TabIndex = 7;
			// 
			// bindingSourceKategorije
			// 
			this.bindingSourceKategorije.DataSource = typeof(PocetniZaslon.Kategorije_transakcije);
			// 
			// chkVrijeme
			// 
			this.chkVrijeme.AutoSize = true;
			this.chkVrijeme.Checked = true;
			this.chkVrijeme.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkVrijeme.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkVrijeme.Location = new System.Drawing.Point(1101, 305);
			this.chkVrijeme.Name = "chkVrijeme";
			this.chkVrijeme.Size = new System.Drawing.Size(51, 24);
			this.chkVrijeme.TabIndex = 4;
			this.chkVrijeme.Text = "Sve";
			this.chkVrijeme.UseVisualStyleBackColor = true;
			this.chkVrijeme.CheckedChanged += new System.EventHandler(this.chkVrijeme_CheckedChanged);
			// 
			// dtpVrijemeOd
			// 
			this.dtpVrijemeOd.Enabled = false;
			this.dtpVrijemeOd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpVrijemeOd.Location = new System.Drawing.Point(1152, 305);
			this.dtpVrijemeOd.Name = "dtpVrijemeOd";
			this.dtpVrijemeOd.Size = new System.Drawing.Size(328, 27);
			this.dtpVrijemeOd.TabIndex = 5;
			// 
			// dtpVrijemeDo
			// 
			this.dtpVrijemeDo.Enabled = false;
			this.dtpVrijemeDo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpVrijemeDo.Location = new System.Drawing.Point(1152, 345);
			this.dtpVrijemeDo.Name = "dtpVrijemeDo";
			this.dtpVrijemeDo.Size = new System.Drawing.Size(328, 27);
			this.dtpVrijemeDo.TabIndex = 6;
			// 
			// lblVrstaTransakcije
			// 
			this.lblVrstaTransakcije.AutoSize = true;
			this.lblVrstaTransakcije.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVrstaTransakcije.Location = new System.Drawing.Point(1094, 84);
			this.lblVrstaTransakcije.Name = "lblVrstaTransakcije";
			this.lblVrstaTransakcije.Size = new System.Drawing.Size(236, 37);
			this.lblVrstaTransakcije.TabIndex = 11;
			this.lblVrstaTransakcije.Text = "Vrsta transakcije:";
			// 
			// lblVrijeme
			// 
			this.lblVrijeme.AutoSize = true;
			this.lblVrijeme.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVrijeme.Location = new System.Drawing.Point(1094, 253);
			this.lblVrijeme.Name = "lblVrijeme";
			this.lblVrijeme.Size = new System.Drawing.Size(123, 37);
			this.lblVrijeme.TabIndex = 13;
			this.lblVrijeme.Text = "Vrijeme:";
			// 
			// lblBankovniRacuni
			// 
			this.lblBankovniRacuni.AutoSize = true;
			this.lblBankovniRacuni.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBankovniRacuni.Location = new System.Drawing.Point(1094, 388);
			this.lblBankovniRacuni.Name = "lblBankovniRacuni";
			this.lblBankovniRacuni.Size = new System.Drawing.Size(229, 37);
			this.lblBankovniRacuni.TabIndex = 14;
			this.lblBankovniRacuni.Text = "Bankovni računi:";
			// 
			// lblKategorije
			// 
			this.lblKategorije.AutoSize = true;
			this.lblKategorije.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKategorije.Location = new System.Drawing.Point(1094, 550);
			this.lblKategorije.Name = "lblKategorije";
			this.lblKategorije.Size = new System.Drawing.Size(159, 37);
			this.lblKategorije.TabIndex = 15;
			this.lblKategorije.Text = "Kategorije:";
			// 
			// bindingSourceVrstaTransakcije
			// 
			this.bindingSourceVrstaTransakcije.DataSource = typeof(PocetniZaslon.Vrsta_transakcije);
			// 
			// idkategorijetransakcijeDataGridViewTextBoxColumn
			// 
			this.idkategorijetransakcijeDataGridViewTextBoxColumn.DataPropertyName = "id_kategorije_transakcije";
			this.idkategorijetransakcijeDataGridViewTextBoxColumn.HeaderText = "id_kategorije_transakcije";
			this.idkategorijetransakcijeDataGridViewTextBoxColumn.Name = "idkategorijetransakcijeDataGridViewTextBoxColumn";
			this.idkategorijetransakcijeDataGridViewTextBoxColumn.Visible = false;
			this.idkategorijetransakcijeDataGridViewTextBoxColumn.Width = 150;
			// 
			// nazivkategorijeDataGridViewTextBoxColumn
			// 
			this.nazivkategorijeDataGridViewTextBoxColumn.DataPropertyName = "naziv_kategorije";
			this.nazivkategorijeDataGridViewTextBoxColumn.HeaderText = "Naziv kategorije";
			this.nazivkategorijeDataGridViewTextBoxColumn.Name = "nazivkategorijeDataGridViewTextBoxColumn";
			this.nazivkategorijeDataGridViewTextBoxColumn.Width = 150;
			// 
			// idvrstatransakcijeDataGridViewTextBoxColumn
			// 
			this.idvrstatransakcijeDataGridViewTextBoxColumn.DataPropertyName = "id_vrsta_transakcije";
			this.idvrstatransakcijeDataGridViewTextBoxColumn.DataSource = this.bindingSourceVrstaTransakcije;
			this.idvrstatransakcijeDataGridViewTextBoxColumn.DisplayMember = "naziv_vrste_transakcije";
			this.idvrstatransakcijeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.idvrstatransakcijeDataGridViewTextBoxColumn.HeaderText = "Vrsta transakcije";
			this.idvrstatransakcijeDataGridViewTextBoxColumn.Name = "idvrstatransakcijeDataGridViewTextBoxColumn";
			this.idvrstatransakcijeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.idvrstatransakcijeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.idvrstatransakcijeDataGridViewTextBoxColumn.ValueMember = "id_vrsta_transakcije";
			this.idvrstatransakcijeDataGridViewTextBoxColumn.Width = 110;
			// 
			// idkorisnikDataGridViewTextBoxColumn1
			// 
			this.idkorisnikDataGridViewTextBoxColumn1.DataPropertyName = "id_korisnik";
			this.idkorisnikDataGridViewTextBoxColumn1.HeaderText = "id_korisnik";
			this.idkorisnikDataGridViewTextBoxColumn1.Name = "idkorisnikDataGridViewTextBoxColumn1";
			this.idkorisnikDataGridViewTextBoxColumn1.Visible = false;
			// 
			// vrstatransakcijeDataGridViewTextBoxColumn
			// 
			this.vrstatransakcijeDataGridViewTextBoxColumn.DataPropertyName = "Vrsta_transakcije";
			this.vrstatransakcijeDataGridViewTextBoxColumn.HeaderText = "Vrsta_transakcije";
			this.vrstatransakcijeDataGridViewTextBoxColumn.Name = "vrstatransakcijeDataGridViewTextBoxColumn";
			this.vrstatransakcijeDataGridViewTextBoxColumn.Visible = false;
			this.vrstatransakcijeDataGridViewTextBoxColumn.Width = 110;
			// 
			// transakcijaDataGridViewTextBoxColumn1
			// 
			this.transakcijaDataGridViewTextBoxColumn1.DataPropertyName = "Transakcija";
			this.transakcijaDataGridViewTextBoxColumn1.HeaderText = "Transakcija";
			this.transakcijaDataGridViewTextBoxColumn1.Name = "transakcijaDataGridViewTextBoxColumn1";
			this.transakcijaDataGridViewTextBoxColumn1.Visible = false;
			// 
			// korisnikDataGridViewTextBoxColumn1
			// 
			this.korisnikDataGridViewTextBoxColumn1.DataPropertyName = "Korisnik";
			this.korisnikDataGridViewTextBoxColumn1.HeaderText = "Korisnik";
			this.korisnikDataGridViewTextBoxColumn1.Name = "korisnikDataGridViewTextBoxColumn1";
			this.korisnikDataGridViewTextBoxColumn1.Visible = false;
			// 
			// FrmPregledTransakcija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1482, 771);
			this.Controls.Add(this.lblKategorije);
			this.Controls.Add(this.lblBankovniRacuni);
			this.Controls.Add(this.lblVrijeme);
			this.Controls.Add(this.lblVrstaTransakcije);
			this.Controls.Add(this.dtpVrijemeDo);
			this.Controls.Add(this.dtpVrijemeOd);
			this.Controls.Add(this.chkVrijeme);
			this.Controls.Add(this.dgvKategorije);
			this.Controls.Add(this.chkRashodi);
			this.Controls.Add(this.chkPrihodi);
			this.Controls.Add(this.dgvBankovniRacuni);
			this.Controls.Add(this.chkTransakcijeInvesticija);
			this.Controls.Add(this.chkObicneTransakcije);
			this.Controls.Add(this.lblPregledTransakcija);
			this.Controls.Add(this.dgvPregledTransakcija);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmPregledTransakcija";
			this.Text = "FrmPregledTransakcija";
			this.Load += new System.EventHandler(this.FrmPregledTransakcija_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPregledTransakcija)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourcePregledTransakcija)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBankovniRacuni)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BindingSourceVrstaRacuna)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceBankovniRacuni)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceKategorije)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceVrstaTransakcije)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPregledTransakcija;
		private System.Windows.Forms.Label lblPregledTransakcija;
		private System.Windows.Forms.CheckBox chkObicneTransakcije;
		private System.Windows.Forms.CheckBox chkTransakcijeInvesticija;
		private System.Windows.Forms.DataGridView dgvBankovniRacuni;
		private System.Windows.Forms.CheckBox chkRashodi;
		private System.Windows.Forms.CheckBox chkPrihodi;
		private System.Windows.Forms.DataGridView dgvKategorije;
		private System.Windows.Forms.CheckBox chkVrijeme;
		private System.Windows.Forms.DateTimePicker dtpVrijemeOd;
		private System.Windows.Forms.DateTimePicker dtpVrijemeDo;
		private System.Windows.Forms.Label lblVrstaTransakcije;
		private System.Windows.Forms.Label lblVrijeme;
		private System.Windows.Forms.Label lblBankovniRacuni;
		private System.Windows.Forms.Label lblKategorije;
		private System.Windows.Forms.BindingSource bindingSourcePregledTransakcija;
		private System.Windows.Forms.BindingSource bindingSourceBankovniRacuni;
		private System.Windows.Forms.BindingSource bindingSourceKategorije;
		private System.Windows.Forms.BindingSource BindingSourceVrstaRacuna;
		private System.Windows.Forms.DataGridViewTextBoxColumn ibanDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nazivracunaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn idvrstaracunaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stanjeracunaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn vrstaracunaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn transakcijaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn transakcijainvesticijeDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource bindingSourceVrstaTransakcije;
		private System.Windows.Forms.DataGridViewTextBoxColumn idkategorijetransakcijeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nazivkategorijeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn idvrstatransakcijeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn vrstatransakcijeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn transakcijaDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn1;
	}
}