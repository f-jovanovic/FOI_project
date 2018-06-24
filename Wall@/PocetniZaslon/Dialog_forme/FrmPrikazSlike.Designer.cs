namespace PocetniZaslon.Dialog_forme
{
	partial class FrmPrikazSlike
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
			this.pictureBoxSlika = new System.Windows.Forms.PictureBox();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxSlika
			// 
			this.pictureBoxSlika.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxSlika.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxSlika.Name = "pictureBoxSlika";
			this.pictureBoxSlika.Size = new System.Drawing.Size(997, 534);
			this.pictureBoxSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxSlika.TabIndex = 0;
			this.pictureBoxSlika.TabStop = false;
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// FrmPrikazSlike
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 534);
			this.Controls.Add(this.pictureBoxSlika);
			this.Name = "FrmPrikazSlike";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Slika računa";
			this.Load += new System.EventHandler(this.FrmPrikazSlike_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxSlika;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
	}
}