namespace PocetniZaslon.MDI_Forme
{
    partial class FrmUnosTransakcija
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
            this.lblNovaTransakcija = new System.Windows.Forms.Label();
            this.lblOdabir = new System.Windows.Forms.Label();
            this.btnTrosak = new System.Windows.Forms.Button();
            this.btnPrihod = new System.Windows.Forms.Button();
            this.btnInterniPrijenos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNovaTransakcija
            // 
            this.lblNovaTransakcija.AutoSize = true;
            this.lblNovaTransakcija.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNovaTransakcija.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNovaTransakcija.Location = new System.Drawing.Point(225, 2);
            this.lblNovaTransakcija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNovaTransakcija.Name = "lblNovaTransakcija";
            this.lblNovaTransakcija.Size = new System.Drawing.Size(402, 65);
            this.lblNovaTransakcija.TabIndex = 0;
            this.lblNovaTransakcija.Text = "Nova transakcija";
            // 
            // lblOdabir
            // 
            this.lblOdabir.AutoSize = true;
            this.lblOdabir.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOdabir.Location = new System.Drawing.Point(220, 145);
            this.lblOdabir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOdabir.Name = "lblOdabir";
            this.lblOdabir.Size = new System.Drawing.Size(419, 45);
            this.lblOdabir.TabIndex = 1;
            this.lblOdabir.Text = "Odaberite vrstu transakcije:";
            // 
            // btnTrosak
            // 
            this.btnTrosak.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTrosak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrosak.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrosak.ForeColor = System.Drawing.Color.White;
            this.btnTrosak.Location = new System.Drawing.Point(278, 245);
            this.btnTrosak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrosak.Name = "btnTrosak";
            this.btnTrosak.Size = new System.Drawing.Size(271, 72);
            this.btnTrosak.TabIndex = 2;
            this.btnTrosak.Text = "Trošak";
            this.btnTrosak.UseVisualStyleBackColor = false;
            this.btnTrosak.Click += new System.EventHandler(this.btnTrosak_Click);
            // 
            // btnPrihod
            // 
            this.btnPrihod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrihod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrihod.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrihod.ForeColor = System.Drawing.Color.White;
            this.btnPrihod.Location = new System.Drawing.Point(278, 361);
            this.btnPrihod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrihod.Name = "btnPrihod";
            this.btnPrihod.Size = new System.Drawing.Size(271, 72);
            this.btnPrihod.TabIndex = 3;
            this.btnPrihod.Text = "Prihod";
            this.btnPrihod.UseVisualStyleBackColor = false;
            this.btnPrihod.Click += new System.EventHandler(this.btnPrihod_Click);
            // 
            // btnInterniPrijenos
            // 
            this.btnInterniPrijenos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnInterniPrijenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterniPrijenos.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInterniPrijenos.ForeColor = System.Drawing.Color.White;
            this.btnInterniPrijenos.Location = new System.Drawing.Point(278, 476);
            this.btnInterniPrijenos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInterniPrijenos.Name = "btnInterniPrijenos";
            this.btnInterniPrijenos.Size = new System.Drawing.Size(271, 72);
            this.btnInterniPrijenos.TabIndex = 4;
            this.btnInterniPrijenos.Text = "Interni prijenos";
            this.btnInterniPrijenos.UseVisualStyleBackColor = false;
            this.btnInterniPrijenos.Click += new System.EventHandler(this.btnInterniPrijenos_Click);
            // 
            // FrmUnosTransakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 579);
            this.Controls.Add(this.btnInterniPrijenos);
            this.Controls.Add(this.btnPrihod);
            this.Controls.Add(this.btnTrosak);
            this.Controls.Add(this.lblOdabir);
            this.Controls.Add(this.lblNovaTransakcija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUnosTransakcija";
            this.Text = "FrmUnosTransakcija";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmUnosTransakcija_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNovaTransakcija;
        private System.Windows.Forms.Label lblOdabir;
        private System.Windows.Forms.Button btnTrosak;
        private System.Windows.Forms.Button btnPrihod;
        private System.Windows.Forms.Button btnInterniPrijenos;
    }
}