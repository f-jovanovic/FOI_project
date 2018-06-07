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
			this.dgvPregledTransakcija = new System.Windows.Forms.DataGridView();
			this.lblPregledTransakcija = new System.Windows.Forms.Label();
			this.chkObicneTransakcije = new System.Windows.Forms.CheckBox();
			this.chkTransakcijeInvesticija = new System.Windows.Forms.CheckBox();
			this.dgvBankovniRacuni = new System.Windows.Forms.DataGridView();
			this.chkRashodi = new System.Windows.Forms.CheckBox();
			this.chkPrihodi = new System.Windows.Forms.CheckBox();
			this.dgvKategorije = new System.Windows.Forms.DataGridView();
			this.chkVrijeme = new System.Windows.Forms.CheckBox();
			this.dtpVrijemeOd = new System.Windows.Forms.DateTimePicker();
			this.dtpVrijemeDo = new System.Windows.Forms.DateTimePicker();
			this.lblVrstaTransakcije = new System.Windows.Forms.Label();
			this.lblVrijeme = new System.Windows.Forms.Label();
			this.lblBankovniRacuni = new System.Windows.Forms.Label();
			this.lblKategorije = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPregledTransakcija)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBankovniRacuni)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPregledTransakcija
			// 
			this.dgvPregledTransakcija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
			this.dgvBankovniRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBankovniRacuni.Location = new System.Drawing.Point(1101, 428);
			this.dgvBankovniRacuni.Name = "dgvBankovniRacuni";
			this.dgvBankovniRacuni.Size = new System.Drawing.Size(329, 119);
			this.dgvBankovniRacuni.TabIndex = 4;
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
			this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKategorije.Location = new System.Drawing.Point(1101, 590);
			this.dgvKategorije.Name = "dgvKategorije";
			this.dgvKategorije.Size = new System.Drawing.Size(329, 147);
			this.dgvKategorije.TabIndex = 7;
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
			this.dtpVrijemeOd.Size = new System.Drawing.Size(278, 27);
			this.dtpVrijemeOd.TabIndex = 5;
			// 
			// dtpVrijemeDo
			// 
			this.dtpVrijemeDo.Enabled = false;
			this.dtpVrijemeDo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpVrijemeDo.Location = new System.Drawing.Point(1152, 345);
			this.dtpVrijemeDo.Name = "dtpVrijemeDo";
			this.dtpVrijemeDo.Size = new System.Drawing.Size(278, 27);
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
			((System.ComponentModel.ISupportInitialize)(this.dgvPregledTransakcija)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBankovniRacuni)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
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
	}
}