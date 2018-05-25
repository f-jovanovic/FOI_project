namespace PocetniZaslon
{
    partial class FrmGlavniIzbornik
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavniIzbornik));
			this.splitterMenuScreen = new System.Windows.Forms.Splitter();
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.btnOdjava = new System.Windows.Forms.Button();
			this.btnPostavke = new System.Windows.Forms.Button();
			this.btnStatistika = new System.Windows.Forms.Button();
			this.btnInvesticijskiPortfolio = new System.Windows.Forms.Button();
			this.btnPregled = new System.Windows.Forms.Button();
			this.btnUnosTransakcije = new System.Windows.Forms.Button();
			this.btnBankovniRacun = new System.Windows.Forms.Button();
			this.btnZaslon = new System.Windows.Forms.Button();
			this.lblTrenutniKorisnikImePrezime = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// splitterMenuScreen
			// 
			this.splitterMenuScreen.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.splitterMenuScreen.Location = new System.Drawing.Point(0, 0);
			this.splitterMenuScreen.Margin = new System.Windows.Forms.Padding(2);
			this.splitterMenuScreen.Name = "splitterMenuScreen";
			this.splitterMenuScreen.Size = new System.Drawing.Size(194, 800);
			this.splitterMenuScreen.TabIndex = 9;
			this.splitterMenuScreen.TabStop = false;
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
			this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxLogo.Location = new System.Drawing.Point(9, 10);
			this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(175, 158);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxLogo.TabIndex = 18;
			this.pictureBoxLogo.TabStop = false;
			// 
			// btnOdjava
			// 
			this.btnOdjava.BackColor = System.Drawing.Color.White;
			this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOdjava.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnOdjava.Location = new System.Drawing.Point(9, 728);
			this.btnOdjava.Margin = new System.Windows.Forms.Padding(2);
			this.btnOdjava.Name = "btnOdjava";
			this.btnOdjava.Size = new System.Drawing.Size(175, 63);
			this.btnOdjava.TabIndex = 17;
			this.btnOdjava.Text = "Odjava";
			this.btnOdjava.UseVisualStyleBackColor = false;
			this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
			// 
			// btnPostavke
			// 
			this.btnPostavke.BackColor = System.Drawing.Color.White;
			this.btnPostavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPostavke.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnPostavke.Location = new System.Drawing.Point(9, 661);
			this.btnPostavke.Margin = new System.Windows.Forms.Padding(2);
			this.btnPostavke.Name = "btnPostavke";
			this.btnPostavke.Size = new System.Drawing.Size(175, 63);
			this.btnPostavke.TabIndex = 16;
			this.btnPostavke.Text = "Postavke";
			this.btnPostavke.UseVisualStyleBackColor = false;
			this.btnPostavke.Click += new System.EventHandler(this.btnPostavke_Click);
			// 
			// btnStatistika
			// 
			this.btnStatistika.BackColor = System.Drawing.Color.White;
			this.btnStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStatistika.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnStatistika.Location = new System.Drawing.Point(9, 593);
			this.btnStatistika.Margin = new System.Windows.Forms.Padding(2);
			this.btnStatistika.Name = "btnStatistika";
			this.btnStatistika.Size = new System.Drawing.Size(175, 63);
			this.btnStatistika.TabIndex = 15;
			this.btnStatistika.Text = "Statistika";
			this.btnStatistika.UseVisualStyleBackColor = false;
			this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
			// 
			// btnInvesticijskiPortfolio
			// 
			this.btnInvesticijskiPortfolio.BackColor = System.Drawing.Color.White;
			this.btnInvesticijskiPortfolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInvesticijskiPortfolio.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnInvesticijskiPortfolio.Location = new System.Drawing.Point(9, 526);
			this.btnInvesticijskiPortfolio.Margin = new System.Windows.Forms.Padding(2);
			this.btnInvesticijskiPortfolio.Name = "btnInvesticijskiPortfolio";
			this.btnInvesticijskiPortfolio.Size = new System.Drawing.Size(175, 63);
			this.btnInvesticijskiPortfolio.TabIndex = 14;
			this.btnInvesticijskiPortfolio.Text = "Investicijski portfolio";
			this.btnInvesticijskiPortfolio.UseVisualStyleBackColor = false;
			this.btnInvesticijskiPortfolio.Click += new System.EventHandler(this.btnInvesticijskiPortfolio_Click);
			// 
			// btnPregled
			// 
			this.btnPregled.BackColor = System.Drawing.Color.White;
			this.btnPregled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPregled.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnPregled.Location = new System.Drawing.Point(9, 458);
			this.btnPregled.Margin = new System.Windows.Forms.Padding(2);
			this.btnPregled.Name = "btnPregled";
			this.btnPregled.Size = new System.Drawing.Size(175, 63);
			this.btnPregled.TabIndex = 13;
			this.btnPregled.Text = "Pregled transakcija";
			this.btnPregled.UseVisualStyleBackColor = false;
			this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
			// 
			// btnUnosTransakcije
			// 
			this.btnUnosTransakcije.BackColor = System.Drawing.Color.White;
			this.btnUnosTransakcije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUnosTransakcije.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnUnosTransakcije.Location = new System.Drawing.Point(9, 391);
			this.btnUnosTransakcije.Margin = new System.Windows.Forms.Padding(2);
			this.btnUnosTransakcije.Name = "btnUnosTransakcije";
			this.btnUnosTransakcije.Size = new System.Drawing.Size(175, 63);
			this.btnUnosTransakcije.TabIndex = 12;
			this.btnUnosTransakcije.Text = "Unos transakcija";
			this.btnUnosTransakcije.UseVisualStyleBackColor = false;
			this.btnUnosTransakcije.Click += new System.EventHandler(this.btnUnosTransakcije_Click);
			// 
			// btnBankovniRacun
			// 
			this.btnBankovniRacun.BackColor = System.Drawing.Color.White;
			this.btnBankovniRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBankovniRacun.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnBankovniRacun.Location = new System.Drawing.Point(9, 323);
			this.btnBankovniRacun.Margin = new System.Windows.Forms.Padding(2);
			this.btnBankovniRacun.Name = "btnBankovniRacun";
			this.btnBankovniRacun.Size = new System.Drawing.Size(175, 63);
			this.btnBankovniRacun.TabIndex = 11;
			this.btnBankovniRacun.Text = "Bankovni računi";
			this.btnBankovniRacun.UseVisualStyleBackColor = false;
			this.btnBankovniRacun.Click += new System.EventHandler(this.btnBankovniRacun_Click);
			// 
			// btnZaslon
			// 
			this.btnZaslon.BackColor = System.Drawing.Color.White;
			this.btnZaslon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnZaslon.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnZaslon.Location = new System.Drawing.Point(9, 256);
			this.btnZaslon.Margin = new System.Windows.Forms.Padding(2);
			this.btnZaslon.Name = "btnZaslon";
			this.btnZaslon.Size = new System.Drawing.Size(175, 63);
			this.btnZaslon.TabIndex = 10;
			this.btnZaslon.Text = "Početni zaslon";
			this.btnZaslon.UseVisualStyleBackColor = false;
			this.btnZaslon.Click += new System.EventHandler(this.btnZaslon_Click);
			// 
			// lblTrenutniKorisnikImePrezime
			// 
			this.lblTrenutniKorisnikImePrezime.AutoSize = true;
			this.lblTrenutniKorisnikImePrezime.Location = new System.Drawing.Point(9, 201);
			this.lblTrenutniKorisnikImePrezime.Name = "lblTrenutniKorisnikImePrezime";
			this.lblTrenutniKorisnikImePrezime.Size = new System.Drawing.Size(35, 13);
			this.lblTrenutniKorisnikImePrezime.TabIndex = 20;
			this.lblTrenutniKorisnikImePrezime.Text = "label1";
			// 
			// FrmGlavniIzbornik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1424, 800);
			this.Controls.Add(this.lblTrenutniKorisnikImePrezime);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.btnOdjava);
			this.Controls.Add(this.btnPostavke);
			this.Controls.Add(this.btnStatistika);
			this.Controls.Add(this.btnInvesticijskiPortfolio);
			this.Controls.Add(this.btnPregled);
			this.Controls.Add(this.btnUnosTransakcije);
			this.Controls.Add(this.btnBankovniRacun);
			this.Controls.Add(this.btnZaslon);
			this.Controls.Add(this.splitterMenuScreen);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmGlavniIzbornik";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wall@";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.SizeChanged += new System.EventHandler(this.FrmGlavniIzbornik_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitterMenuScreen;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnPostavke;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnInvesticijskiPortfolio;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnUnosTransakcije;
        private System.Windows.Forms.Button btnBankovniRacun;
        private System.Windows.Forms.Button btnZaslon;
		private System.Windows.Forms.Label lblTrenutniKorisnikImePrezime;
	}
}

