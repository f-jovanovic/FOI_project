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
			this.chartLinearRashodi = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartPrihodivRashodi = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartLinearRashodi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartPrihodivRashodi)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatistikaNaslov
			// 
			this.lblStatistikaNaslov.AutoSize = true;
			this.lblStatistikaNaslov.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
			this.lblStatistikaNaslov.Location = new System.Drawing.Point(531, 54);
			this.lblStatistikaNaslov.Name = "lblStatistikaNaslov";
			this.lblStatistikaNaslov.Size = new System.Drawing.Size(631, 72);
			this.lblStatistikaNaslov.TabIndex = 0;
			this.lblStatistikaNaslov.Text = "Statistički prikaz računa";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chartLinearRashodi);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.groupBox1.Location = new System.Drawing.Point(577, 186);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1203, 604);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Linear rashodi";
			// 
			// chartLinearRashodi
			// 
			chartArea3.Name = "ChartArea1";
			this.chartLinearRashodi.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chartLinearRashodi.Legends.Add(legend3);
			this.chartLinearRashodi.Location = new System.Drawing.Point(6, 76);
			this.chartLinearRashodi.Name = "chartLinearRashodi";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "LinChart";
			series3.XValueMember = "vrijeme_transakcije";
			series3.YValueMembers = "iznos_transakcije";
			this.chartLinearRashodi.Series.Add(series3);
			this.chartLinearRashodi.Size = new System.Drawing.Size(1167, 534);
			this.chartLinearRashodi.TabIndex = 0;
			this.chartLinearRashodi.Text = "chartLinearRashodi";
			// 
			// chartPrihodivRashodi
			// 
			chartArea4.Name = "ChartArea1";
			this.chartPrihodivRashodi.ChartAreas.Add(chartArea4);
			legend4.Name = "Legend1";
			this.chartPrihodivRashodi.Legends.Add(legend4);
			this.chartPrihodivRashodi.Location = new System.Drawing.Point(6, 76);
			this.chartPrihodivRashodi.Name = "chartPrihodivRashodi";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series4.Legend = "Legend1";
			series4.Name = "PChart";
			series4.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
			this.chartPrihodivRashodi.Series.Add(series4);
			this.chartPrihodivRashodi.Size = new System.Drawing.Size(534, 372);
			this.chartPrihodivRashodi.TabIndex = 0;
			this.chartPrihodivRashodi.Text = "chartPrihodivRashodi";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chartPrihodivRashodi);
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.groupBox3.Location = new System.Drawing.Point(12, 261);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(559, 454);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Prihodi vs rashodi";
			// 
			// FrmStatistika
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1762, 1169);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblStatistikaNaslov);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmStatistika";
			this.Text = "FrmStatistika";
			this.Load += new System.EventHandler(this.FrmStatistika_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartLinearRashodi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartPrihodivRashodi)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStatistikaNaslov;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartPrihodivRashodi;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartLinearRashodi;
		private System.Windows.Forms.GroupBox groupBox3;
	}
}