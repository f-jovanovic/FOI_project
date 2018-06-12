namespace PocetniZaslon.Dialog_forme
{
    partial class FrmKategorijeTransakcijaDodaj
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
            this.lblNazivKategorije = new System.Windows.Forms.Label();
            this.txtNazivKategorije = new System.Windows.Forms.TextBox();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNazivKategorije
            // 
            this.lblNazivKategorije.AutoSize = true;
            this.lblNazivKategorije.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivKategorije.Location = new System.Drawing.Point(14, 9);
            this.lblNazivKategorije.Name = "lblNazivKategorije";
            this.lblNazivKategorije.Size = new System.Drawing.Size(303, 41);
            this.lblNazivKategorije.TabIndex = 0;
            this.lblNazivKategorije.Text = "Naziv nove kategorije:";
            // 
            // txtNazivKategorije
            // 
            this.txtNazivKategorije.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazivKategorije.Location = new System.Drawing.Point(12, 80);
            this.txtNazivKategorije.Name = "txtNazivKategorije";
            this.txtNazivKategorije.Size = new System.Drawing.Size(305, 43);
            this.txtNazivKategorije.TabIndex = 1;
            this.txtNazivKategorije.TextChanged += new System.EventHandler(this.txtNazivKategorije_TextChanged);
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKategoriju.Location = new System.Drawing.Point(12, 157);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(305, 49);
            this.btnDodajKategoriju.TabIndex = 2;
            this.btnDodajKategoriju.Text = "Dodaj kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // FrmKategorijeTransakcijaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 218);
            this.Controls.Add(this.btnDodajKategoriju);
            this.Controls.Add(this.txtNazivKategorije);
            this.Controls.Add(this.lblNazivKategorije);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKategorijeTransakcijaDodaj";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wall@ | Dodaj novu kategoriju";
            this.Load += new System.EventHandler(this.FrmKategorijeTransakcijaDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivKategorije;
        private System.Windows.Forms.TextBox txtNazivKategorije;
        private System.Windows.Forms.Button btnDodajKategoriju;
    }
}