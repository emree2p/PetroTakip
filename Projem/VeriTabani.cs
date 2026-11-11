using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace Projem
{
    internal class VeriTabani
    {
        public static string Baglanti =
            @"Server=DESKTOP-7JQU40D;Database=PetroTakip;Integrated Security=True;TrustServerCertificate=True;";

        private static readonly HttpClient http = new HttpClient();

        public static async Task FiyatGuncelle()
        {
            string il = "Konya";
            string url = "https://guncelakaryakitfiyatlari.com/veri/iller.csv";

            string csv = await http.GetStringAsync(url);
            string[] satirlar = csv.Split('\n');

            foreach (string satir in satirlar.Skip(1))
            {
                string[] s = satir.Trim().Split(',');
                if (s.Length < 9 || !s[1].Equals(il, StringComparison.OrdinalIgnoreCase))
                    continue;

                decimal benzin = decimal.Parse(s[2], CultureInfo.InvariantCulture);
                decimal motorin = decimal.Parse(s[3], CultureInfo.InvariantCulture);
                decimal lpg = decimal.Parse(s[4], CultureInfo.InvariantCulture);

                using (SqlConnection con = new SqlConnection(Baglanti))
                {
                    con.Open();
                    FiyatYaz(con, "Benzin 95", benzin);
                    FiyatYaz(con, "Motorin", motorin);
                    FiyatYaz(con, "LPG", lpg);
                }
                break;
            }
        }

        public static void FiyatYaz(SqlConnection con, string yakitAd, decimal fiyat)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Yakit_turu SET yakit_birim_fiyat = @f WHERE yakit_ad = @ad", con))
            {
                cmd.Parameters.AddWithValue("@f", fiyat);
                cmd.Parameters.AddWithValue("@ad", yakitAd);
                cmd.ExecuteNonQuery();
            }
        }

        //POMPA

        public static void PompaDurumYaz(int pompaId, string durum)
        {
            using (SqlConnection con = new SqlConnection(Baglanti))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("UPDATE Pompa SET durum = @d WHERE pompa_id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@d", durum);
                    cmd.Parameters.AddWithValue("@id", pompaId);
                    cmd.ExecuteNonQuery();
                }

                string sql2 = durum == "Arızalı"
                    ? "INSERT INTO Sorun (sorun_pompa, sorun_turu, sorun_mesaj) VALUES (@id, N'Pompa Arızası', N'Pompa arızalı olarak işaretlendi')"
                    : "UPDATE Sorun SET sorun_cozuldu = 1 WHERE sorun_pompa = @id AND sorun_turu = N'Pompa Arızası' AND sorun_cozuldu = 0";

                using (SqlCommand cmd = new SqlCommand(sql2, con))
                {
                    cmd.Parameters.AddWithValue("@id", pompaId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable PompaDurumLariGetir()
        {
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT durum FROM Pompa ORDER BY pompa_id", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static string DurumGetir(int pompaId)
        {
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlCommand cmd = new SqlCommand("SELECT durum FROM Pompa WHERE pompa_id = @id", con))
            {
                cmd.Parameters.AddWithValue("@id", pompaId);
                con.Open();
                return (string)cmd.ExecuteScalar();
            }
        }

        public static decimal FiyatGetir(int pompaId)
        {
            string sql = @"SELECT y.yakit_birim_fiyat
                         FROM Pompa p
                         JOIN Tank t ON t.tank_id = p.pompa_tank
                         JOIN Yakit_turu y ON y.yakit_turu_id = t.tank_yakit_turu_id
                         WHERE p.pompa_id = @id";

            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", pompaId);
                con.Open();
                return (decimal)cmd.ExecuteScalar();
            }
        }

        public static DataTable PompaciGetir()
        {
            string sql = @"SELECT personel_id, personel_ad + N' ' + personel_soyad AS adsoyad
                         FROM Personel
                         WHERE personel_rol = N'Pompacı'";

            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //TANK

        public static DataTable TanklariGetir()
        {
            string sql = "SELECT tank_id, kapasite, mevcut_seviye, kritik_seviye FROM Tank ORDER BY tank_id";

            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static decimal TankBosYer(int tankId)
        {
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlCommand cmd = new SqlCommand("SELECT kapasite - mevcut_seviye FROM Tank WHERE tank_id = @id", con))
            {
                cmd.Parameters.AddWithValue("@id", tankId);
                con.Open();
                return (decimal)cmd.ExecuteScalar();
            }
        }

        public static void TankDolumYap(int tankId, decimal litre, string tedarikci)
        {
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlCommand cmd = new SqlCommand("sp_DolumYap", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tank", tankId);
                cmd.Parameters.AddWithValue("@litre", litre);
                cmd.Parameters.AddWithValue("@tedarikci", tedarikci);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //STOK

        public static DataTable StokHarketleriGetir()
        {
            string sql = @"SELECT s.stok_hareket_tarihi AS [Tarih],
                         N'Tank ' + CAST(s.stok_tank AS NVARCHAR(10)) AS [Tank],
                         y.yakit_ad AS [Yakıt],
                         s.stok_hareket_turu AS [Hareket],
                         s.stok_litre AS [Litre],
                         ISNULL(td.tedarikci_Ad, N'-') AS [Tedarikçi]
                         FROM Stok_hareket s
                         JOIN Tank t ON t.tank_id = s.stok_tank
                         JOIN Yakit_turu y ON y.yakit_turu_id = t.tank_yakit_turu_id
                         LEFT JOIN Tedarikci td ON td.tedarikci_id = s.stok_tedarikci
                         ORDER BY s.stok_id DESC";
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static decimal ToplamStokGetir(string yakitAd)
        {
            string sql = @"SELECT ISNULL(SUM(t.mevcut_seviye), 0)
                         FROM Tank t
                         JOIN Yakit_turu y ON y.yakit_turu_id = t.tank_yakit_turu_id
                         WHERE y.yakit_ad = @ad";

            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ad", yakitAd);
                con.Open();
                return (decimal)cmd.ExecuteScalar();
            }
        }

        public static decimal TankSeviyeGetir(int pompaId)
        {
            string sql = @"SELECT Tank.mevcut_seviye
                         FROM Pompa
                         JOIN Tank ON Tank.tank_id = Pompa.pompa_tank
                         WHERE Pompa.pompa_id = @id";

            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", pompaId);
                con.Open();
                return (decimal)cmd.ExecuteScalar();
            }
        }

        public static void SatisYap(int pompaId, int personelId, string plaka, decimal litre, decimal tutar)
        {
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlCommand cmd = new SqlCommand("sp_SatisYap", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pompa", pompaId);
                cmd.Parameters.AddWithValue("@personel", personelId);
                cmd.Parameters.AddWithValue("@plaka", plaka);
                cmd.Parameters.AddWithValue("@litre", litre);
                cmd.Parameters.AddWithValue("@tutar", tutar);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //PERSONEL

        public static DataTable PersonelGetir()
        {
            string sql = @"SELECT personel_id AS [No], personel_ad  AS [Ad], personel_soyad AS [Soyad], personel_rol AS [Rol]
                         FROM Personel
                         ORDER BY personel_id";
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

        public static int PersonelSayisiGetir(string rol)
        {
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Personel WHERE personel_rol LIKE @rol", con))
            {
                cmd.Parameters.AddWithValue("@rol", "%" + rol + "%");
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public static void PersonelEkle(string ad, string soyad, string rol)
        {
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Personel (personel_ad, personel_soyad, personel_rol) VALUES (@ad, @soyad, @rol)", con))
            {
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@rol", rol);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void PersonelSil(int personelId)
        {
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Personel WHERE personel_id = @id", con))
            {
                cmd.Parameters.AddWithValue("@id", personelId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //KASA

        public static DataTable SatislariGetir()
        {
            string sql = @"SELECT s.satis_tarihi AS [Tarih],
                         N'Pompa ' + CAST(s.satis_pompa AS NVARCHAR(10)) AS [Pompa],
                         y.yakit_ad AS [Yakıt],
                         p.personel_ad + N' ' + p.personel_soyad AS [Pompacı],
                         s.satis_plaka AS [Plaka],
                         s.satis_litre AS [Litre],
                         s.satis_birim_fiyat AS [BirimFiyat],
                         s.satis_tutar AS [Tutar]
                       FROM Satis s 
                       JOIN Yakit_turu y ON y.yakit_turu_id = s.satis_yakit_turu
                       JOIN Personel p ON p.personel_id = s.satis_personel
                       ORDER BY s.satis_id DESC";
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

        public static DataTable KasaGetir()
        {
            string sql = @"SELECT satis_tarihi AS Tarih,
                                  N'Giren' AS Islem,
                                  satis_tutar AS Gelir,
                                  0 AS Gider,
                                  satis_litre AS Litre
                                  FROM Satis
                                  UNION ALL
                                  SELECT
                                  islem_tarihi AS Tarih,
                                  N'Çıkan' AS Islem,
                                  0 AS Gelir,
                                  tutar AS Gider,
                                  stok_litre AS Litre
                                FROM Kasa_Hareket, Stok_Hareket
                                WHERE tur = N'Gider'
                                ORDER BY Tarih DESC";
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable OzetGetir()
        {
            string sql = @"SELECT ISNULL(SUM(satis_tutar), 0) AS Ciro,
                                  ISNULL(SUM(satis_litre), 0) AS Litre,                                  
                                  ISNULL(AVG(satis_tutar), 0) AS Ortalama
                         FROM Satis s
                         WHERE CAST(satis_tarihi AS DATE) = CAST(GETDATE() AS DATE)";
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable KasaGiren()
        {
            string sql = @"SELECT ISNULL(SUM(satis_tutar), 0) AS ToplamGiren
                         FROM Satis";
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable KasaCikan()
        {
            string sql = @"SELECT ISNULL(SUM(tutar), 0) AS ToplamCikan
                         FROM Kasa_Hareket
                         WHERE tur = N'Gider'";
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable KasaKarZarar()
        {
            string sql = @"SELECT ISNULL((SELECT SUM(satis_tutar)
                           FROM Satis), 0) 
                            -
                           ISNULL((SELECT SUM(tutar)
                           FROM Kasa_Hareket
                           WHERE tur = N'Gider'), 0) AS KarZarar";
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable KasaAyBasi()
        {
            string sql = @"SELECT ISNULL(SUM(satis_tutar), 0) AS ToplamAyBasi
                         FROM Satis
                         WHERE satis_tarihi >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)";
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataRow KasaOzetGetir(DateTime baslangic)
        {
            string sql = @"SELECT ISNULL(SUM(CASE WHEN tur = N'Gelir' THEN tutar END), 0) AS Giren,
                           ISNULL(SUM(CASE WHEN tur = N'Gider' THEN tutar END), 0) AS Cikan
                   FROM Kasa_hareket
                   WHERE islem_tarihi >= @baslangic";

            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                da.SelectCommand.Parameters.AddWithValue("@baslangic", baslangic);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0];
            }
        }

        // SORUNLAR
        public static DataTable SorunlariGetir()
        {
            string sql = @"SELECT sorun_tarihi AS [Tarih],
                         sorun_turu AS [Tür],
                         CASE WHEN sorun_pompa IS NOT NULL THEN N'Pompa ' + CAST(sorun_pompa AS NVARCHAR(10))
                              WHEN sorun_tank IS NOT NULL THEN N'Tank ' + CAST(sorun_tank AS NVARCHAR(10))
                              ELSE N'-' END AS [Nerede],
                         sorun_mesaj AS [Mesaj],
                         CASE WHEN sorun_cozuldu = 1 THEN N'Çözüldü' ELSE N'Açık' END AS [Durum]
                         FROM Sorun
                         ORDER BY sorun_cozuldu, sorun_id DESC";
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // RAPORLAR
        public static DataTable RaporCalistir(string sql, DateTime bas, DateTime bit)
        {
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                da.SelectCommand.Parameters.AddWithValue("@bas", bas);
                da.SelectCommand.Parameters.AddWithValue("@bit", bit);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable SatisRaporuGetir(DateTime bas, DateTime bit)
        {
            string sql = @"SELECT y.yakit_ad AS [Yakıt],
                         COUNT(*) AS [Satış Adedi],
                         SUM(s.satis_litre) AS [Toplam Litre],
                         SUM(s.satis_tutar) AS [Toplam Tutar],
                         AVG(s.satis_tutar) AS [Ortalama Tutar]
                         FROM  Satis s
                         JOIN Yakit_turu y ON y.yakit_turu_id = s.satis_yakit_turu
                         WHERE s.satis_tarihi >= @bas AND s.satis_tarihi < DATEADD(DAY, 1, @bit)
                         GROUP BY y.yakit_ad
                         ORDER BY y.yakit_ad";
            return RaporCalistir(sql, bas, bit);
        }

        public static DataTable StokRaporuGetir(DateTime bas, DateTime bit)
        {
            string sql = @"SELECT N'Tank' + CAST(t.tank_id AS NVARCHAR(10)) AS [Tank],
                         y.yakit_ad AS [Yakıt],
                         ISNULL(SUM(CASE WHEN h.stok_hareket_turu = N'Giriş' THEN h.stok_litre END), 0) AS [Giriş litre],
                         ISNULL(SUM(CASE WHEN h.stok_hareket_turu = N'Çıkış' THEN h.stok_litre END), 0) AS [Çıkış litre],
                         t.mevcut_seviye AS [Mevcut Seviye],
                         ISNULL(SUM(h.stok_alinan_litre_tutar), 0) AS [Alış Maliyeti]
                         FROM Tank t
                         JOIN Yakit_turu y ON y.yakit_turu_id = t.tank_yakit_turu_id
                         LEFT JOIN Stok_hareket h ON h.stok_tank = t.tank_id
                         AND h.stok_hareket_tarihi >= @bas AND h.stok_hareket_tarihi < DATEADD(DAY, 1, @bit)
                         GROUP BY t.tank_id, y.yakit_ad, t.mevcut_seviye
                         ORDER BY t.tank_id";
            return RaporCalistir(sql, bas, bit);
        }

        public static DataTable KasaRaporuGetir(DateTime bas, DateTime bit)
        {
            string sql = @"SELECT CAST(islem_tarihi AS DATE) AS [Tarih],
                                   SUM(CASE WHEN tur = N'Gelir' THEN tutar ELSE 0 END) AS [Gelir],
                                   SUM(CASE WHEN tur = N'Gider' THEN tutar ELSE 0 END) AS [Gider],
                                   SUM(CASE WHEN tur = N'Gelir' THEN tutar ELSE -tutar END) AS [Net]
                           FROM Kasa_Hareket
                           WHERE islem_tarihi >= @bas AND islem_tarihi < DATEADD(DAY, 1, @bit)
                           GROUP BY CAST(islem_tarihi AS DATE)
                           ORDER BY [Tarih] DESC";
            return RaporCalistir(sql, bas, bit);
        }

        //

        public static DataTable SonSatislar()
        {
            string sql = @"SELECT TOP 10 s.satis_tarihi AS [Tarih],
                         N'Pompa ' + CAST(s.satis_pompa AS NVARCHAR(10)) AS [Pompa],
                         y.yakit_ad AS [Yakıt],
                         p.personel_ad + N' ' + p.personel_soyad AS [Pompacı],
                         s.satis_plaka AS [Plaka],
                         s.satis_litre AS [Litre],
                         s.satis_birim_fiyat AS [Birim Fiyat],
                         s.satis_tutar AS [Tutar]
                       FROM Satis s 
                       JOIN Yakit_turu y ON y.yakit_turu_id = s.satis_yakit_turu
                       JOIN Personel p ON p.personel_id = s.satis_personel
                       ORDER BY s.satis_id DESC";
            using (SqlConnection con = new SqlConnection(Baglanti))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
