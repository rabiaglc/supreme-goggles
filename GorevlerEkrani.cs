using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjeYonetimSistemi
{
    public partial class GorevlerEkrani : Form
    {
        public GorevlerEkrani()
        {
            InitializeComponent();
        }

        private void GorevlerEkrani_Load(object sender, EventArgs e)
        {
            GorevleriListele();
        }

        // Görevleri listeleme metodu
        private void GorevleriListele()
        {
            try
            {
                string query = "SELECT GorevID, ProjeID, CalisanID, Baslik, BaslangicTarihi, BitisTarihi, Durum FROM Gorevler";
                DataTable dt = DBHelper.Listele(query);
                dgvGorevler.DataSource = dt;

                // Sütun başlıklarını ayarla (isteğe bağlı)
                dgvGorevler.Columns["GorevID"].HeaderText = "Görev ID";
                dgvGorevler.Columns["ProjeID"].HeaderText = "Proje ID";
                dgvGorevler.Columns["CalisanID"].HeaderText = "Çalışan ID";
                dgvGorevler.Columns["Baslik"].HeaderText = "Başlık";
                dgvGorevler.Columns["BaslangicTarihi"].HeaderText = "Başlangıç Tarihi";
                dgvGorevler.Columns["BitisTarihi"].HeaderText = "Bitiş Tarihi";
                dgvGorevler.Columns["Durum"].HeaderText = "Durum";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görevleri listeleme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        // Yeni Görev Ekleme Butonu
        private void btnYeniGorev_Click(object sender, EventArgs e)
        {
            if (dgvGorevler.SelectedRows.Count > 0)
            {
                try
                {
                    // Seçilen projenin ID'sini al
                    int projeID = Convert.ToInt32(dgvGorevler.SelectedRows[0].Cells["ProjeID"].Value);

                    // Yeni görev formunu projeID ile aç
                    YeniGorevFormu yeniGorevForm = new YeniGorevFormu(projeID);
                    yeniGorevForm.ShowDialog();

                    // Görev listesini güncelle
                    GorevleriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Yeni görev ekleme sırasında bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir proje seçin.");
            }
        }

        // Çalışanlar Ekranına Git
        private void btnCalisanlarEkrani_Click(object sender, EventArgs e)
        {
            CalisanlarEkrani calisanlarForm = new CalisanlarEkrani();
            calisanlarForm.Show();
            this.Hide();
        }

        // Projeler Ekranına Git
        private void btnProjelerEkrani_Click(object sender, EventArgs e)
        {
            ProjeEkraniFormu projeForm = new ProjeEkraniFormu();
            projeForm.Show();
            this.Hide();
        }
    }
}
