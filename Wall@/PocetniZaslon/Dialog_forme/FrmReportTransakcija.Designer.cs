namespace PocetniZaslon.Dialog_forme
{
	partial class FrmReportTransakcija
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportTransakcija));
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.reportViewerPregledTransakcija = new Microsoft.Reporting.WinForms.ReportViewer();
			this.PrikazTransakcijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.PrikazTransakcijeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewerPregledTransakcija
			// 
			resources.ApplyResources(this.reportViewerPregledTransakcija, "reportViewerPregledTransakcija");
			reportDataSource1.Name = "TemporaryDataset";
			reportDataSource1.Value = this.PrikazTransakcijeBindingSource;
			this.reportViewerPregledTransakcija.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewerPregledTransakcija.LocalReport.ReportEmbeddedResource = "PocetniZaslon.PregledTransakcija.rdlc";
			this.reportViewerPregledTransakcija.Name = "reportViewerPregledTransakcija";
			this.reportViewerPregledTransakcija.ServerReport.BearerToken = null;
			// 
			// PrikazTransakcijeBindingSource
			// 
			this.PrikazTransakcijeBindingSource.DataSource = typeof(PocetniZaslon.PrikazTransakcije);
			// 
			// FrmReportTransakcija
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.reportViewerPregledTransakcija);
			this.Name = "FrmReportTransakcija";
			this.Load += new System.EventHandler(this.FrmReportTransakcija_Load);
			((System.ComponentModel.ISupportInitialize)(this.PrikazTransakcijeBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewerPregledTransakcija;
		private System.Windows.Forms.BindingSource PrikazTransakcijeBindingSource;
	}
}