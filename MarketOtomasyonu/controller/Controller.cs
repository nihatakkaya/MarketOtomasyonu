using MarketOtomasyonu.dao;
using MarketOtomasyonu.enumaration;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.controller
{
    public class Controller
    {
        Repository repository;

        public Controller()
        {
            repository = new Repository();
        }

        public User login(string kullaniciAdi, string sifre)
        {
            User result;
            if (!string.IsNullOrEmpty(kullaniciAdi) & !string.IsNullOrEmpty(sifre))
            {
                result = repository.login(kullaniciAdi, sifre);

                return result;

            }
            else
            {
                User user = new User();
                user.status = LoginStatus.eksikParametre;
                return user;

            }
        }

        public List<LoginTable> getLoginTable()
        {
            List<LoginTable> loginTablesList = repository.GetLoginTable();
            return loginTablesList;

        }

        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlikCevabi)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(guvenlikSorusu) && !string.IsNullOrEmpty(guvenlikCevabi))
            {
                LoginStatus result = repository.doAuthentication(kullaniciAdi, guvenlikSorusu, guvenlikCevabi);
                if (result == LoginStatus.basarili)
                {
                    return result;
                }
                else
                {
                    return LoginStatus.basarisiz;
                }
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus changePassword(string kullaniciAdi, string yeniSifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(yeniSifre))
            {
                LoginStatus result = repository.changePassword(kullaniciAdi, yeniSifre);
                if (result == LoginStatus.basarili)
                {
                    return result;
                }
                else
                {
                    return LoginStatus.basarisiz;
                }
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }
        public Urun urunuGetir(string barkod)
        {
            if (!string.IsNullOrEmpty(barkod))
            {
                Urun urun = repository.urunuGetir(barkod);
                return urun;
            }
            else
            {
                return null;
            }
        }


        public List<User> tumKullanicilariGetir()
        {
            Controller controller = new Controller();
            return repository.tumKullanicilariGetir();

        }

        public LoginStatus kullaniciEkle(User user)
        {
            if (string.IsNullOrEmpty(user.kullaniciAdi) && !string.IsNullOrEmpty(user.sifre) && !string.IsNullOrEmpty(user.yetki)
                && !string.IsNullOrEmpty(user.emailAdres) && !string.IsNullOrEmpty(user.guvenlikSorusu)
                && !string.IsNullOrEmpty(user.guvenlikCevabi))
            {
                Controller controller = new Controller();
                LoginStatus sonuc = repository.kullaniciEkle(user);
                return sonuc;
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus kullaniciSil(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                LoginStatus sonuc = repository.kullaniciSil(id);
                return sonuc;
            }
            else
            {
                return LoginStatus.eksikParametre;
            }

        }

        public List<Urun> tumUrunleriGetir()
        {
            return repository.tumUrunleriGetir();
        }
    }
}
