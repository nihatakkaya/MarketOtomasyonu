using MarketOtomasyonu.enumaration;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.dao
{
    public class Repository
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;
        List<LoginTable> loginTablelist;
        public Repository()
        {
            con = new SqlConnection(@"Data Source=NIHAT\SQLEXPRESS01;Initial Catalog=marketOtomasyonu;Integrated Security=True;TrustServerCertificate=True");

        }
        public void baglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
        }

        public User login(string kullaniciAdi, string sifre)
        {
            con.Open();
            cmd = new SqlCommand("select * from loginTable where kullaniciAdi = @kulad and sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.kullaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.emailAdres = dr["emailAdres"].ToString();
                user.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                user.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                user.status = LoginStatus.basarili;
                return user;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.basarisiz;
                return user;

            }
            con.Open();


        }

        public List<LoginTable> GetLoginTable()
        {
            // Listeyi metodun başında oluşturmak doğru bir yaklaşım.
            List<LoginTable> loginTablelist = new List<LoginTable>();

            // 'using' blokları bağlantının ve komutların otomatik olarak kapatılmasını sağlar.
            // Bu, kodunu daha güvenli ve hataya dayanıklı hale getirir.
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=NIHAT\SQLEXPRESS01;Initial Catalog=marketOtomasyonu;Integrated Security=True;TrustServerCertificate=True"))
                {
                    using (SqlCommand cmd = new SqlCommand("guvenlikSorusuGetir_sp", con))
                    {
                        // *** ANA DÜZELTME: Komutun bir Stored Procedure olduğunu belirtiyoruz. ***
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        con.Open(); // Bağlantıyı burada açıyoruz.

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                LoginTable loginTable = new LoginTable();
                                loginTable.id = int.Parse(dr["id"].ToString());
                                loginTable.kullaniciAdi = dr["kullaniciAdi"].ToString();
                                loginTable.sifre = dr["sifre"].ToString();
                                loginTable.yetki = dr["yetki"].ToString();
                                loginTable.emailAdres = dr["emailAdres"].ToString();
                                loginTable.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                                loginTable.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                                loginTablelist.Add(loginTable);
                            }
                        }
                        // 'using' bloğu bittiğinde 'con', 'cmd' ve 'dr' otomatik olarak kapatılır/temizlenir.
                    }
                }
            }
            catch (Exception ex)
            {
                // ex.Message: Hatayı özetler.
                // ex.ToString(): Hatanın tüm detaylarını (hangi satırda olduğu vb.) verir.
                // İkisi de çok değerlidir.
                string hataDetayi = $"Hata Mesajı: {ex.Message}\n\nDetaylar: {ex.ToString()}";
                System.Windows.Forms.MessageBox.Show(hataDetayi, "Veritabanı Hatası", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return loginTablelist;
        }

        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlikCevabi)
        {
            con.Open();
            cmd = new SqlCommand("select count (*) from loginTable where kullaniciAdi = @kulad and guvenlikSorusu=@guvSorusu and guvenlikCevabi=@guvCevabi", con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@guvSorusu", guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvCevabi", guvenlikCevabi);
            returnvalue = (int)cmd.ExecuteScalar();

            con.Close();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }

        }

        public LoginStatus changePassword(string kullaniciAdi, string sifre)
        {
            con.Open();
            cmd = new SqlCommand("sifreGuncelle_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }
        public Urun urunuGetir(string barkod)
        {
            con.Open();
            cmd = new SqlCommand("select * from urun where barkodKod=@code", con);
            cmd.Parameters.AddWithValue("@code", barkod);
            dr = cmd.ExecuteReader();
            Urun urun = new Urun();
            while (dr.Read())
            {
                urun.id = dr["id"].ToString();
                urun.qrkod = dr["qrkod"].ToString();
                urun.barkodKod = dr["barkodKod"].ToString();
                //urun.olusturmaTarih = DateTime.Parse(dr["olusturmaTarih"].ToString());
                //urun.guncellemeTarih = DateTime.Parse(dr["guncellemeTarih"].ToString());
                urun.UrunIsim = dr["UrunIsim"].ToString();
                urun.kilo = int.Parse(dr["kilo"].ToString());
                urun.fiyat = int.Parse(dr["fiyat"].ToString());
                //urun.ciro = int.Parse(dr["ciro"].ToString());
            }
            con.Close();
            return urun;
        }


        public List<User> tumKullanicilariGetir()
        {
            List<User> userList = new List<User>();
            con.Open();
            cmd = new SqlCommand("select * from loginTable", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.kullaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.yetki = dr["bolge"].ToString();
                user.emailAdres = dr["emailAdres"].ToString();
                user.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                user.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                userList.Add(user);
            }
            con.Close();
            return userList;
        }

        public LoginStatus kullaniciEkle(User user)
        {
            con.Open();
            cmd = new SqlCommand("sp_kullaniciEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", user.kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@bolge", user.bolge);
            cmd.Parameters.AddWithValue("@emailAdres", user.emailAdres);
            cmd.Parameters.AddWithValue("@guvenlikSorusu", user.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikCevabi", user.guvenlikCevabi);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }

        public LoginStatus kullaniciSil(int id)
        {
            con.Open();
            cmd = new SqlCommand("delete from loginTable where id=id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int returnValue = cmd.ExecuteNonQuery();
            con.Close();

            if(returnValue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }

        public List<Urun> tumUrunleriGetir()
        {
            List<Urun> urunList = new List<Urun>();
            con.Open();
            cmd = new SqlCommand("select * from urun", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Urun urun = new Urun();
                urun.id = dr["id"].ToString();
                urun.qrkod = dr["qrkod"].ToString();
                urun.barkodKod = dr["barkodKod"].ToString();
                //urun.olusturmaTarih = DateTime.Parse(dr["olusturmaTarih"].ToString());
                //urun.guncellemeTarih = DateTime.Parse(dr["guncellemeTarih"].ToString());
                urun.UrunIsim = dr["UrunIsim"].ToString();
                urun.kilo = int.Parse(dr["kilo"].ToString());
                urun.fiyat = int.Parse(dr["fiyat"].ToString());
                //urun.ciro = int.Parse(dr["ciro"].ToString());
                urunList.Add(urun);
            }

            con.Close();
            return urunList;
        }
    }
}

