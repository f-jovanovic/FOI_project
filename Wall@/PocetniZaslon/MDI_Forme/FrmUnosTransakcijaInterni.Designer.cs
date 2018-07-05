namespace PocetniZaslon.MDI_Forme
{
    partial class FrmUnosTransakcijaInterni
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
            this.lblNeispravanIznos = new System.Windows.Forms.Label();
            this.dtpVrijemeTransakcijeInterni = new System.Windows.Forms.DateTimePicker();
            this.btnSpremiTransakcijuInterni = new System.Windows.Forms.Button();
            this.bankovniracunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDatumTransakcijeInterni = new System.Windows.Forms.DateTimePicker();
            this.cboBankovniRacunPosiljateljInterni = new System.Windows.Forms.ComboBox();
            this.txtOpisInterni = new System.Windows.Forms.TextBox();
            this.txtIznosInterni = new System.Windows.Forms.TextBox();
            this.lblOpisInterni = new System.Windows.Forms.Label();
            this.lblDatumInterni = new System.Windows.Forms.Label();
            this.lblIznosInterni = new System.Windows.Forms.Label();
            this.lblBankovniRacunPosiljatelj = new System.Windows.Forms.Label();
            this.lblNoviInterni = new System.Windows.Forms.Label();
            this.lblBankovniRacunPrimatelj = new System.Windows.Forms.Label();
            this.cboBankovniRacunPrimateljInterni = new System.Windows.Forms.ComboBox();
            this.bankovniracunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblBankovniError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNeispravanIznos
            // 
            this.lblNeispravanIznos.AutoSize = true;
            this.lblNeispravanIznos.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNeispravanIznos.ForeColor = System.Drawing.Color.Red;
            this.lblNeispravanIznos.Location = new System.Drawing.Point(237, 286);
            this.lblNeispravanIznos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNeispravanIznos.Name = "lblNeispravanIznos";
            this.lblNeispravanIznos.Size = new System.Drawing.Size(254, 30);
            this.lblNeispravanIznos.TabIndex = 53;
            this.lblNeispravanIznos.Text = "Neispravno unesen iznos!";
            // 
            // dtpVrijemeTransakcijeInterni
            // 
            this.dtpVrijemeTransakcijeInterni.CalendarFont = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpVrijemeTransakcijeInterni.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.dtpVrijemeTransakcijeInterni.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijemeTransakcijeInterni.Location = new System.Drawing.Point(487, 328);
            this.dtpVrijemeTransakcijeInterni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpVrijemeTransakcijeInterni.Name = "dtpVrijemeTransakcijeInterni";
            this.dtpVrijemeTransakcijeInterni.ShowUpDown = true;
            this.dtpVrijemeTransakcijeInterni.Size = new System.Drawing.Size(117, 43);
            this.dtpVrijemeTransakcijeInterni.TabIndex = 48;
            // 
            // btnSpremiTransakcijuInterni
            // 
            this.btnSpremiTransakcijuInterni.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSpremiTransakcijuInterni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiTransakcijuInterni.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiTransakcijuInterni.ForeColor = System.Drawing.Color.White;
            this.btnSpremiTransakcijuInterni.Location = new System.Drawing.Point(299, 662);
            this.btnSpremiTransakcijuInterni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpremiTransakcijuInterni.Name = "btnSpremiTransakcijuInterni";
            this.btnSpremiTransakcijuInterni.Size = new System.Drawing.Size(261, 54);
            this.btnSpremiTransakcijuInterni.TabIndex = 47;
            this.btnSpremiTransakcijuInterni.Text = "Spremi transakciju";
            this.btnSpremiTransakcijuInterni.UseVisualStyleBackColor = false;
            this.btnSpremiTransakcijuInterni.Click += new System.EventHandler(this.btnSpremiTransakcijuInterni_Click);
            // 
            // bankovniracunBindingSource
            // 
            this.bankovniracunBindingSource.DataSource = typeof(PocetniZaslon.Bankovni_racun);
            // 
            // dtpDatumTransakcijeInterni
            // 
            this.dtpDatumTransakcijeInterni.CalendarFont = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatumTransakcijeInterni.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.dtpDatumTransakcijeInterni.Location = new System.Drawing.Point(232, 328);
            this.dtpDatumTransakcijeInterni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatumTransakcijeInterni.Name = "dtpDatumTransakcijeInterni";
            this.dtpDatumTransakcijeInterni.Size = new System.Drawing.Size(246, 43);
            this.dtpDatumTransakcijeInterni.TabIndex = 43;
            // 
            // cboBankovniRacunPosiljateljInterni
            // 
            this.cboBankovniRacunPosiljateljInterni.DataSource = this.bankovniracunBindingSource;
            this.cboBankovniRacunPosiljateljInterni.DisplayMember = "naziv_racuna";
            this.cboBankovniRacunPosiljateljInterni.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboBankovniRacunPosiljateljInterni.FormattingEnabled = true;
            this.cboBankovniRacunPosiljateljInterni.Location = new System.Drawing.Point(232, 98);
            this.cboBankovniRacunPosiljateljInterni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBankovniRacunPosiljateljInterni.Name = "cboBankovniRacunPosiljateljInterni";
            this.cboBankovniRacunPosiljateljInterni.Size = new System.Drawing.Size(319, 44);
            this.cboBankovniRacunPosiljateljInterni.TabIndex = 39;
            this.cboBankovniRacunPosiljateljInterni.ValueMember = "iban";
            this.cboBankovniRacunPosiljateljInterni.SelectedIndexChanged += new System.EventHandler(this.cboBankovniRacunPosiljateljInterni_SelectedIndexChanged);
            // 
            // txtOpisInterni
            // 
            this.txtOpisInterni.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpisInterni.Location = new System.Drawing.Point(232, 395);
            this.txtOpisInterni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpisInterni.Multiline = true;
            this.txtOpisInterni.Name = "txtOpisInterni";
            this.txtOpisInterni.Size = new System.Drawing.Size(500, 171);
            this.txtOpisInterni.TabIndex = 45;
            // 
            // txtIznosInterni
            // 
            this.txtIznosInterni.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIznosInterni.Location = new System.Drawing.Point(232, 243);
            this.txtIznosInterni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIznosInterni.Name = "txtIznosInterni";
            this.txtIznosInterni.Size = new System.Drawing.Size(500, 43);
            this.txtIznosInterni.TabIndex = 41;
            this.txtIznosInterni.TextChanged += new System.EventHandler(this.txtIznosInterni_TextChanged);
            // 
            // lblOpisInterni
            // 
            this.lblOpisInterni.AutoSize = true;
            this.lblOpisInterni.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisInterni.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOpisInterni.Location = new System.Drawing.Point(24, 398);
            this.lblOpisInterni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpisInterni.Name = "lblOpisInterni";
            this.lblOpisInterni.Size = new System.Drawing.Size(204, 37);
            this.lblOpisInterni.TabIndex = 46;
            this.lblOpisInterni.Text = "Opis transakcije:";
            // 
            // lblDatumInterni
            // 
            this.lblDatumInterni.AutoSize = true;
            this.lblDatumInterni.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumInterni.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDatumInterni.Location = new System.Drawing.Point(-4, 333);
            this.lblDatumInterni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatumInterni.Name = "lblDatumInterni";
            this.lblDatumInterni.Size = new System.Drawing.Size(232, 37);
            this.lblDatumInterni.TabIndex = 44;
            this.lblDatumInterni.Text = "Datum transakcije:";
            // 
            // lblIznosInterni
            // 
            this.lblIznosInterni.AutoSize = true;
            this.lblIznosInterni.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIznosInterni.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIznosInterni.Location = new System.Drawing.Point(16, 246);
            this.lblIznosInterni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznosInterni.Name = "lblIznosInterni";
            this.lblIznosInterni.Size = new System.Drawing.Size(212, 37);
            this.lblIznosInterni.TabIndex = 42;
            this.lblIznosInterni.Text = "Iznos transakcije:";
            // 
            // lblBankovniRacunPosiljatelj
            // 
            this.lblBankovniRacunPosiljatelj.AutoSize = true;
            this.lblBankovniRacunPosiljatelj.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBankovniRacunPosiljatelj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBankovniRacunPosiljatelj.Location = new System.Drawing.Point(51, 101);
            this.lblBankovniRacunPosiljatelj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankovniRacunPosiljatelj.Name = "lblBankovniRacunPosiljatelj";
            this.lblBankovniRacunPosiljatelj.Size = new System.Drawing.Size(177, 37);
            this.lblBankovniRacunPosiljatelj.TabIndex = 40;
            this.lblBankovniRacunPosiljatelj.Text = "Polazni račun:";
            // 
            // lblNoviInterni
            // 
            this.lblNoviInterni.AutoSize = true;
            this.lblNoviInterni.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNoviInterni.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNoviInterni.Location = new System.Drawing.Point(200, 0);
            this.lblNoviInterni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoviInterni.Name = "lblNoviInterni";
            this.lblNoviInterni.Size = new System.Drawing.Size(493, 65);
            this.lblNoviInterni.TabIndex = 38;
            this.lblNoviInterni.Text = "Novi interni prijenos";
            // 
            // lblBankovniRacunPrimatelj
            // 
            this.lblBankovniRacunPrimatelj.AutoSize = true;
            this.lblBankovniRacunPrimatelj.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBankovniRacunPrimatelj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBankovniRacunPrimatelj.Location = new System.Drawing.Point(62, 148);
            this.lblBankovniRacunPrimatelj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankovniRacunPrimatelj.Name = "lblBankovniRacunPrimatelj";
            this.lblBankovniRacunPrimatelj.Size = new System.Drawing.Size(166, 37);
            this.lblBankovniRacunPrimatelj.TabIndex = 54;
            this.lblBankovniRacunPrimatelj.Text = "Krajnji račun:";
            // 
            // cboBankovniRacunPrimateljInterni
            // 
            this.cboBankovniRacunPrimateljInterni.DataSource = this.bankovniracunBindingSource1;
            this.cboBankovniRacunPrimateljInterni.DisplayMember = "naziv_racuna";
            this.cboBankovniRacunPrimateljInterni.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboBankovniRacunPrimateljInterni.FormattingEnabled = true;
            this.cboBankovniRacunPrimateljInterni.Location = new System.Drawing.Point(232, 145);
            this.cboBankovniRacunPrimateljInterni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBankovniRacunPrimateljInterni.Name = "cboBankovniRacunPrimateljInterni";
            this.cboBankovniRacunPrimateljInterni.Size = new System.Drawing.Size(319, 44);
            this.cboBankovniRacunPrimateljInterni.TabIndex = 55;
            this.cboBankovniRacunPrimateljInterni.ValueMember = "iban";
            this.cboBankovniRacunPrimateljInterni.SelectedIndexChanged += new System.EventHandler(this.cboBankovniRacunPrimateljInterni_SelectedIndexChanged);
            // 
            // bankovniracunBindingSource1
            // 
            this.bankovniracunBindingSource1.DataSource = typeof(PocetniZaslon.Bankovni_racun);
            // 
            // lblBankovniError
            // 
            this.lblBankovniError.AutoSize = true;
            this.lblBankovniError.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBankovniError.ForeColor = System.Drawing.Color.Red;
            this.lblBankovniError.Location = new System.Drawing.Point(237, 189);
            this.lblBankovniError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankovniError.Name = "lblBankovniError";
            this.lblBankovniError.Size = new System.Drawing.Size(366, 30);
            this.lblBankovniError.TabIndex = 56;
            this.lblBankovniError.Text = "Bankovni računi se moraju razlikovati!";
            // 
            // FrmUnosTransakcijaInterni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 717);
            this.Controls.Add(this.lblBankovniError);
            this.Controls.Add(this.cboBankovniRacunPrimateljInterni);
            this.Controls.Add(this.lblBankovniRacunPrimatelj);
            this.Controls.Add(this.lblNeispravanIznos);
            this.Controls.Add(this.dtpVrijemeTransakcijeInterni);
            this.Controls.Add(this.btnSpremiTransakcijuInterni);
            this.Controls.Add(this.dtpDatumTransakcijeInterni);
            this.Controls.Add(this.cboBankovniRacunPosiljateljInterni);
            this.Controls.Add(this.txtOpisInterni);
            this.Controls.Add(this.txtIznosInterni);
            this.Controls.Add(this.lblOpisInterni);
            this.Controls.Add(this.lblDatumInterni);
            this.Controls.Add(this.lblIznosInterni);
            this.Controls.Add(this.lblBankovniRacunPosiljatelj);
            this.Controls.Add(this.lblNoviInterni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUnosTransakcijaInterni";
            this.Text = "FrmUnosTransakcijaInterni";
            this.Load += new System.EventHandler(this.FrmUnosTransakcijaInterni_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmUnosTransakcijaInterni_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankovniracunBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNeispravanIznos;
        private System.Windows.Forms.DateTimePicker dtpVrijemeTransakcijeInterni;
        private System.Windows.Forms.Button btnSpremiTransakcijuInterni;
        private System.Windows.Forms.BindingSource bankovniracunBindingSource;
        private System.Windows.Forms.DateTimePicker dtpDatumTransakcijeInterni;
        private System.Windows.Forms.ComboBox cboBankovniRacunPosiljateljInterni;
        private System.Windows.Forms.TextBox txtOpisInterni;
        private System.Windows.Forms.TextBox txtIznosInterni;
        private System.Windows.Forms.Label lblOpisInterni;
        private System.Windows.Forms.Label lblDatumInterni;
        private System.Windows.Forms.Label lblIznosInterni;
        private System.Windows.Forms.Label lblBankovniRacunPosiljatelj;
        private System.Windows.Forms.Label lblNoviInterni;
        private System.Windows.Forms.Label lblBankovniRacunPrimatelj;
        private System.Windows.Forms.ComboBox cboBankovniRacunPrimateljInterni;
        private System.Windows.Forms.BindingSource bankovniracunBindingSource1;
        private System.Windows.Forms.Label lblBankovniError;
    }
}