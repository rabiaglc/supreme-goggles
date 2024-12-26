using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjeYonetimSistemi
{
    public partial class YeniProjeFormu : Form
    {
        public YeniProjeFormu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string projeAdi = txtProjeAdi.Text.Trim();
            DateTime baslangicTarihi = dtpBaslangicTarihi.Value;
            DateTime bitisTarihi = dtpBitisTarihi.Value;

            if (string.IsNullOrEmpty(projeAdi))
            {
                MessageBox.Show("Proje adı boş bırakılamaz.");
                return;
            }

            if (bitisTarihi < baslangicTarihi)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden önce olamaz.");
                return;
            }

            string query = "INSERT INTO Projeler (ProjeAdi, BaslangicTarihi, BitisTarihi) VALUES (@ProjeAdi, @BaslangicTarihi, @BitisTarihi)";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ProjeAdi", projeAdi),
                new MySqlParameter("@BaslangicTarihi", baslangicTarihi),
                new MySqlParameter("@BitisTarihi", bitisTarihi)
            };

            try
            {
                int result = DBHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Proje başarıyla kaydedildi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Proje kaydedilirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
