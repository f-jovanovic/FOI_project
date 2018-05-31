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
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cboBankovniRacun = new System.Windows.Forms.ComboBox();
            this.bankovniracunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDatumTransakcijeRashod = new System.Windows.Forms.DateTimePicker();
            this.btnSkenirajBarkod = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.btnSpremiTransakcijuRashod = new System.Windows.Forms.Button();
            this.dtpVrijemeTransakcijeRashod = new System.Windows.Forms.DateTimePicker();
            this.lblKategorije = new System.Windows.Forms.Label();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.btnIzbrisiKategoriju = new System.Windows.Forms.Button();
            this.chkKategorije = new System.Windows.Forms.CheckedListBox();
            this.lblNeispravanIznos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoviRashod
            // 
            this.lblNoviRashod.AutoSize = true;
            this.lblNoviRashod.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNoviRashod.Location = new System.Drawing.Point(385, 3);
            this.lblNoviRashod.Name = "lblNoviRashod";
            this.lblNoviRashod.Size = new System.Drawing.Size(378, 81);
            this.lblNoviRashod.TabIndex = 1;
            this.lblNoviRashod.Text = "Novi rashod";
            // 
            // lblBankovniRacun
            // 
            this.lblBankovniRacun.AutoSize = true;
            this.lblBankovniRacun.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBankovniRacun.Location = new System.Drawing.Point(53, 126);
            this.lblBankovniRacun.Name = "lblBankovniRacun";
            this.lblBankovniRacun.Size = new System.Drawing.Size(242, 45);
            this.lblBankovniRacun.TabIndex = 2;
            this.lblBankovniRacun.Text = "Bankovni račun:";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIznos.Location = new System.Drawing.Point(35, 249);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(256, 45);
            this.lblIznos.TabIndex = 4;
            this.lblIznos.Text = "Iznos transakcije:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.Location = new System.Drawing.Point(12, 372);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(279, 45);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum transakcije:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(43, 455);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(247, 45);
            this.lblOpis.TabIndex = 6;
            this.lblOpis.Text = "Opis transakcije:";
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSlika.Location = new System.Drawing.Point(99, 721);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(196, 45);
            this.lblSlika.TabIndex = 7;
            this.lblSlika.Text = "Slika računa:";
            // 
            // txtIznos
            // 
            this.txtIznos.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIznos.Location = new System.Drawing.Point(311, 249);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(665, 51);
            this.txtIznos.TabIndex = 3;
            this.txtIznos.TextChanged += new System.EventHandler(this.txtIznos_TextChanged);
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(311, 455);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(665, 209);
            this.txtOpis.TabIndex = 5;
            // 
            // cboBankovniRacun
            // 
            this.cboBankovniRacun.DataSource = this.bankovniracunBindingSource;
            this.cboBankovniRacun.DisplayMember = "naziv_racuna";
            this.cboBankovniRacun.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboBankovniRacun.FormattingEnabled = true;
            this.cboBankovniRacun.Location = new System.Drawing.Point(311, 126);
            this.cboBankovniRacun.Name = "cboBankovniRacun";
            this.cboBankovniRacun.Size = new System.Drawing.Size(424, 53);
            this.cboBankovniRacun.TabIndex = 1;
            this.cboBankovniRacun.ValueMember = "iban";
            // 
            // bankovniracunBindingSource
            // 
            this.bankovniracunBindingSource.DataSource = typeof(PocetniZaslon.Bankovni_racun);
            // 
            // dtpDatumTransakcijeRashod
            // 
            this.dtpDatumTransakcijeRashod.CalendarFont = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatumTransakcijeRashod.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.dtpDatumTransakcijeRashod.Location = new System.Drawing.Point(311, 373);
            this.dtpDatumTransakcijeRashod.Name = "dtpDatumTransakcijeRashod";
            this.dtpDatumTransakcijeRashod.Size = new System.Drawing.Size(326, 51);
            this.dtpDatumTransakcijeRashod.TabIndex = 4;
            // 
            // btnSkenirajBarkod
            // 
            this.btnSkenirajBarkod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkenirajBarkod.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkenirajBarkod.Location = new System.Drawing.Point(645, 721);
            this.btnSkenirajBarkod.Name = "btnSkenirajBarkod";
            this.btnSkenirajBarkod.Size = new System.Drawing.Size(331, 53);
            this.btnSkenirajBarkod.TabIndex = 7;
            this.btnSkenirajBarkod.Text = "Skeniraj barkod računa";
            this.btnSkenirajBarkod.UseVisualStyleBackColor = true;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajSliku.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajSliku.Location = new System.Drawing.Point(311, 721);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(309, 53);
            this.btnDodajSliku.TabIndex = 6;
            this.btnDodajSliku.Text = "Dodaj sliku računa";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            // 
            // btnSpremiTransakcijuRashod
            // 
            this.btnSpremiTransakcijuRashod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiTransakcijuRashod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiTransakcijuRashod.Location = new System.Drawing.Point(400, 816);
            this.btnSpremiTransakcijuRashod.Name = "btnSpremiTransakcijuRashod";
            this.btnSpremiTransakcijuRashod.Size = new System.Drawing.Size(348, 66);
            this.btnSpremiTransakcijuRashod.TabIndex = 8;
            this.btnSpremiTransakcijuRashod.Text = "Spremi transakciju";
            this.btnSpremiTransakcijuRashod.UseVisualStyleBackColor = true;
            this.btnSpremiTransakcijuRashod.Click += new System.EventHandler(this.btnSpremiTransakcijuRashod_Click);
            // 
            // dtpVrijemeTransakcijeRashod
            // 
            this.dtpVrijemeTransakcijeRashod.CalendarFont = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpVrijemeTransakcijeRashod.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.dtpVrijemeTransakcijeRashod.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijemeTransakcijeRashod.Location = new System.Drawing.Point(650, 373);
            this.dtpVrijemeTransakcijeRashod.Name = "dtpVrijemeTransakcijeRashod";
            this.dtpVrijemeTransakcijeRashod.ShowUpDown = true;
            this.dtpVrijemeTransakcijeRashod.Size = new System.Drawing.Size(155, 51);
            this.dtpVrijemeTransakcijeRashod.TabIndex = 9;
            // 
            // lblKategorije
            // 
            this.lblKategorije.AutoSize = true;
            this.lblKategorije.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorije.Location = new System.Drawing.Point(1015, 126);
            this.lblKategorije.Name = "lblKategorije";
            this.lblKategorije.Size = new System.Drawing.Size(292, 45);
            this.lblKategorije.TabIndex = 10;
            this.lblKategorije.Text = "Kategorije rashoda:";
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajKategoriju.Location = new System.Drawing.Point(1013, 614);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(298, 39);
            this.btnDodajKategoriju.TabIndex = 12;
            this.btnDodajKategoriju.Text = "Dodaj kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // btnIzbrisiKategoriju
            // 
            this.btnIzbrisiKategoriju.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiKategoriju.Location = new System.Drawing.Point(1013, 659);
            this.btnIzbrisiKategoriju.Name = "btnIzbrisiKategoriju";
            this.btnIzbrisiKategoriju.Size = new System.Drawing.Size(298, 39);
            this.btnIzbrisiKategoriju.TabIndex = 14;
            this.btnIzbrisiKategoriju.Text = "Izbriši kategoriju";
            this.btnIzbrisiKategoriju.UseVisualStyleBackColor = true;
            this.btnIzbrisiKategoriju.Click += new System.EventHandler(this.btnIzbrisiKategoriju_Click);
            // 
            // chkKategorije
            // 
            this.chkKategorije.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkKategorije.FormattingEnabled = true;
            this.chkKategorije.Location = new System.Drawing.Point(1013, 175);
            this.chkKategorije.Name = "chkKategorije";
            this.chkKategorije.Size = new System.Drawing.Size(298, 433);
            this.chkKategorije.TabIndex = 15;
            this.chkKategorije.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkKategorije_MouseUp);
            // 
            // lblNeispravanIznos
            // 
            this.lblNeispravanIznos.AutoSize = true;
            this.lblNeispravanIznos.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNeispravanIznos.ForeColor = System.Drawing.Color.Red;
            this.lblNeispravanIznos.Location = new System.Drawing.Point(317, 303);
            this.lblNeispravanIznos.Name = "lblNeispravanIznos";
            this.lblNeispravanIznos.Size = new System.Drawing.Size(320, 38);
            this.lblNeispravanIznos.TabIndex = 16;
            this.lblNeispravanIznos.Text = "Neispravno unesen iznos!";
            // 
            // FrmUnosTransakcijaRashod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 883);
            this.Controls.Add(this.lblNeispravanIznos);
            this.Controls.Add(this.chkKategorije);
            this.Controls.Add(this.btnIzbrisiKategoriju);
            this.Controls.Add(this.btnDodajKategoriju);
            this.Controls.Add(this.lblKategorije);
            this.Controls.Add(this.dtpVrijemeTransakcijeRashod);
            this.Controls.Add(this.btnSpremiTransakcijuRashod);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.btnSkenirajBarkod);
            this.Controls.Add(this.dtpDatumTransakcijeRashod);
            this.Controls.Add(this.cboBankovniRacun);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblBankovniRacun);
            this.Controls.Add(this.lblNoviRashod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUnosTransakcijaRashod";
            this.Text = "FrmUnosTransakcijaTrosak";
            this.Load += new System.EventHandler(this.FrmUnosTransakcijaTrosak_Load);
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
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.ComboBox cboBankovniRacun;
        private System.Windows.Forms.DateTimePicker dtpDatumTransakcijeRashod;
        private System.Windows.Forms.Button btnSkenirajBarkod;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Button btnSpremiTransakcijuRashod;
        private System.Windows.Forms.BindingSource bankovniracunBindingSource;
        private System.Windows.Forms.DateTimePicker dtpVrijemeTransakcijeRashod;
        private System.Windows.Forms.Label lblKategorije;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.Button btnIzbrisiKategoriju;
        private System.Windows.Forms.CheckedListBox chkKategorije;
        private System.Windows.Forms.Label lblNeispravanIznos;
    }
}