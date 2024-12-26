namespace ProjeYonetimSistemi
{
    partial class YeniProjeFormu
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.lblProjeAdi = new System.Windows.Forms.Label();
            this.txtProjeAdi = new System.Windows.Forms.TextBox();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblProjeAdi
            this.lblProjeAdi.AutoSize = true;
            this.lblProjeAdi.Location = new System.Drawing.Point(12, 20);
            this.lblProjeAdi.Name = "lblProjeAdi";
            this.lblProjeAdi.Size = new System.Drawing.Size(59, 13);
            this.lblProjeAdi.TabIndex = 0;
            this.lblProjeAdi.Text = "Proje Adı:";

            // txtProjeAdi
            this.txtProjeAdi.Location = new System.Drawing.Point(100, 17);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(200, 20);
            this.txtProjeAdi.TabIndex = 1;

            // lblBaslangicTarihi
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(12, 60);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(92, 13);
            this.lblBaslangicTarihi.TabIndex = 2;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi:";

            // dtpBaslangicTarihi
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(100, 57);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpBaslangicTarihi.TabIndex = 3;

            // lblBitisTarihi
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Location = new System.Drawing.Point(12, 100);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(65, 13);
            this.lblBitisTarihi.TabIndex = 4;
            this.lblBitisTarihi.Text = "Bitiş Tarihi:";

            // dtpBitisTarihi
            this.dtpBitisTarihi.Location = new System.Drawing.Point(100, 97);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpBitisTarihi.TabIndex = 5;

            // btnKaydet
            this.btnKaydet.Location = new System.Drawing.Point(100, 140);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 30);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // YeniProjeFormu
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.lblBitisTarihi);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Controls.Add(this.lblBaslangicTarihi);
            this.Controls.Add(this.txtProjeAdi);
            this.Controls.Add(this.lblProjeAdi);
            this.Name = "YeniProjeFormu";
            this.Text = "Yeni Proje Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblProjeAdi;
        private System.Windows.Forms.TextBox txtProjeAdi;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Button btnKaydet;
    }
}
