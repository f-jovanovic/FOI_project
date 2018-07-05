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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblStatistikaNaslov = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartLinearRashodi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPrihodivRashodi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRashodi = new System.Windows.Forms.Label();
            this.lblPrihodi = new System.Windows.Forms.Label();
            this.lblRazlika = new System.Windows.Forms.Label();
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
            this.lblStatistikaNaslov.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStatistikaNaslov.Location = new System.Drawing.Point(398, 44);
            this.lblStatistikaNaslov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatistikaNaslov.Name = "lblStatistikaNaslov";
            this.lblStatistikaNaslov.Size = new System.Drawing.Size(506, 59);
            this.lblStatistikaNaslov.TabIndex = 0;
            this.lblStatistikaNaslov.Text = "Statistički prikaz računa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartLinearRashodi);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(433, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(902, 491);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafički prikaz korisnikovih rashoda po datumu";
            // 
            // chartLinearRashodi
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLinearRashodi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLinearRashodi.Legends.Add(legend1);
            this.chartLinearRashodi.Location = new System.Drawing.Point(4, 62);
            this.chartLinearRashodi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartLinearRashodi.Name = "chartLinearRashodi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Rashodi";
            series1.XValueMember = "vrijeme_transakcije";
            series1.YValueMembers = "iznos_transakcije";
            this.chartLinearRashodi.Series.Add(series1);
            this.chartLinearRashodi.Size = new System.Drawing.Size(875, 434);
            this.chartLinearRashodi.TabIndex = 0;
            this.chartLinearRashodi.Text = "chartLinearRashodi";
            // 
            // chartPrihodivRashodi
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPrihodivRashodi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPrihodivRashodi.Legends.Add(legend2);
            this.chartPrihodivRashodi.Location = new System.Drawing.Point(4, 62);
            this.chartPrihodivRashodi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartPrihodivRashodi.Name = "chartPrihodivRashodi";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "PChart";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartPrihodivRashodi.Series.Add(series2);
            this.chartPrihodivRashodi.Size = new System.Drawing.Size(400, 302);
            this.chartPrihodivRashodi.TabIndex = 0;
            this.chartPrihodivRashodi.Text = "chartPrihodivRashodi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chartPrihodivRashodi);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(9, 151);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(419, 369);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grafički prikaz odnosa prihoda i rashoda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(9, 562);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ukuni iznos korisnikovih rashoda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(9, 592);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ukupni iznos korisnikovih prihoda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(9, 630);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razlika prihoda i rashoda:";
            // 
            // lblRashodi
            // 
            this.lblRashodi.AutoSize = true;
            this.lblRashodi.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblRashodi.Location = new System.Drawing.Point(329, 562);
            this.lblRashodi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRashodi.Name = "lblRashodi";
            this.lblRashodi.Size = new System.Drawing.Size(63, 25);
            this.lblRashodi.TabIndex = 3;
            this.lblRashodi.Text = "label4";
            // 
            // lblPrihodi
            // 
            this.lblPrihodi.AutoSize = true;
            this.lblPrihodi.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPrihodi.Location = new System.Drawing.Point(329, 592);
            this.lblPrihodi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrihodi.Name = "lblPrihodi";
            this.lblPrihodi.Size = new System.Drawing.Size(63, 25);
            this.lblPrihodi.TabIndex = 3;
            this.lblPrihodi.Text = "label4";
            // 
            // lblRazlika
            // 
            this.lblRazlika.AutoSize = true;
            this.lblRazlika.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblRazlika.Location = new System.Drawing.Point(329, 630);
            this.lblRazlika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRazlika.Name = "lblRazlika";
            this.lblRazlika.Size = new System.Drawing.Size(63, 25);
            this.lblRazlika.TabIndex = 3;
            this.lblRazlika.Text = "label4";
            // 
            // FrmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1322, 894);
            this.Controls.Add(this.lblRazlika);
            this.Controls.Add(this.lblPrihodi);
            this.Controls.Add(this.lblRashodi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatistikaNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmStatistika";
            this.Text = "FrmStatistika";
            this.Load += new System.EventHandler(this.FrmStatistika_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmStatistika_HelpRequested);
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblRashodi;
		private System.Windows.Forms.Label lblPrihodi;
		private System.Windows.Forms.Label lblRazlika;
	}
}