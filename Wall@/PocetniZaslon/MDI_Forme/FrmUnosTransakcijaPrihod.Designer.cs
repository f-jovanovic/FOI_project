﻿namespace PocetniZaslon.MDI_Forme
{
    partial class FrmUnosTransakcijaPrihod
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
            this.btnUrediKategorijuPrihod = new System.Windows.Forms.Button();
            this.lblNeispravanIznos = new System.Windows.Forms.Label();
            this.chkKategorijePrihod = new System.Windows.Forms.CheckedListBox();
            this.btnIzbrisiKategorijuPrihod = new System.Windows.Forms.Button();
            this.btnDodajKategorijuPrihod = new System.Windows.Forms.Button();
            this.lblKategorije = new System.Windows.Forms.Label();
            this.dtpVrijemeTransakcijePrihod = new System.Windows.Forms.DateTimePicker();
            this.btnSpremiTransakcijuPrihod = new System.Windows.Forms.Button();
            this.dtpDatumTransakcijePrihod = new System.Windows.Forms.DateTimePicker();
            this.cboBankovniRacunPrihod = new System.Windows.Forms.ComboBox();
            this.bankovniracunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtOpisPrihod = new System.Windows.Forms.TextBox();
            this.txtIznosPrihod = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblBankovniRacun = new System.Windows.Forms.Label();
            this.lblNoviPrihod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrediKategorijuPrihod
            // 
            this.btnUrediKategorijuPrihod.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnUrediKategorijuPrihod.FlatAppearance.BorderSize = 2;
            this.btnUrediKategorijuPrihod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrediKategorijuPrihod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrediKategorijuPrihod.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUrediKategorijuPrihod.Location = new System.Drawing.Point(750, 489);
            this.btnUrediKategorijuPrihod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUrediKategorijuPrihod.Name = "btnUrediKategorijuPrihod";
            this.btnUrediKategorijuPrihod.Size = new System.Drawing.Size(224, 39);
            this.btnUrediKategorijuPrihod.TabIndex = 37;
            this.btnUrediKategorijuPrihod.Text = "Uredi kategoriju";
            this.btnUrediKategorijuPrihod.UseVisualStyleBackColor = true;
            this.btnUrediKategorijuPrihod.Click += new System.EventHandler(this.btnUrediKategorijuPrihod_Click);
            // 
            // lblNeispravanIznos
            // 
            this.lblNeispravanIznos.AutoSize = true;
            this.lblNeispravanIznos.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNeispravanIznos.ForeColor = System.Drawing.Color.Red;
            this.lblNeispravanIznos.Location = new System.Drawing.Point(228, 256);
            this.lblNeispravanIznos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNeispravanIznos.Name = "lblNeispravanIznos";
            this.lblNeispravanIznos.Size = new System.Drawing.Size(254, 30);
            this.lblNeispravanIznos.TabIndex = 36;
            this.lblNeispravanIznos.Text = "Neispravno unesen iznos!";
            // 
            // chkKategorijePrihod
            // 
            this.chkKategorijePrihod.CheckOnClick = true;
            this.chkKategorijePrihod.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkKategorijePrihod.FormattingEnabled = true;
            this.chkKategorijePrihod.Location = new System.Drawing.Point(750, 141);
            this.chkKategorijePrihod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkKategorijePrihod.Name = "chkKategorijePrihod";
            this.chkKategorijePrihod.Size = new System.Drawing.Size(224, 301);
            this.chkKategorijePrihod.TabIndex = 35;
            this.chkKategorijePrihod.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkKategorijePrihod_MouseUp);
            // 
            // btnIzbrisiKategorijuPrihod
            // 
            this.btnIzbrisiKategorijuPrihod.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnIzbrisiKategorijuPrihod.FlatAppearance.BorderSize = 2;
            this.btnIzbrisiKategorijuPrihod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiKategorijuPrihod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiKategorijuPrihod.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnIzbrisiKategorijuPrihod.Location = new System.Drawing.Point(750, 532);
            this.btnIzbrisiKategorijuPrihod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzbrisiKategorijuPrihod.Name = "btnIzbrisiKategorijuPrihod";
            this.btnIzbrisiKategorijuPrihod.Size = new System.Drawing.Size(224, 39);
            this.btnIzbrisiKategorijuPrihod.TabIndex = 34;
            this.btnIzbrisiKategorijuPrihod.Text = "Izbriši kategoriju";
            this.btnIzbrisiKategorijuPrihod.UseVisualStyleBackColor = true;
            this.btnIzbrisiKategorijuPrihod.Click += new System.EventHandler(this.btnIzbrisiKategorijuPrihod_Click);
            // 
            // btnDodajKategorijuPrihod
            // 
            this.btnDodajKategorijuPrihod.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnDodajKategorijuPrihod.FlatAppearance.BorderSize = 2;
            this.btnDodajKategorijuPrihod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajKategorijuPrihod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajKategorijuPrihod.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDodajKategorijuPrihod.Location = new System.Drawing.Point(750, 446);
            this.btnDodajKategorijuPrihod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajKategorijuPrihod.Name = "btnDodajKategorijuPrihod";
            this.btnDodajKategorijuPrihod.Size = new System.Drawing.Size(224, 39);
            this.btnDodajKategorijuPrihod.TabIndex = 33;
            this.btnDodajKategorijuPrihod.Text = "Dodaj kategoriju";
            this.btnDodajKategorijuPrihod.UseVisualStyleBackColor = true;
            this.btnDodajKategorijuPrihod.Click += new System.EventHandler(this.btnDodajKategorijuPrihod_Click);
            // 
            // lblKategorije
            // 
            this.lblKategorije.AutoSize = true;
            this.lblKategorije.BackColor = System.Drawing.Color.White;
            this.lblKategorije.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorije.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKategorije.Location = new System.Drawing.Point(751, 101);
            this.lblKategorije.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategorije.Name = "lblKategorije";
            this.lblKategorije.Size = new System.Drawing.Size(238, 37);
            this.lblKategorije.TabIndex = 32;
            this.lblKategorije.Text = "Kategorije prihoda:";
            // 
            // dtpVrijemeTransakcijePrihod
            // 
            this.dtpVrijemeTransakcijePrihod.CalendarFont = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpVrijemeTransakcijePrihod.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.dtpVrijemeTransakcijePrihod.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijemeTransakcijePrihod.Location = new System.Drawing.Point(478, 328);
            this.dtpVrijemeTransakcijePrihod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpVrijemeTransakcijePrihod.Name = "dtpVrijemeTransakcijePrihod";
            this.dtpVrijemeTransakcijePrihod.ShowUpDown = true;
            this.dtpVrijemeTransakcijePrihod.Size = new System.Drawing.Size(117, 43);
            this.dtpVrijemeTransakcijePrihod.TabIndex = 31;
            // 
            // btnSpremiTransakcijuPrihod
            // 
            this.btnSpremiTransakcijuPrihod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSpremiTransakcijuPrihod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiTransakcijuPrihod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiTransakcijuPrihod.ForeColor = System.Drawing.Color.White;
            this.btnSpremiTransakcijuPrihod.Location = new System.Drawing.Point(290, 662);
            this.btnSpremiTransakcijuPrihod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpremiTransakcijuPrihod.Name = "btnSpremiTransakcijuPrihod";
            this.btnSpremiTransakcijuPrihod.Size = new System.Drawing.Size(261, 54);
            this.btnSpremiTransakcijuPrihod.TabIndex = 30;
            this.btnSpremiTransakcijuPrihod.Text = "Spremi transakciju";
            this.btnSpremiTransakcijuPrihod.UseVisualStyleBackColor = false;
            this.btnSpremiTransakcijuPrihod.Click += new System.EventHandler(this.btnSpremiTransakcijuPrihod_Click);
            // 
            // dtpDatumTransakcijePrihod
            // 
            this.dtpDatumTransakcijePrihod.CalendarFont = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatumTransakcijePrihod.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.dtpDatumTransakcijePrihod.Location = new System.Drawing.Point(223, 328);
            this.dtpDatumTransakcijePrihod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatumTransakcijePrihod.Name = "dtpDatumTransakcijePrihod";
            this.dtpDatumTransakcijePrihod.Size = new System.Drawing.Size(246, 43);
            this.dtpDatumTransakcijePrihod.TabIndex = 23;
            // 
            // cboBankovniRacunPrihod
            // 
            this.cboBankovniRacunPrihod.DataSource = this.bankovniracunBindingSource;
            this.cboBankovniRacunPrihod.DisplayMember = "naziv_racuna";
            this.cboBankovniRacunPrihod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboBankovniRacunPrihod.FormattingEnabled = true;
            this.cboBankovniRacunPrihod.Location = new System.Drawing.Point(223, 101);
            this.cboBankovniRacunPrihod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBankovniRacunPrihod.Name = "cboBankovniRacunPrihod";
            this.cboBankovniRacunPrihod.Size = new System.Drawing.Size(319, 44);
            this.cboBankovniRacunPrihod.TabIndex = 19;
            this.cboBankovniRacunPrihod.ValueMember = "iban";
            // 
            // bankovniracunBindingSource
            // 
            this.bankovniracunBindingSource.DataSource = typeof(PocetniZaslon.Bankovni_racun);
            // 
            // txtOpisPrihod
            // 
            this.txtOpisPrihod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpisPrihod.Location = new System.Drawing.Point(223, 395);
            this.txtOpisPrihod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpisPrihod.Multiline = true;
            this.txtOpisPrihod.Name = "txtOpisPrihod";
            this.txtOpisPrihod.Size = new System.Drawing.Size(500, 171);
            this.txtOpisPrihod.TabIndex = 25;
            // 
            // txtIznosPrihod
            // 
            this.txtIznosPrihod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIznosPrihod.Location = new System.Drawing.Point(223, 211);
            this.txtIznosPrihod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIznosPrihod.Name = "txtIznosPrihod";
            this.txtIznosPrihod.Size = new System.Drawing.Size(500, 43);
            this.txtIznosPrihod.TabIndex = 21;
            this.txtIznosPrihod.TextChanged += new System.EventHandler(this.txtIznosPrihod_TextChanged);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.BackColor = System.Drawing.Color.White;
            this.lblOpis.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOpis.Location = new System.Drawing.Point(15, 398);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(204, 37);
            this.lblOpis.TabIndex = 26;
            this.lblOpis.Text = "Opis transakcije:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.White;
            this.lblDatum.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDatum.Location = new System.Drawing.Point(-13, 333);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(232, 37);
            this.lblDatum.TabIndex = 24;
            this.lblDatum.Text = "Datum transakcije:";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.BackColor = System.Drawing.Color.White;
            this.lblIznos.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIznos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIznos.Location = new System.Drawing.Point(7, 214);
            this.lblIznos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(212, 37);
            this.lblIznos.TabIndex = 22;
            this.lblIznos.Text = "Iznos transakcije:";
            // 
            // lblBankovniRacun
            // 
            this.lblBankovniRacun.AutoSize = true;
            this.lblBankovniRacun.BackColor = System.Drawing.Color.White;
            this.lblBankovniRacun.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBankovniRacun.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBankovniRacun.Location = new System.Drawing.Point(19, 104);
            this.lblBankovniRacun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankovniRacun.Name = "lblBankovniRacun";
            this.lblBankovniRacun.Size = new System.Drawing.Size(200, 37);
            this.lblBankovniRacun.TabIndex = 20;
            this.lblBankovniRacun.Text = "Bankovni račun:";
            // 
            // lblNoviPrihod
            // 
            this.lblNoviPrihod.AutoSize = true;
            this.lblNoviPrihod.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNoviPrihod.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNoviPrihod.Location = new System.Drawing.Point(279, 1);
            this.lblNoviPrihod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoviPrihod.Name = "lblNoviPrihod";
            this.lblNoviPrihod.Size = new System.Drawing.Size(299, 65);
            this.lblNoviPrihod.TabIndex = 18;
            this.lblNoviPrihod.Text = "Novi prihod";
            // 
            // FrmUnosTransakcijaPrihod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 717);
            this.Controls.Add(this.btnUrediKategorijuPrihod);
            this.Controls.Add(this.lblNeispravanIznos);
            this.Controls.Add(this.chkKategorijePrihod);
            this.Controls.Add(this.btnIzbrisiKategorijuPrihod);
            this.Controls.Add(this.btnDodajKategorijuPrihod);
            this.Controls.Add(this.lblKategorije);
            this.Controls.Add(this.dtpVrijemeTransakcijePrihod);
            this.Controls.Add(this.btnSpremiTransakcijuPrihod);
            this.Controls.Add(this.dtpDatumTransakcijePrihod);
            this.Controls.Add(this.cboBankovniRacunPrihod);
            this.Controls.Add(this.txtOpisPrihod);
            this.Controls.Add(this.txtIznosPrihod);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblBankovniRacun);
            this.Controls.Add(this.lblNoviPrihod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUnosTransakcijaPrihod";
            this.Text = "FrmUnosTransakcijaPrihod_Interni";
            this.Load += new System.EventHandler(this.FrmUnosTransakcijaPrihod_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmUnosTransakcijaPrihod_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrediKategorijuPrihod;
        private System.Windows.Forms.Label lblNeispravanIznos;
        private System.Windows.Forms.CheckedListBox chkKategorijePrihod;
        private System.Windows.Forms.Button btnIzbrisiKategorijuPrihod;
        private System.Windows.Forms.Button btnDodajKategorijuPrihod;
        private System.Windows.Forms.Label lblKategorije;
        private System.Windows.Forms.DateTimePicker dtpVrijemeTransakcijePrihod;
        private System.Windows.Forms.Button btnSpremiTransakcijuPrihod;
        private System.Windows.Forms.DateTimePicker dtpDatumTransakcijePrihod;
        private System.Windows.Forms.ComboBox cboBankovniRacunPrihod;
        private System.Windows.Forms.TextBox txtOpisPrihod;
        private System.Windows.Forms.TextBox txtIznosPrihod;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblBankovniRacun;
        private System.Windows.Forms.Label lblNoviPrihod;
        private System.Windows.Forms.BindingSource bankovniracunBindingSource;
    }
}