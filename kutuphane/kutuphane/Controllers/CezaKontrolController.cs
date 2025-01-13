using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public class CezaKontrolController
    {
        public void CezaKontrolu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=TALHAY\\SQLEXPRESS03;Initial Catalog=KutuphaneDB;Integrated Security=True;"))
                {
                    string query = "SELECT OduncKitaplar.KitapID, OduncKitaplar.KullaniciID, OduncKitaplar.IadeTarihi, OduncKitaplar.GecikmeCezasi " +
                                   "FROM OduncKitaplar " +
                                   "WHERE OduncKitaplar.IadeTarihi < GETDATE() AND OduncKitaplar.IadeTarihi IS NOT NULL";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    decimal cezaPerDay = 5; // Günlük ceza miktarı

                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime teslimTarihi = (DateTime)row["IadeTarihi"];
                        int kullaniciID = (int)row["KullaniciID"];
                        decimal mevcutCeza = (decimal)row["GecikmeCezasi"];

                        int gecikmeGunSayisi = (int)(DateTime.Now - teslimTarihi).TotalDays;
                        decimal yeniCeza = gecikmeGunSayisi * cezaPerDay;

                        // Eğer mevcut ceza ile yeni hesaplanan ceza eşitse, işlem yapma
                        if (mevcutCeza == yeniCeza)
                        {
                            continue;
                        }

                        // Eğer ceza farklıysa, farkı ekle
                        decimal fark = yeniCeza - mevcutCeza;

                        string updateQuery = "UPDATE OduncKitaplar SET GecikmeCezasi = GecikmeCezasi + @Fark WHERE KullaniciID = @KullaniciID AND KitapID = @KitapID";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@Fark", fark);
                        updateCmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                        updateCmd.Parameters.AddWithValue("@KitapID", row["KitapID"]);

                        conn.Open();
                        updateCmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // SQL hatası ile ilgili işlem yapabilirsiniz.
                Console.WriteLine($"SQL hata mesajı: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                // Diğer hatalar için işlem yapabilirsiniz.
                Console.WriteLine($"Hata mesajı: {ex.Message}");
            }

        }
    }
}
