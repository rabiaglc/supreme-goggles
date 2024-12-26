namespace ProjeYonetimSistemi
{
    partial class GorevlerEkrani
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvGorevler;
        private System.Windows.Forms.Button btnYeniGorev;
        private System.Windows.Forms.Button btnCalisanlarEkrani;
        private System.Windows.Forms.Button btnProjelerEkrani;

        private void InitializeComponent()
        {
            this.dgvGorevler = new System.Windows.Forms.DataGridView();
            this.btnYeniGorev = new System.Windows.Forms.Button();
            this.btnCalisanlarEkrani = new System.Windows.Forms.Button();
            this.btnProjelerEkrani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).BeginInit();
            this.SuspendLayout();

            // Görevler Listesi (DataGridView)
            this.dgvGorevler.Location = new System.Drawing.Point(12, 12);
            this.dgvGorevler.Size = new System.Drawing.Size(760, 300);
            this.dgvGorevler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Yeni Görev Ekle Butonu
            this.btnYeniGorev.Location = new System.Drawing.Point(12, 330);
            this.btnYeniGorev.Size = new System.Drawing.Size(150, 40);
            this.btnYeniGorev.Text = "Yeni Görev Ekle";
            this.btnYeniGorev.Click += new System.EventHandler(this.btnYeniGorev_Click);

            // Çalışanlar Ekranına Git Butonu
            this.btnCalisanlarEkrani.Location = new System.Drawing.Point(180, 330);
            this.btnCalisanlarEkrani.Size = new System.Drawing.Size(150, 40);
            this.btnCalisanlarEkrani.Text = "Çalışanlar Ekranına Git";
            this.btnCalisanlarEkrani.Click += new System.EventHandler(this.btnCalisanlarEkrani_Click);

            // Projeler Ekranına Git Butonu
            this.btnProjelerEkrani.Location = new System.Drawing.Point(350, 330);
            this.btnProjelerEkrani.Size = new System.Drawing.Size(150, 40);
            this.btnProjelerEkrani.Text = "Projeler Ekranına Git";
            this.btnProjelerEkrani.Click += new System.EventHandler(this.btnProjelerEkrani_Click);

            // GorevlerEkrani Ayarları
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.dgvGorevler);
            this.Controls.Add(this.btnYeniGorev);
            this.Controls.Add(this.btnCalisanlarEkrani);
            this.Controls.Add(this.btnProjelerEkrani);
            this.Text = "Görevler Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
