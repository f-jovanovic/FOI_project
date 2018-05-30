namespace PocetniZaslon.MDI_Forme
{
    partial class FrmUnosTransakcijaTrosak
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
            this.lblNoviTrosak = new System.Windows.Forms.Label();
            this.lblBankovniRacun = new System.Windows.Forms.Label();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblSlika = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cboBankovniRacun = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSkenirajBarkod = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.btnSpremiTransakcijuTrosak = new System.Windows.Forms.Button();
            this.bankovniracunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoviTrosak
            // 
            this.lblNoviTrosak.AutoSize = true;
            this.lblNoviTrosak.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNoviTrosak.Location = new System.Drawing.Point(385, 3);
            this.lblNoviTrosak.Name = "lblNoviTrosak";
            this.lblNoviTrosak.Size = new System.Drawing.Size(362, 81);
            this.lblNoviTrosak.TabIndex = 1;
            this.lblNoviTrosak.Text = "Novi trošak";
            // 
            // lblBankovniRacun
            // 
            this.lblBankovniRacun.AutoSize = true;
            this.lblBankovniRacun.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBankovniRacun.Location = new System.Drawing.Point(116, 123);
            this.lblBankovniRacun.Name = "lblBankovniRacun";
            this.lblBankovniRacun.Size = new System.Drawing.Size(250, 46);
            this.lblBankovniRacun.TabIndex = 2;
            this.lblBankovniRacun.Text = "Bankovni račun:";
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIBAN.Location = new System.Drawing.Point(109, 205);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(257, 46);
            this.lblIBAN.TabIndex = 3;
            this.lblIBAN.Text = "IBAN primatelja:";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIznos.Location = new System.Drawing.Point(101, 287);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(265, 46);
            this.lblIznos.TabIndex = 4;
            this.lblIznos.Text = "Iznos transakcije:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.Location = new System.Drawing.Point(78, 369);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(288, 46);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum transakcije:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(109, 451);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(257, 46);
            this.lblOpis.TabIndex = 6;
            this.lblOpis.Text = "Opis transakcije:";
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSlika.Location = new System.Drawing.Point(165, 717);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(201, 46);
            this.lblSlika.TabIndex = 7;
            this.lblSlika.Text = "Slika računa:";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIBAN.Location = new System.Drawing.Point(377, 205);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(665, 51);
            this.txtIBAN.TabIndex = 2;
            // 
            // txtIznos
            // 
            this.txtIznos.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIznos.Location = new System.Drawing.Point(377, 287);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(665, 51);
            this.txtIznos.TabIndex = 3;
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(377, 451);
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
            this.cboBankovniRacun.Location = new System.Drawing.Point(377, 123);
            this.cboBankovniRacun.Name = "cboBankovniRacun";
            this.cboBankovniRacun.Size = new System.Drawing.Size(424, 53);
            this.cboBankovniRacun.TabIndex = 1;
            this.cboBankovniRacun.ValueMember = "iban";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.dateTimePicker1.Location = new System.Drawing.Point(377, 369);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(326, 51);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnSkenirajBarkod
            // 
            this.btnSkenirajBarkod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkenirajBarkod.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkenirajBarkod.Location = new System.Drawing.Point(711, 717);
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
            this.btnDodajSliku.Location = new System.Drawing.Point(377, 717);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(309, 53);
            this.btnDodajSliku.TabIndex = 6;
            this.btnDodajSliku.Text = "Dodaj sliku računa";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            // 
            // btnSpremiTransakcijuTrosak
            // 
            this.btnSpremiTransakcijuTrosak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiTransakcijuTrosak.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiTransakcijuTrosak.Location = new System.Drawing.Point(399, 812);
            this.btnSpremiTransakcijuTrosak.Name = "btnSpremiTransakcijuTrosak";
            this.btnSpremiTransakcijuTrosak.Size = new System.Drawing.Size(348, 66);
            this.btnSpremiTransakcijuTrosak.TabIndex = 8;
            this.btnSpremiTransakcijuTrosak.Text = "Spremi transakciju";
            this.btnSpremiTransakcijuTrosak.UseVisualStyleBackColor = true;
            // 
            // bankovniracunBindingSource
            // 
            this.bankovniracunBindingSource.DataSource = typeof(PocetniZaslon.Bankovni_racun);
            // 
            // FrmUnosTransakcijaTrosak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 883);
            this.Controls.Add(this.btnSpremiTransakcijuTrosak);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.btnSkenirajBarkod);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboBankovniRacun);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtIBAN);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblIBAN);
            this.Controls.Add(this.lblBankovniRacun);
            this.Controls.Add(this.lblNoviTrosak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUnosTransakcijaTrosak";
            this.Text = "FrmUnosTransakcijaTrosak";
            this.Load += new System.EventHandler(this.FrmUnosTransakcijaTrosak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoviTrosak;
        private System.Windows.Forms.Label lblBankovniRacun;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.ComboBox cboBankovniRacun;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSkenirajBarkod;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Button btnSpremiTransakcijuTrosak;
        private System.Windows.Forms.BindingSource bankovniracunBindingSource;
    }
}