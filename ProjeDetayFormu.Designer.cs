namespace ProjeYonetimSistemi
{
    partial class ProjeDetayFormu
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.lblProjeAdi = new System.Windows.Forms.Label();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.dgvGorevler = new System.Windows.Forms.DataGridView();
            this.btnGorevEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).BeginInit();
            this.SuspendLayout();

            // lblProjeAdi
            this.lblProjeAdi.AutoSize = true;
            this.lblProjeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblProjeAdi.Location = new System.Drawing.Point(20, 20);
            this.lblProjeAdi.Name = "lblProjeAdi";
            this.lblProjeAdi.Size = new System.Drawing.Size(80, 17);
            this.lblProjeAdi.TabIndex = 0;
            this.lblProjeAdi.Text = "Proje Adı:";

            // lblBaslangicTarihi
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(20, 60);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(92, 13);
            this.lblBaslangicTarihi.TabIndex = 1;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi:";

            // lblBitisTarihi
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Location = new System.Drawing.Point(20, 90);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(65, 13);
            this.lblBitisTarihi.TabIndex = 2;
            this.lblBitisTarihi.Text = "Bitiş Tarihi:";

            // dgvGorevler
            this.dgvGorevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGorevler.Location = new System.Drawing.Point(20, 130);
            this.dgvGorevler.Name = "dgvGorevler";
            this.dgvGorevler.Size = new System.Drawing.Size(550, 200);
            this.dgvGorevler.TabIndex = 3;

            // btnGorevEkle
            this.btnGorevEkle.Location = new System.Drawing.Point(20, 350);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(150, 30);
            this.btnGorevEkle.TabIndex = 4;
            this.btnGorevEkle.Text = "Yeni Görev Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = true;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);

            // ProjeDetayFormu
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnGorevEkle);
            this.Controls.Add(this.dgvGorevler);
            this.Controls.Add(this.lblBitisTarihi);
            this.Controls.Add(this.lblBaslangicTarihi);
            this.Controls.Add(this.lblProjeAdi);
            this.Name = "ProjeDetayFormu";
            this.Text = "Proje Detayları";
            this.Load += new System.EventHandler(this.ProjeDetayFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblProjeAdi;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.DataGridView dgvGorevler;
        private System.Windows.Forms.Button btnGorevEkle;
    }
}
