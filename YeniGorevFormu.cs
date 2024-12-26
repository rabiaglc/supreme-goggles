using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjeYonetimSistemi
{
    public partial class YeniGorevFormu : Form
    {
        private int _projeID;

        public YeniGorevFormu(int projeID)
        {
            InitializeComponent();
            _projeID = projeID;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGorevAdi.Text) || dtpBaslangicTarihi.Value == null || dtpBitisTarihi.Value == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpBaslangicTarihi.Value > dtpBitisTarihi.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden önce olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "INSERT INTO Gorevler (ProjeID, GorevAdi, BaslangicTarihi, BitisTarihi, Durum) VALUES (@ProjeID, @GorevAdi, @BaslangicTarihi, @BitisTarihi, @Durum)";
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("@ProjeID", _projeID),
                    new MySqlParameter("@GorevAdi", txtGorevAdi.Text.Trim()),
                    new MySqlParameter("@BaslangicTarihi", dtpBaslangicTarihi.Value),
                    new MySqlParameter("@BitisTarihi", dtpBitisTarihi.Value),
                    new MySqlParameter("@Durum", "Tamamlanacak")
                };

                int result = DBHelper.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Görev başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Görev eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
