using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjeYonetimSistemi
{
    public partial class ProjeEkraniFormu : Form
    {
        public ProjeEkraniFormu()
        {
            InitializeComponent();
        }

        private void ProjeEkrani_Load(object sender, EventArgs e)
        {
            // Projeleri yükleme metodu
            ProjeleriGetir();
        }

        private void ProjeleriGetir()
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT ProjeID, ProjeAdi, BaslangicTarihi, BitisTarihi FROM Projeler";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProjeler.DataSource = dt; // DataGridView'e bağlama

                    // DataGridView sütun isimlerini kontrol et
                    if (!dgvProjeler.Columns.Contains("ProjeID"))
                    {
                        dgvProjeler.Columns[0].HeaderText = "Proje ID";
                        dgvProjeler.Columns[1].HeaderText = "Proje Adı";
                        dgvProjeler.Columns[2].HeaderText = "Başlangıç Tarihi";
                        dgvProjeler.Columns[3].HeaderText = "Bitiş Tarihi";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Projeler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnYeniProjeEkle_Click(object sender, EventArgs e)
        {
            // Yeni proje formunu aç
            YeniProjeFormu yeniProjeFormu = new YeniProjeFormu();
            yeniProjeFormu.ShowDialog();
            ProjeleriGetir(); // Form kapandıktan sonra projeleri güncelle
        }

        private void btnCalisanlarEkrani_Click(object sender, EventArgs e)
        {
            // Çalışanlar formunu aç
            CalisanlarEkrani calisanlarEkrani = new CalisanlarEkrani();
            calisanlarEkrani.Show();
        }

        private void btnGorevlerEkrani_Click(object sender, EventArgs e)
        {
            // Görevler ekranını aç
            GorevlerEkrani gorevlerEkrani = new GorevlerEkrani();
            gorevlerEkrani.Show();
        }


        private void btnProjeyeGit_Click(object sender, EventArgs e)
        {
            // Seçilen projeyi detay formuna gönder
            if (dgvProjeler.SelectedRows.Count > 0)
            {
                try
                {
                    int projeID = Convert.ToInt32(dgvProjeler.SelectedRows[0].Cells["ProjeID"].Value);
                    ProjeDetayFormu projeDetayFormu = new ProjeDetayFormu(projeID);
                    projeDetayFormu.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Proje detayına geçilirken hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir proje seçin.");
            }
        }
    }
}
