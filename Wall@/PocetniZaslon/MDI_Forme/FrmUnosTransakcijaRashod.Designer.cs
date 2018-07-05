namespace PocetniZaslon.MDI_Forme
{
    partial class FrmUnosTransakcijaRashod
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
            this.lblNoviRashod = new System.Windows.Forms.Label();
            this.lblBankovniRacun = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblSlika = new System.Windows.Forms.Label();
            this.txtIznosRashod = new System.Windows.Forms.TextBox();
            this.txtOpisRashod = new System.Windows.Forms.TextBox();
            this.cboBankovniRacunRashod = new System.Windows.Forms.ComboBox();
            this.bankovniracunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDatumTransakcijeRashod = new System.Windows.Forms.DateTimePicker();
            this.btnSkenirajBarkodRashod = new System.Windows.Forms.Button();
            this.btnDodajSlikuRashod = new System.Windows.Forms.Button();
            this.btnSpremiTransakcijuRashod = new System.Windows.Forms.Button();
            this.dtpVrijemeTransakcijeRashod = new System.Windows.Forms.DateTimePicker();
            this.lblKategorije = new System.Windows.Forms.Label();
            this.btnDodajKategorijuRashod = new System.Windows.Forms.Button();
            this.btnIzbrisiKategorijuRashod = new System.Windows.Forms.Button();
            this.chkKategorijeRashod = new System.Windows.Forms.CheckedListBox();
            this.lblNeispravanIznosRashod = new System.Windows.Forms.Label();
            this.btnUrediKategorijuRashod = new System.Windows.Forms.Button();
            this.ofdSlikaRacuna = new System.Windows.Forms.OpenFileDialog();
            this.txtLokacijaSlikeRacuna = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoviRashod
            // 
            this.lblNoviRashod.AutoSize = true;
            this.lblNoviRashod.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNoviRashod.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNoviRashod.Location = new System.Drawing.Point(289, 2);
            this.lblNoviRashod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoviRashod.Name = "lblNoviRashod";
            this.lblNoviRashod.Size = new System.Drawing.Size(302, 65);
            this.lblNoviRashod.TabIndex = 1;
            this.lblNoviRashod.Text = "Novi rashod";
            // 
            // lblBankovniRacun
            // 
            this.lblBankovniRacun.AutoSize = true;
            this.lblBankovniRacun.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBankovniRacun.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBankovniRacun.Location = new System.Drawing.Point(29, 105);
            this.lblBankovniRacun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankovniRacun.Name = "lblBankovniRacun";
            this.lblBankovniRacun.Size = new System.Drawing.Size(200, 37);
            this.lblBankovniRacun.TabIndex = 2;
            this.lblBankovniRacun.Text = "Bankovni račun:";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIznos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIznos.Location = new System.Drawing.Point(15, 205);
            this.lblIznos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(212, 37);
            this.lblIznos.TabIndex = 4;
            this.lblIznos.Text = "Iznos transakcije:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDatum.Location = new System.Drawing.Point(-5, 308);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(232, 37);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum transakcije:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOpis.Location = new System.Drawing.Point(23, 373);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(204, 37);
            this.lblOpis.TabIndex = 6;
            this.lblOpis.Text = "Opis transakcije:";
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSlika.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSlika.Location = new System.Drawing.Point(67, 544);
            this.lblSlika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(162, 37);
            this.lblSlika.TabIndex = 7;
            this.lblSlika.Text = "Slika računa:";
            // 
            // txtIznosRashod
            // 
            this.txtIznosRashod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIznosRashod.Location = new System.Drawing.Point(233, 202);
            this.txtIznosRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIznosRashod.Name = "txtIznosRashod";
            this.txtIznosRashod.Size = new System.Drawing.Size(500, 43);
            this.txtIznosRashod.TabIndex = 3;
            this.txtIznosRashod.TextChanged += new System.EventHandler(this.txtIznosRashod_TextChanged);
            // 
            // txtOpisRashod
            // 
            this.txtOpisRashod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpisRashod.Location = new System.Drawing.Point(233, 370);
            this.txtOpisRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpisRashod.Multiline = true;
            this.txtOpisRashod.Name = "txtOpisRashod";
            this.txtOpisRashod.Size = new System.Drawing.Size(500, 171);
            this.txtOpisRashod.TabIndex = 5;
            // 
            // cboBankovniRacunRashod
            // 
            this.cboBankovniRacunRashod.DataSource = this.bankovniracunBindingSource;
            this.cboBankovniRacunRashod.DisplayMember = "naziv_racuna";
            this.cboBankovniRacunRashod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboBankovniRacunRashod.FormattingEnabled = true;
            this.cboBankovniRacunRashod.Location = new System.Drawing.Point(233, 102);
            this.cboBankovniRacunRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBankovniRacunRashod.Name = "cboBankovniRacunRashod";
            this.cboBankovniRacunRashod.Size = new System.Drawing.Size(319, 44);
            this.cboBankovniRacunRashod.TabIndex = 1;
            this.cboBankovniRacunRashod.ValueMember = "iban";
            // 
            // bankovniracunBindingSource
            // 
            this.bankovniracunBindingSource.DataSource = typeof(PocetniZaslon.Bankovni_racun);
            // 
            // dtpDatumTransakcijeRashod
            // 
            this.dtpDatumTransakcijeRashod.CalendarFont = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatumTransakcijeRashod.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.dtpDatumTransakcijeRashod.Location = new System.Drawing.Point(233, 303);
            this.dtpDatumTransakcijeRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatumTransakcijeRashod.Name = "dtpDatumTransakcijeRashod";
            this.dtpDatumTransakcijeRashod.Size = new System.Drawing.Size(246, 43);
            this.dtpDatumTransakcijeRashod.TabIndex = 4;
            // 
            // btnSkenirajBarkodRashod
            // 
            this.btnSkenirajBarkodRashod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSkenirajBarkodRashod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkenirajBarkodRashod.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkenirajBarkodRashod.ForeColor = System.Drawing.Color.White;
            this.btnSkenirajBarkodRashod.Location = new System.Drawing.Point(488, 593);
            this.btnSkenirajBarkodRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSkenirajBarkodRashod.Name = "btnSkenirajBarkodRashod";
            this.btnSkenirajBarkodRashod.Size = new System.Drawing.Size(244, 43);
            this.btnSkenirajBarkodRashod.TabIndex = 7;
            this.btnSkenirajBarkodRashod.Text = "Skeniraj barkod računa";
            this.btnSkenirajBarkodRashod.UseVisualStyleBackColor = false;
            this.btnSkenirajBarkodRashod.Click += new System.EventHandler(this.btnSkenirajBarkodRashod_Click);
            // 
            // btnDodajSlikuRashod
            // 
            this.btnDodajSlikuRashod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDodajSlikuRashod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajSlikuRashod.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajSlikuRashod.ForeColor = System.Drawing.Color.White;
            this.btnDodajSlikuRashod.Location = new System.Drawing.Point(233, 593);
            this.btnDodajSlikuRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajSlikuRashod.Name = "btnDodajSlikuRashod";
            this.btnDodajSlikuRashod.Size = new System.Drawing.Size(244, 43);
            this.btnDodajSlikuRashod.TabIndex = 6;
            this.btnDodajSlikuRashod.Text = "Dodaj sliku računa";
            this.btnDodajSlikuRashod.UseVisualStyleBackColor = false;
            this.btnDodajSlikuRashod.Click += new System.EventHandler(this.btnDodajSlikuRashod_Click);
            // 
            // btnSpremiTransakcijuRashod
            // 
            this.btnSpremiTransakcijuRashod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSpremiTransakcijuRashod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiTransakcijuRashod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiTransakcijuRashod.ForeColor = System.Drawing.Color.White;
            this.btnSpremiTransakcijuRashod.Location = new System.Drawing.Point(300, 663);
            this.btnSpremiTransakcijuRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpremiTransakcijuRashod.Name = "btnSpremiTransakcijuRashod";
            this.btnSpremiTransakcijuRashod.Size = new System.Drawing.Size(261, 54);
            this.btnSpremiTransakcijuRashod.TabIndex = 8;
            this.btnSpremiTransakcijuRashod.Text = "Spremi transakciju";
            this.btnSpremiTransakcijuRashod.UseVisualStyleBackColor = false;
            this.btnSpremiTransakcijuRashod.Click += new System.EventHandler(this.btnSpremiTransakcijuRashod_Click);
            // 
            // dtpVrijemeTransakcijeRashod
            // 
            this.dtpVrijemeTransakcijeRashod.CalendarFont = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpVrijemeTransakcijeRashod.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.dtpVrijemeTransakcijeRashod.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijemeTransakcijeRashod.Location = new System.Drawing.Point(488, 303);
            this.dtpVrijemeTransakcijeRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpVrijemeTransakcijeRashod.Name = "dtpVrijemeTransakcijeRashod";
            this.dtpVrijemeTransakcijeRashod.ShowUpDown = true;
            this.dtpVrijemeTransakcijeRashod.Size = new System.Drawing.Size(117, 43);
            this.dtpVrijemeTransakcijeRashod.TabIndex = 9;
            // 
            // lblKategorije
            // 
            this.lblKategorije.AutoSize = true;
            this.lblKategorije.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorije.Location = new System.Drawing.Point(761, 102);
            this.lblKategorije.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategorije.Name = "lblKategorije";
            this.lblKategorije.Size = new System.Drawing.Size(242, 37);
            this.lblKategorije.TabIndex = 10;
            this.lblKategorije.Text = "Kategorije rashoda:";
            // 
            // btnDodajKategorijuRashod
            // 
            this.btnDodajKategorijuRashod.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnDodajKategorijuRashod.FlatAppearance.BorderSize = 2;
            this.btnDodajKategorijuRashod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajKategorijuRashod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajKategorijuRashod.Location = new System.Drawing.Point(760, 447);
            this.btnDodajKategorijuRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajKategorijuRashod.Name = "btnDodajKategorijuRashod";
            this.btnDodajKategorijuRashod.Size = new System.Drawing.Size(224, 39);
            this.btnDodajKategorijuRashod.TabIndex = 12;
            this.btnDodajKategorijuRashod.Text = "Dodaj kategoriju";
            this.btnDodajKategorijuRashod.UseVisualStyleBackColor = true;
            this.btnDodajKategorijuRashod.Click += new System.EventHandler(this.btnDodajKategorijuRashod_Click);
            // 
            // btnIzbrisiKategorijuRashod
            // 
            this.btnIzbrisiKategorijuRashod.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnIzbrisiKategorijuRashod.FlatAppearance.BorderSize = 2;
            this.btnIzbrisiKategorijuRashod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiKategorijuRashod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiKategorijuRashod.Location = new System.Drawing.Point(760, 533);
            this.btnIzbrisiKategorijuRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzbrisiKategorijuRashod.Name = "btnIzbrisiKategorijuRashod";
            this.btnIzbrisiKategorijuRashod.Size = new System.Drawing.Size(224, 39);
            this.btnIzbrisiKategorijuRashod.TabIndex = 14;
            this.btnIzbrisiKategorijuRashod.Text = "Izbriši kategoriju";
            this.btnIzbrisiKategorijuRashod.UseVisualStyleBackColor = true;
            this.btnIzbrisiKategorijuRashod.Click += new System.EventHandler(this.btnIzbrisiKategorijuRashod_Click);
            // 
            // chkKategorijeRashod
            // 
            this.chkKategorijeRashod.BackColor = System.Drawing.Color.White;
            this.chkKategorijeRashod.CheckOnClick = true;
            this.chkKategorijeRashod.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkKategorijeRashod.FormattingEnabled = true;
            this.chkKategorijeRashod.Location = new System.Drawing.Point(760, 142);
            this.chkKategorijeRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkKategorijeRashod.Name = "chkKategorijeRashod";
            this.chkKategorijeRashod.Size = new System.Drawing.Size(224, 301);
            this.chkKategorijeRashod.TabIndex = 15;
            this.chkKategorijeRashod.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkKategorijeRashod_MouseUp);
            // 
            // lblNeispravanIznosRashod
            // 
            this.lblNeispravanIznosRashod.AutoSize = true;
            this.lblNeispravanIznosRashod.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNeispravanIznosRashod.ForeColor = System.Drawing.Color.Red;
            this.lblNeispravanIznosRashod.Location = new System.Drawing.Point(238, 246);
            this.lblNeispravanIznosRashod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNeispravanIznosRashod.Name = "lblNeispravanIznosRashod";
            this.lblNeispravanIznosRashod.Size = new System.Drawing.Size(254, 30);
            this.lblNeispravanIznosRashod.TabIndex = 16;
            this.lblNeispravanIznosRashod.Text = "Neispravno unesen iznos!";
            // 
            // btnUrediKategorijuRashod
            // 
            this.btnUrediKategorijuRashod.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnUrediKategorijuRashod.FlatAppearance.BorderSize = 2;
            this.btnUrediKategorijuRashod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrediKategorijuRashod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrediKategorijuRashod.Location = new System.Drawing.Point(760, 490);
            this.btnUrediKategorijuRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUrediKategorijuRashod.Name = "btnUrediKategorijuRashod";
            this.btnUrediKategorijuRashod.Size = new System.Drawing.Size(224, 39);
            this.btnUrediKategorijuRashod.TabIndex = 17;
            this.btnUrediKategorijuRashod.Text = "Uredi kategoriju";
            this.btnUrediKategorijuRashod.UseVisualStyleBackColor = true;
            this.btnUrediKategorijuRashod.Click += new System.EventHandler(this.btnUrediKategorijuRashod_Click);
            // 
            // ofdSlikaRacuna
            // 
            this.ofdSlikaRacuna.Filter = "JPG Image File(*.JPG)|*.JPG";
            this.ofdSlikaRacuna.Title = "Odabir slike računa";
            // 
            // txtLokacijaSlikeRacuna
            // 
            this.txtLokacijaSlikeRacuna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLokacijaSlikeRacuna.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLokacijaSlikeRacuna.Location = new System.Drawing.Point(233, 549);
            this.txtLokacijaSlikeRacuna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLokacijaSlikeRacuna.Name = "txtLokacijaSlikeRacuna";
            this.txtLokacijaSlikeRacuna.ReadOnly = true;
            this.txtLokacijaSlikeRacuna.Size = new System.Drawing.Size(499, 32);
            this.txtLokacijaSlikeRacuna.TabIndex = 19;
            this.txtLokacijaSlikeRacuna.TabStop = false;
            this.txtLokacijaSlikeRacuna.TextChanged += new System.EventHandler(this.txtLokacijaSlikeRacuna_TextChanged);
            // 
            // FrmUnosTransakcijaRashod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 717);
            this.Controls.Add(this.txtLokacijaSlikeRacuna);
            this.Controls.Add(this.btnUrediKategorijuRashod);
            this.Controls.Add(this.lblNeispravanIznosRashod);
            this.Controls.Add(this.chkKategorijeRashod);
            this.Controls.Add(this.btnIzbrisiKategorijuRashod);
            this.Controls.Add(this.btnDodajKategorijuRashod);
            this.Controls.Add(this.lblKategorije);
            this.Controls.Add(this.dtpVrijemeTransakcijeRashod);
            this.Controls.Add(this.btnSpremiTransakcijuRashod);
            this.Controls.Add(this.btnDodajSlikuRashod);
            this.Controls.Add(this.btnSkenirajBarkodRashod);
            this.Controls.Add(this.dtpDatumTransakcijeRashod);
            this.Controls.Add(this.cboBankovniRacunRashod);
            this.Controls.Add(this.txtOpisRashod);
            this.Controls.Add(this.txtIznosRashod);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblBankovniRacun);
            this.Controls.Add(this.lblNoviRashod);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUnosTransakcijaRashod";
            this.Text = "FrmUnosTransakcijaTrosak";
            this.Load += new System.EventHandler(this.FrmUnosTransakcijaTrosak_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmUnosTransakcijaRashod_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoviRashod;
        private System.Windows.Forms.Label lblBankovniRacun;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.TextBox txtIznosRashod;
        private System.Windows.Forms.TextBox txtOpisRashod;
        private System.Windows.Forms.ComboBox cboBankovniRacunRashod;
        private System.Windows.Forms.DateTimePicker dtpDatumTransakcijeRashod;
        private System.Windows.Forms.Button btnSkenirajBarkodRashod;
        private System.Windows.Forms.Button btnDodajSlikuRashod;
        private System.Windows.Forms.Button btnSpremiTransakcijuRashod;
        private System.Windows.Forms.BindingSource bankovniracunBindingSource;
        private System.Windows.Forms.DateTimePicker dtpVrijemeTransakcijeRashod;
        private System.Windows.Forms.Label lblKategorije;
        private System.Windows.Forms.Button btnDodajKategorijuRashod;
        private System.Windows.Forms.Button btnIzbrisiKategorijuRashod;
        private System.Windows.Forms.CheckedListBox chkKategorijeRashod;
        private System.Windows.Forms.Label lblNeispravanIznosRashod;
        private System.Windows.Forms.Button btnUrediKategorijuRashod;
        protected System.Windows.Forms.OpenFileDialog ofdSlikaRacuna;
        private System.Windows.Forms.TextBox txtLokacijaSlikeRacuna;
    }
}