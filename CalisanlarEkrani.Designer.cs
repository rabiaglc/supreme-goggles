namespace ProjeYonetimSistemi
{
    partial class CalisanlarEkrani
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private System.Windows.Forms.Button btnYeniCalisan;
        private System.Windows.Forms.Button btnGorevlerEkrani;
        private System.Windows.Forms.Button btnProjelerEkrani;

        private void InitializeComponent()
        {
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.btnYeniCalisan = new System.Windows.Forms.Button();
            this.btnGorevlerEkrani = new System.Windows.Forms.Button();
            this.btnProjelerEkrani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.Location = new System.Drawing.Point(12, 12);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.Size = new System.Drawing.Size(760, 300);
            this.dgvCalisanlar.TabIndex = 0;

            // 
            // btnYeniCalisan
            // 
            this.btnYeniCalisan.Location = new System.Drawing.Point(12, 330);
            this.btnYeniCalisan.Name = "btnYeniCalisan";
            this.btnYeniCalisan.Size = new System.Drawing.Size(150, 40);
            this.btnYeniCalisan.TabIndex = 1;
            this.btnYeniCalisan.Text = "Yeni Çalışan Ekle";
            this.btnYeniCalisan.UseVisualStyleBackColor = true;
            this.btnYeniCalisan.Click += new System.EventHandler(this.btnYeniCalisan_Click);

            // 
            // btnGorevlerEkrani
            // 
            this.btnGorevlerEkrani.Location = new System.Drawing.Point(180, 330);
            this.btnGorevlerEkrani.Name = "btnGorevlerEkrani";
            this.btnGorevlerEkrani.Size = new System.Drawing.Size(150, 40);
            this.btnGorevlerEkrani.TabIndex = 2;
            this.btnGorevlerEkrani.Text = "Görevler Ekranına Git";
            this.btnGorevlerEkrani.UseVisualStyleBackColor = true;
            this.btnGorevlerEkrani.Click += new System.EventHandler(this.btnGorevlerEkrani_Click);

            // 
            // btnProjelerEkrani
            // 
            this.btnProjelerEkrani.Location = new System.Drawing.Point(350, 330);
            this.btnProjelerEkrani.Name = "btnProjelerEkrani";
            this.btnProjelerEkrani.Size = new System.Drawing.Size(150, 40);
            this.btnProjelerEkrani.TabIndex = 3;
            this.btnProjelerEkrani.Text = "Projeler Ekranına Git";
            this.btnProjelerEkrani.UseVisualStyleBackColor = true;
            this.btnProjelerEkrani.Click += new System.EventHandler(this.btnProjelerEkrani_Click);

            // 
            // CalisanlarEkrani
            // 
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnProjelerEkrani);
            this.Controls.Add(this.btnGorevlerEkrani);
            this.Controls.Add(this.btnYeniCalisan);
            this.Controls.Add(this.dgvCalisanlar);
            this.Name = "CalisanlarEkrani";
            this.Text = "Çalışanlar Ekranı";
            this.Load += new System.EventHandler(this.CalisanlarEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
