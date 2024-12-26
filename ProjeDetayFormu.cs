using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjeYonetimSistemi
{
    public partial class ProjeDetayFormu : Form
    {
        private int _projeID;

        public ProjeDetayFormu(int projeID)
        {
            InitializeComponent();
            _projeID = projeID;
        }

        private void ProjeDetayFormu_Load(object sender, EventArgs e)
        {
            ProjeBilgileriniGetir();
            GorevleriGetir();
        }

        private void ProjeBilgileriniGetir()
        {
            string query = "SELECT ProjeAdi, BaslangicTarihi, BitisTarihi FROM Projeler WHERE ProjeID = @ProjeID";
            MySqlParameter[] parameters = { new MySqlParameter("@ProjeID", _projeID) };

            try
            {
                using (MySqlDataReader reader = DBHelper.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        lblProjeAdi.Text = reader["ProjeAdi"].ToString();
                        lblBaslangicTarihi.Text = Convert.ToDateTime(reader["BaslangicTarihi"]).ToShortDateString();
                        lblBitisTarihi.Text = Convert.ToDateTime(reader["BitisTarihi"]).ToShortDateString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proje bilgileri alınırken hata oluştu: " + ex.Message);
            }
        }

        private void GorevleriGetir()
        {
            string query = "SELECT GorevID, GorevAdi, BaslangicTarihi, BitisTarihi, Durum FROM Gorevler WHERE ProjeID = @ProjeID";
            MySqlParameter[] parameters = { new MySqlParameter("@ProjeID", _projeID) };

            try
            {
                DataTable dt = DBHelper.Listele(query, parameters);
                dgvGorevler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görevler alınırken hata oluştu: " + ex.Message);
            }
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            YeniGorevFormu yeniGorevFormu = new YeniGorevFormu(_projeID);
            yeniGorevFormu.ShowDialog();
            GorevleriGetir(); // Görev listesi güncellenir
        }
    }
}
