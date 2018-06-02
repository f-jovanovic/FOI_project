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
            this.btnUrediKategoriju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoviRashod
            // 
            this.lblNoviRashod.AutoSize = true;
            this.lblNoviRashod.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.lblBankovniRacun.Location = new System.Drawing.Point(40, 102);
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
            this.lblIznos.Location = new System.Drawing.Point(26, 202);
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
            this.lblDatum.Location = new System.Drawing.Point(9, 302);
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
            this.lblOpis.Location = new System.Drawing.Point(32, 370);
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
            this.lblSlika.Location = new System.Drawing.Point(74, 586);
            this.lblSlika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(162, 37);
            this.lblSlika.TabIndex = 7;
            this.lblSlika.Text = "Slika računa:";
            // 
            // txtIznos
            // 
            this.txtIznos.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIznos.Location = new System.Drawing.Point(233, 202);
            this.txtIznos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(500, 43);
            this.txtIznos.TabIndex = 3;
            this.txtIznos.TextChanged += new System.EventHandler(this.txtIznos_TextChanged);
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(233, 370);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(500, 171);
            this.txtOpis.TabIndex = 5;
            // 
            // cboBankovniRacun
            // 
            this.cboBankovniRacun.DataSource = this.bankovniracunBindingSource;
            this.cboBankovniRacun.DisplayMember = "naziv_racuna";
            this.cboBankovniRacun.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboBankovniRacun.FormattingEnabled = true;
            this.cboBankovniRacun.Location = new System.Drawing.Point(233, 102);
            this.cboBankovniRacun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBankovniRacun.Name = "cboBankovniRacun";
            this.cboBankovniRacun.Size = new System.Drawing.Size(319, 44);
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
            this.dtpDatumTransakcijeRashod.Location = new System.Drawing.Point(233, 303);
            this.dtpDatumTransakcijeRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatumTransakcijeRashod.Name = "dtpDatumTransakcijeRashod";
            this.dtpDatumTransakcijeRashod.Size = new System.Drawing.Size(246, 43);
            this.dtpDatumTransakcijeRashod.TabIndex = 4;
            // 
            // btnSkenirajBarkod
            // 
            this.btnSkenirajBarkod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkenirajBarkod.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkenirajBarkod.Location = new System.Drawing.Point(484, 586);
            this.btnSkenirajBarkod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSkenirajBarkod.Name = "btnSkenirajBarkod";
            this.btnSkenirajBarkod.Size = new System.Drawing.Size(248, 43);
            this.btnSkenirajBarkod.TabIndex = 7;
            this.btnSkenirajBarkod.Text = "Skeniraj barkod računa";
            this.btnSkenirajBarkod.UseVisualStyleBackColor = true;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajSliku.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajSliku.Location = new System.Drawing.Point(233, 586);
            this.btnDodajSliku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(232, 43);
            this.btnDodajSliku.TabIndex = 6;
            this.btnDodajSliku.Text = "Dodaj sliku računa";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            // 
            // btnSpremiTransakcijuRashod
            // 
            this.btnSpremiTransakcijuRashod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiTransakcijuRashod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiTransakcijuRashod.Location = new System.Drawing.Point(300, 663);
            this.btnSpremiTransakcijuRashod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpremiTransakcijuRashod.Name = "btnSpremiTransakcijuRashod";
            this.btnSpremiTransakcijuRashod.Size = new System.Drawing.Size(261, 54);
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
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajKategoriju.Location = new System.Drawing.Point(760, 499);
            this.btnDodajKategoriju.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(224, 32);
            this.btnDodajKategoriju.TabIndex = 12;
            this.btnDodajKategoriju.Text = "Dodaj kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // btnIzbrisiKategoriju
            // 
            this.btnIzbrisiKategoriju.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiKategoriju.Location = new System.Drawing.Point(760, 571);
            this.btnIzbrisiKategoriju.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzbrisiKategoriju.Name = "btnIzbrisiKategoriju";
            this.btnIzbrisiKategoriju.Size = new System.Drawing.Size(224, 32);
            this.btnIzbrisiKategoriju.TabIndex = 14;
            this.btnIzbrisiKategoriju.Text = "Izbriši kategoriju";
            this.btnIzbrisiKategoriju.UseVisualStyleBackColor = true;
            this.btnIzbrisiKategoriju.Click += new System.EventHandler(this.btnIzbrisiKategoriju_Click);
            // 
            // chkKategorije
            // 
            this.chkKategorije.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkKategorije.FormattingEnabled = true;
            this.chkKategorije.Location = new System.Drawing.Point(760, 142);
            this.chkKategorije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkKategorije.Name = "chkKategorije";
            this.chkKategorije.Size = new System.Drawing.Size(224, 328);
            this.chkKategorije.TabIndex = 15;
            this.chkKategorije.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkKategorije_MouseUp);
            // 
            // lblNeispravanIznos
            // 
            this.lblNeispravanIznos.AutoSize = true;
            this.lblNeispravanIznos.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNeispravanIznos.ForeColor = System.Drawing.Color.Red;
            this.lblNeispravanIznos.Location = new System.Drawing.Point(238, 246);
            this.lblNeispravanIznos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNeispravanIznos.Name = "lblNeispravanIznos";
            this.lblNeispravanIznos.Size = new System.Drawing.Size(254, 30);
            this.lblNeispravanIznos.TabIndex = 16;
            this.lblNeispravanIznos.Text = "Neispravno unesen iznos!";
            // 
            // btnUrediKategoriju
            // 
            this.btnUrediKategoriju.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrediKategoriju.Location = new System.Drawing.Point(760, 535);
            this.btnUrediKategoriju.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrediKategoriju.Name = "btnUrediKategoriju";
            this.btnUrediKategoriju.Size = new System.Drawing.Size(224, 32);
            this.btnUrediKategoriju.TabIndex = 17;
            this.btnUrediKategoriju.Text = "Uredi kategoriju";
            this.btnUrediKategoriju.UseVisualStyleBackColor = true;
            this.btnUrediKategoriju.Click += new System.EventHandler(this.btnUrediKategoriju_Click);
            // 
            // FrmUnosTransakcijaRashod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 717);
            this.Controls.Add(this.btnUrediKategoriju);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnUrediKategoriju;
    }
}