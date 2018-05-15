namespace PocetniZaslon
{
    partial class FrmRegistracija
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblPonoviLozinku = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtPonoviLozinku = new System.Windows.Forms.TextBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(169, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(348, 45);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Registracija korisnika";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(40, 111);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 32);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(57, 179);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(60, 32);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(12, 247);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(105, 32);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.Location = new System.Drawing.Point(88, 360);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(100, 32);
            this.lblLozinka.TabIndex = 4;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblPonoviLozinku
            // 
            this.lblPonoviLozinku.AutoSize = true;
            this.lblPonoviLozinku.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPonoviLozinku.Location = new System.Drawing.Point(12, 433);
            this.lblPonoviLozinku.Name = "lblPonoviLozinku";
            this.lblPonoviLozinku.Size = new System.Drawing.Size(176, 32);
            this.lblPonoviLozinku.TabIndex = 5;
            this.lblPonoviLozinku.Text = "Ponovi lozinku:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmail.Location = new System.Drawing.Point(123, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(547, 38);
            this.txtEmail.TabIndex = 6;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(123, 176);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(547, 38);
            this.txtIme.TabIndex = 7;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrezime.Location = new System.Drawing.Point(123, 244);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(547, 38);
            this.txtPrezime.TabIndex = 8;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinka.Location = new System.Drawing.Point(194, 357);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(476, 38);
            this.txtLozinka.TabIndex = 9;
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // txtPonoviLozinku
            // 
            this.txtPonoviLozinku.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPonoviLozinku.Location = new System.Drawing.Point(194, 430);
            this.txtPonoviLozinku.Name = "txtPonoviLozinku";
            this.txtPonoviLozinku.Size = new System.Drawing.Size(476, 38);
            this.txtPonoviLozinku.TabIndex = 10;
            this.txtPonoviLozinku.UseSystemPasswordChar = true;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistracija.Location = new System.Drawing.Point(207, 551);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(272, 63);
            this.btnRegistracija.TabIndex = 11;
            this.btnRegistracija.Text = "Registriraj se";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            // 
            // FrmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.txtPonoviLozinku);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPonoviLozinku);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRegistracija";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wall@ | Registracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblPonoviLozinku;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtPonoviLozinku;
        private System.Windows.Forms.Button btnRegistracija;
    }
}