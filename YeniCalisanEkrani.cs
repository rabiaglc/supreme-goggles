using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjeYonetimSistemi
{
    public partial class YeniCalisanEkrani : Form
    {
        public YeniCalisanEkrani()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtPozisyon.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "INSERT INTO Calisanlar (Ad, Soyad, Pozisyon) VALUES (@Ad, @Soyad, @Pozisyon)";
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("@Ad", txtAd.Text.Trim()),
                    new MySqlParameter("@Soyad", txtSoyad.Text.Trim()),
                    new MySqlParameter("@Pozisyon", txtPozisyon.Text.Trim())
                };

                int result = DBHelper.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Çalışan başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Çalışan eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
