using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProjeYonetimSistemi
{
    public static class DBHelper
    {
        private static readonly string connectionString = "Server=localhost;Database=project_management;Uid=root;Pwd=2468;";

        // Veritabanı bağlantısını döner
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Tek bir değeri dönen sorgular için (ör. COUNT, MAX, MIN)
        public static object ExecuteScalar(string query, MySqlParameter[] parameters = null)
        {
            object result = null;
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        result = cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ExecuteScalar Hatası: {ex.Message}");
                }
            }
            return result;
        }

        // Veri ekleme, silme veya güncelleme işlemleri için
        public static int ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ExecuteNonQuery Hatası: {ex.Message}");
                }
            }
            return rowsAffected;
        }

        // Verileri okuma işlemi için
        public static MySqlDataReader ExecuteReader(string query, MySqlParameter[] parameters = null)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                // Komutu çalıştır ve bağlantıyı otomatik olarak kapat
                MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine($"ExecuteReader Hatası: {ex.Message}");
                throw;
            }
        }

        // DataTable döndürmek için (Listeleme işlemi)
        public static DataTable Listele(string query, MySqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Listele Hatası: {ex.Message}");
                throw new Exception("Veritabanı işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            return dataTable;
        }
    }
}
