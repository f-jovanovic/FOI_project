namespace PocetniZaslon.Dialog_forme
{
	partial class FrmInvesticijskiPortfolioObrisiInvesticiju
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
			this.btnObrisiInvesticiju = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cBoxInvesticije = new System.Windows.Forms.ComboBox();
			this.investicijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.investicijaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnObrisiInvesticiju
			// 
			this.btnObrisiInvesticiju.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnObrisiInvesticiju.Location = new System.Drawing.Point(125, 364);
			this.btnObrisiInvesticiju.Name = "btnObrisiInvesticiju";
			this.btnObrisiInvesticiju.Size = new System.Drawing.Size(176, 45);
			this.btnObrisiInvesticiju.TabIndex = 0;
			this.btnObrisiInvesticiju.Text = "Obriši investiciju";
			this.btnObrisiInvesticiju.UseVisualStyleBackColor = true;
			this.btnObrisiInvesticiju.Click += new System.EventHandler(this.btnObrisiInvesticiju_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(22, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = "Naziv investicije:";
			// 
			// cBoxInvesticije
			// 
			this.cBoxInvesticije.DataSource = this.investicijaBindingSource;
			this.cBoxInvesticije.DisplayMember = "naziv_investicije";
			this.cBoxInvesticije.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.cBoxInvesticije.FormattingEnabled = true;
			this.cBoxInvesticije.Location = new System.Drawing.Point(213, 77);
			this.cBoxInvesticije.Name = "cBoxInvesticije";
			this.cBoxInvesticije.Size = new System.Drawing.Size(191, 36);
			this.cBoxInvesticije.TabIndex = 2;
			this.cBoxInvesticije.ValueMember = "id_investicije";
			// 
			// investicijaBindingSource
			// 
			this.investicijaBindingSource.DataSource = typeof(PocetniZaslon.Investicija);
			// 
			// FrmInvesticijskiPortfolioObrišiInvesticiju
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 497);
			this.Controls.Add(this.cBoxInvesticije);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnObrisiInvesticiju);
			this.Name = "FrmInvesticijskiPortfolioObrišiInvesticiju";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Forma za brisanje investicija";
			((System.ComponentModel.ISupportInitialize)(this.investicijaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnObrisiInvesticiju;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cBoxInvesticije;
		private System.Windows.Forms.BindingSource investicijaBindingSource;
	}
}