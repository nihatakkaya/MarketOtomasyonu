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

    }
}
