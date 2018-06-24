namespace PocetniZaslon.MDI_Forme
{
	partial class FrmPocetniZaslon
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.lblPocetniZasalon = new System.Windows.Forms.Label();
			this.gBoxBankovniRacuni = new System.Windows.Forms.GroupBox();
			this.gBoxInvesticije = new System.Windows.Forms.GroupBox();
			this.gBoxStatistika = new System.Windows.Forms.GroupBox();
			this.gBoxTransakcije = new System.Windows.Forms.GroupBox();
			this.chartStatistika = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.gBoxStatistika.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartStatistika)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPocetniZasalon
			// 
			this.lblPocetniZasalon.AutoSize = true;
			this.lblPocetniZasalon.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
			this.lblPocetniZasalon.Location = new System.Drawing.Point(463, 40);
			this.lblPocetniZasalon.Name = "lblPocetniZasalon";
			this.lblPocetniZasalon.Size = new System.Drawing.Size(438, 81);
			this.lblPocetniZasalon.TabIndex = 0;
			this.lblPocetniZasalon.Text = "Početni zaslon";
			// 
			// gBoxBankovniRacuni
			// 
			this.gBoxBankovniRacuni.Font = new System.Drawing.Font("Segoe UI", 22F);
			this.gBoxBankovniRacuni.Location = new System.Drawing.Point(36, 189);
			this.gBoxBankovniRacuni.Name = "gBoxBankovniRacuni";
			this.gBoxBankovniRacuni.Size = new System.Drawing.Size(823, 341);
			this.gBoxBankovniRacuni.TabIndex = 1;
			this.gBoxBankovniRacuni.TabStop = false;
			this.gBoxBankovniRacuni.Text = "Prikaz bankovnih računa";
			// 
			// gBoxInvesticije
			// 
			this.gBoxInvesticije.Font = new System.Drawing.Font("Segoe UI", 22F);
			this.gBoxInvesticije.Location = new System.Drawing.Point(946, 189);
			this.gBoxInvesticije.Name = "gBoxInvesticije";
			this.gBoxInvesticije.Size = new System.Drawing.Size(529, 341);
			this.gBoxInvesticije.TabIndex = 1;
			this.gBoxInvesticije.TabStop = false;
			this.gBoxInvesticije.Text = "Prikaz investicija";
			// 
			// gBoxStatistika
			// 
			this.gBoxStatistika.Controls.Add(this.chartStatistika);
			this.gBoxStatistika.Font = new System.Drawing.Font("Segoe UI", 22F);
			this.gBoxStatistika.Location = new System.Drawing.Point(946, 562);
			this.gBoxStatistika.Name = "gBoxStatistika";
			this.gBoxStatistika.Size = new System.Drawing.Size(529, 356);
			this.gBoxStatistika.TabIndex = 1;
			this.gBoxStatistika.TabStop = false;
			this.gBoxStatistika.Text = "Odnos prihoda i rashoda";
			// 
			// gBoxTransakcije
			// 
			this.gBoxTransakcije.Font = new System.Drawing.Font("Segoe UI", 22F);
			this.gBoxTransakcije.Location = new System.Drawing.Point(36, 562);
			this.gBoxTransakcije.Name = "gBoxTransakcije";
			this.gBoxTransakcije.Size = new System.Drawing.Size(823, 356);
			this.gBoxTransakcije.TabIndex = 1;
			this.gBoxTransakcije.TabStop = false;
			this.gBoxTransakcije.Text = "Prikaz transakcija";
			// 
			// chartStatistika
			// 
			chartArea1.Name = "ChartArea1";
			this.chartStatistika.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartStatistika.Legends.Add(legend1);
			this.chartStatistika.Location = new System.Drawing.Point(11, 52);
			this.chartStatistika.Name = "chartStatistika";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series1.Legend = "Legend1";
			series1.Name = "Stat";
			this.chartStatistika.Series.Add(series1);
			this.chartStatistika.Size = new System.Drawing.Size(506, 295);
			this.chartStatistika.TabIndex = 0;
			this.chartStatistika.Text = "chartStatistika";
			// 
			// FrmPocetniZaslon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1513, 942);
			this.Controls.Add(this.gBoxTransakcije);
			this.Controls.Add(this.gBoxStatistika);
			this.Controls.Add(this.gBoxInvesticije);
			this.Controls.Add(this.gBoxBankovniRacuni);
			this.Controls.Add(this.lblPocetniZasalon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmPocetniZaslon";
			this.Text = "FrmPocetniZaslon";
			this.gBoxStatistika.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartStatistika)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPocetniZasalon;
		private System.Windows.Forms.GroupBox gBoxBankovniRacuni;
		private System.Windows.Forms.GroupBox gBoxInvesticije;
		private System.Windows.Forms.GroupBox gBoxStatistika;
		private System.Windows.Forms.GroupBox gBoxTransakcije;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistika;
	}
}