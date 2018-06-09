namespace DohvacanjePodatakaZaInvesticije
{
	partial class Avapi
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
			this.txtSimbol = new System.Windows.Forms.TextBox();
			this.txtDiT = new System.Windows.Forms.TextBox();
			this.txtInfo = new System.Windows.Forms.TextBox();
			this.txtOpen = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtSimbol
			// 
			this.txtSimbol.Location = new System.Drawing.Point(372, 65);
			this.txtSimbol.Name = "txtSimbol";
			this.txtSimbol.Size = new System.Drawing.Size(190, 22);
			this.txtSimbol.TabIndex = 0;
			// 
			// txtDiT
			// 
			this.txtDiT.Location = new System.Drawing.Point(372, 111);
			this.txtDiT.Name = "txtDiT";
			this.txtDiT.Size = new System.Drawing.Size(190, 22);
			this.txtDiT.TabIndex = 0;
			// 
			// txtInfo
			// 
			this.txtInfo.Location = new System.Drawing.Point(372, 160);
			this.txtInfo.Name = "txtInfo";
			this.txtInfo.Size = new System.Drawing.Size(190, 22);
			this.txtInfo.TabIndex = 0;
			// 
			// txtOpen
			// 
			this.txtOpen.Location = new System.Drawing.Point(372, 210);
			this.txtOpen.Name = "txtOpen";
			this.txtOpen.Size = new System.Drawing.Size(190, 22);
			this.txtOpen.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(285, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Simbol:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(285, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Time i date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(285, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Info:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(251, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Open vrijednost:";
			// 
			// Avapi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtOpen);
			this.Controls.Add(this.txtInfo);
			this.Controls.Add(this.txtDiT);
			this.Controls.Add(this.txtSimbol);
			this.Name = "Avapi";
			this.Text = "Avapi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSimbol;
		private System.Windows.Forms.TextBox txtDiT;
		private System.Windows.Forms.TextBox txtInfo;
		private System.Windows.Forms.TextBox txtOpen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}