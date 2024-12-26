namespace ProjeYonetimSistemi
{
    partial class ProjeEkraniFormu
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
            this.dgvProjeler = new System.Windows.Forms.DataGridView();
            this.btnYeniProjeEkle = new System.Windows.Forms.Button();
            this.btnProjeyeGit = new System.Windows.Forms.Button();
            this.btnCalisanlarEkrani = new System.Windows.Forms.Button();
            this.btnGorevlerEkrani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjeler
            // 
            this.dgvProjeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjeler.Location = new System.Drawing.Point(12, 12);
            this.dgvProjeler.Name = "dgvProjeler";
            this.dgvProjeler.RowTemplate.Height = 25;
            this.dgvProjeler.Size = new System.Drawing.Size(600, 300);
            this.dgvProjeler.TabIndex = 0;
            // 
            // btnYeniProjeEkle
            // 
            this.btnYeniProjeEkle.Location = new System.Drawing.Point(12, 330);
            this.btnYeniProjeEkle.Name = "btnYeniProjeEkle";
            this.btnYeniProjeEkle.Size = new System.Drawing.Size(120, 40);
            this.btnYeniProjeEkle.TabIndex = 1;
            this.btnYeniProjeEkle.Text = "Yeni Proje Ekle";
            this.btnYeniProjeEkle.UseVisualStyleBackColor = true;
            this.btnYeniProjeEkle.Click += new System.EventHandler(this.btnYeniProjeEkle_Click);
            // 
            // btnProjeyeGit
            // 
            this.btnProjeyeGit.Location = new System.Drawing.Point(150, 330);
            this.btnProjeyeGit.Name = "btnProjeyeGit";
            this.btnProjeyeGit.Size = new System.Drawing.Size(120, 40);
            this.btnProjeyeGit.TabIndex = 2;
            this.btnProjeyeGit.Text = "Projeye Git";
            this.btnProjeyeGit.UseVisualStyleBackColor = true;
            this.btnProjeyeGit.Click += new System.EventHandler(this.btnProjeyeGit_Click);
            // 
            // btnCalisanlarEkrani
            // 
            this.btnCalisanlarEkrani.Location = new System.Drawing.Point(292, 330);
            this.btnCalisanlarEkrani.Name = "btnCalisanlarEkrani";
            this.btnCalisanlarEkrani.Size = new System.Drawing.Size(150, 40);
            this.btnCalisanlarEkrani.TabIndex = 3;
            this.btnCalisanlarEkrani.Text = "Çalışanlar Ekranı";
            this.btnCalisanlarEkrani.UseVisualStyleBackColor = true;
            this.btnCalisanlarEkrani.Click += new System.EventHandler(this.btnCalisanlarEkrani_Click);
            // 
            // btnGorevlerEkrani
            // 
            this.btnGorevlerEkrani.Location = new System.Drawing.Point(460, 330);
            this.btnGorevlerEkrani.Name = "btnGorevlerEkrani";
            this.btnGorevlerEkrani.Size = new System.Drawing.Size(150, 40);
            this.btnGorevlerEkrani.TabIndex = 4;
            this.btnGorevlerEkrani.Text = "Görevler Ekranı";
            this.btnGorevlerEkrani.UseVisualStyleBackColor = true;
            this.btnGorevlerEkrani.Click += new System.EventHandler(this.btnGorevlerEkrani_Click);
            // 
            // ProjeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.btnGorevlerEkrani);
            this.Controls.Add(this.btnCalisanlarEkrani);
            this.Controls.Add(this.btnProjeyeGit);
            this.Controls.Add(this.btnYeniProjeEkle);
            this.Controls.Add(this.dgvProjeler);
            this.Name = "ProjeEkrani";
            this.Text = "Projeler Ekranı";
            this.Load += new System.EventHandler(this.ProjeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjeler;
        private System.Windows.Forms.Button btnYeniProjeEkle;
        private System.Windows.Forms.Button btnProjeyeGit;
        private System.Windows.Forms.Button btnCalisanlarEkrani;
        private System.Windows.Forms.Button btnGorevlerEkrani;
    }
}
