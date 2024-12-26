namespace ProjeYonetimSistemi
{
    partial class YeniGorevFormu
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.txtGorevAdi = new System.Windows.Forms.TextBox();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblGorevAdi = new System.Windows.Forms.Label();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtGorevAdi
            this.txtGorevAdi.Location = new System.Drawing.Point(120, 20);
            this.txtGorevAdi.Name = "txtGorevAdi";
            this.txtGorevAdi.Size = new System.Drawing.Size(200, 20);
            this.txtGorevAdi.TabIndex = 0;

            // dtpBaslangicTarihi
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(120, 60);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpBaslangicTarihi.TabIndex = 1;

            // dtpBitisTarihi
            this.dtpBitisTarihi.Location = new System.Drawing.Point(120, 100);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpBitisTarihi.TabIndex = 2;

            // lblGorevAdi
            this.lblGorevAdi.AutoSize = true;
            this.lblGorevAdi.Location = new System.Drawing.Point(20, 20);
            this.lblGorevAdi.Name = "lblGorevAdi";
            this.lblGorevAdi.Size = new System.Drawing.Size(58, 13);
            this.lblGorevAdi.TabIndex = 3;
            this.lblGorevAdi.Text = "Görev Adı:";

            // lblBaslangicTarihi
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(20, 60);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(89, 13);
            this.lblBaslangicTarihi.TabIndex = 4;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi:";

            // lblBitisTarihi
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Location = new System.Drawing.Point(20, 100);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(62, 13);
            this.lblBitisTarihi.TabIndex = 5;
            this.lblBitisTarihi.Text = "Bitiş Tarihi:";

            // btnKaydet
            this.btnKaydet.Location = new System.Drawing.Point(120, 150);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // btnIptal
            this.btnIptal.Location = new System.Drawing.Point(245, 150);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

            // YeniGorevFormu
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblBitisTarihi);
            this.Controls.Add(this.lblBaslangicTarihi);
            this.Controls.Add(this.lblGorevAdi);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Controls.Add(this.txtGorevAdi);
            this.Name = "YeniGorevFormu";
            this.Text = "Yeni Görev Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtGorevAdi;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label lblGorevAdi;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}
