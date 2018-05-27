namespace PocetniZaslon.MDI_Forme
{
	partial class FrmBankovniRacunDodaj
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(206, 126);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(357, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(206, 184);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(357, 20);
			this.textBox2.TabIndex = 1;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(206, 292);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(357, 20);
			this.textBox4.TabIndex = 3;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(206, 235);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(357, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// FrmBankovniRacunDodaj
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "FrmBankovniRacunDodaj";
			this.Text = "FrmBankovniRacunDodaj";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}