namespace PocetniZaslon.MDI_Forme
{
	partial class FrmStatistika
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.lblStatistikaNaslov = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chartPrihodivRashodi = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPrihodivRashodi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatistikaNaslov
			// 
			this.lblStatistikaNaslov.AutoSize = true;
			this.lblStatistikaNaslov.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
			this.lblStatistikaNaslov.Location = new System.Drawing.Point(539, 70);
			this.lblStatistikaNaslov.Name = "lblStatistikaNaslov";
			this.lblStatistikaNaslov.Size = new System.Drawing.Size(631, 72);
			this.lblStatistikaNaslov.TabIndex = 0;
			this.lblStatistikaNaslov.Text = "Statistički prikaz računa";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chart2);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.groupBox1.Location = new System.Drawing.Point(949, 197);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(618, 474);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Linear rashodi";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chartPrihodivRashodi);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.groupBox2.Location = new System.Drawing.Point(101, 197);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(621, 474);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Prihodi vs rashodi";
			// 
			// chartPrihodivRashodi
			// 
			chartArea3.Name = "ChartArea1";
			this.chartPrihodivRashodi.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chartPrihodivRashodi.Legends.Add(legend3);
			this.chartPrihodivRashodi.Location = new System.Drawing.Point(21, 76);
			this.chartPrihodivRashodi.Name = "chartPrihodivRashodi";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			this.chartPrihodivRashodi.Series.Add(series3);
			this.chartPrihodivRashodi.Size = new System.Drawing.Size(542, 392);
			this.chartPrihodivRashodi.TabIndex = 0;
			this.chartPrihodivRashodi.Text = "chartPrihodivRashodi";
			// 
			// chart2
			// 
			chartArea4.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea4);
			legend4.Name = "Legend1";
			this.chart2.Legends.Add(legend4);
			this.chart2.Location = new System.Drawing.Point(27, 76);
			this.chart2.Name = "chart2";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series4.Legend = "Legend1";
			series4.Name = "Series1";
			this.chart2.Series.Add(series4);
			this.chart2.Size = new System.Drawing.Size(576, 392);
			this.chart2.TabIndex = 0;
			this.chart2.Text = "chartRashodiLinearno";
			// 
			// FrmStatistika
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1762, 754);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblStatistikaNaslov);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmStatistika";
			this.Text = "FrmStatistika";
			this.Load += new System.EventHandler(this.FrmStatistika_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartPrihodivRashodi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStatistikaNaslov;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartPrihodivRashodi;
	}
}