using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjeYonetimSistemi
{
    public partial class CalisanlarEkrani : Form
    {
        public CalisanlarEkrani()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde çalışanları listeleme
        private void CalisanlarEkrani_Load(object sender, EventArgs e)
        {
            CalisanlariListele();
        }

        // Çalışanları listeleme metodu
        private void CalisanlariListele()
        {
            try
            {
                string query = "SELECT CalisanID, Ad, Soyad, Pozisyon FROM Calisanlar";
                DataTable dt = DBHelper.Listele(query);
                dgvCalisanlar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Çalışanları listeleme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        // Yeni Çalışan Ekleme Butonu
        private void btnYeniCalisan_Click(object sender, EventArgs e)
        {
            YeniCalisanEkrani yeniCalisanForm = new YeniCalisanEkrani();
            yeniCalisanForm.ShowDialog();
            CalisanlariListele(); // Listeyi güncelle
        }

        // Görevler Ekranına Git
        private void btnGorevlerEkrani_Click(object sender, EventArgs e)
        {
            GorevlerEkrani gorevlerForm = new GorevlerEkrani();
            gorevlerForm.Show();
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
