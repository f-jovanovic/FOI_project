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
            this.lblNovaTransakcija.Location = new System.Drawing.Point(300, 3);
            this.lblNovaTransakcija.Name = "lblNovaTransakcija";
            this.lblNovaTransakcija.Size = new System.Drawing.Size(501, 81);
            this.lblNovaTransakcija.TabIndex = 0;
            this.lblNovaTransakcija.Text = "Nova transakcija";
            // 
            // lblOdabir
            // 
            this.lblOdabir.AutoSize = true;
            this.lblOdabir.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabir.Location = new System.Drawing.Point(293, 179);
            this.lblOdabir.Name = "lblOdabir";
            this.lblOdabir.Size = new System.Drawing.Size(515, 54);
            this.lblOdabir.TabIndex = 1;
            this.lblOdabir.Text = "Odaberite vrstu transakcije:";
            // 
            // btnTrosak
            // 
            this.btnTrosak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrosak.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrosak.Location = new System.Drawing.Point(370, 302);
            this.btnTrosak.Name = "btnTrosak";
            this.btnTrosak.Size = new System.Drawing.Size(361, 89);
            this.btnTrosak.TabIndex = 2;
            this.btnTrosak.Text = "Trošak";
            this.btnTrosak.UseVisualStyleBackColor = true;
            this.btnTrosak.Click += new System.EventHandler(this.btnTrosak_Click);
            // 
            // btnPrihod
            // 
            this.btnPrihod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrihod.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrihod.Location = new System.Drawing.Point(370, 444);
            this.btnPrihod.Name = "btnPrihod";
            this.btnPrihod.Size = new System.Drawing.Size(361, 89);
            this.btnPrihod.TabIndex = 3;
            this.btnPrihod.Text = "Prihod";
            this.btnPrihod.UseVisualStyleBackColor = true;
            this.btnPrihod.Click += new System.EventHandler(this.btnPrihod_Click);
            // 
            // btnInterniPrijenos
            // 
            this.btnInterniPrijenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterniPrijenos.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInterniPrijenos.Location = new System.Drawing.Point(370, 586);
            this.btnInterniPrijenos.Name = "btnInterniPrijenos";
            this.btnInterniPrijenos.Size = new System.Drawing.Size(361, 89);
            this.btnInterniPrijenos.TabIndex = 4;
            this.btnInterniPrijenos.Text = "Interni prijenos";
            this.btnInterniPrijenos.UseVisualStyleBackColor = true;
            this.btnInterniPrijenos.Click += new System.EventHandler(this.btnInterniPrijenos_Click);
            // 
            // FrmUnosTransakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 713);
            this.Controls.Add(this.btnInterniPrijenos);
            this.Controls.Add(this.btnPrihod);
            this.Controls.Add(this.btnTrosak);
            this.Controls.Add(this.lblOdabir);
            this.Controls.Add(this.lblNovaTransakcija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUnosTransakcija";
            this.Text = "FrmUnosTransakcija";
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