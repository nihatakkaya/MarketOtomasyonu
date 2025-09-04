using MarketOtomasyonu.controller;
using MarketOtomasyonu.enumaration;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class SifreDegistirme : Form
    {
        int code;
        private Controller controller;
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            List<LoginTable> loginTableList = controller.getLoginTable();
            mailAlani_grpbox.Enabled = false;
            sifreDegistirmeAlani_grpbox.Enabled = false;

            foreach (LoginTable loginTable in loginTableList)
            {
                GuvenlikSorusu_comboBox.Items.Add(loginTable.guvenlikSorusu);
            }
            GuvenlikSorusu_comboBox.SelectedIndex = 0;
        }

        private void SifreDegistirme_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GuvenlikSorusu_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Controller controller = new Controller();
            LoginStatus result = controller.doAuthentication(kullaniciAdi_txt.Text.Trim().ToLower(), GuvenlikSorusu_comboBox.SelectedItem.ToString(), guvenlikCevabi_txt.Text.ToLower());

            if (result == LoginStatus.basarili)
            {
                mailAlani_grpbox.Enabled = true;
                MessageBox.Show("Doğrulama Başarılı. Lütfen E-Mail Adresinizi Giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Doğrulama Başarısız. Lütfen bilgilerinizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == LoginStatus.eksikParametre)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }

        }

        private void dogrulamaKoduGonder_btn_Click(object sender, EventArgs e, MailAddress mailAddress)
        {
            Random rdn = new Random();
            code = rdn.Next(111111, 999999);

            MailAddress mailAlan = new MailAddress(eMailAdresi_txt.Text, "Berkay Akkaya");
            MailAddress mailGonderen = new MailAddress("nakkaya2001@hotmail.com", "Nihat Akkaya");
            MailMessage mesaj = new MailMessage();

            mesaj.To.Add(mailAlan);
            mesaj.From = mailGonderen;
            mesaj.Subject = "Şifre Değitirme";
            mesaj.Body = "Şifrenizi değiştirmek için doğrulama kodunuz: " + code;

            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential("nakkaya2001@hotmail.com", "eMailAdresininŞifresi");
            smtp.EnableSsl = true;
            smtp.Send(mesaj);
            MessageBox.Show("Doğrulama kodu gönderildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void onayla_btn_Click(object sender, EventArgs e)
        {
            if (dogrulamaKodu_txt.Text==code.ToString())
            {
                sifreDegistirmeAlani_grpbox.Enabled = true;
            }
        }

        private void dogrulamaKodu_lbl_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void degistir_btn_Click(object sender, EventArgs e)
        {
            controller.Controller controller = new Controller();
            if(yeniSifre_txt.Text==yeniSifreTkr_txt.Text)
            {
                LoginStatus result = controller.changePassword(kullaniciAdi_txt.Text.Trim().ToLower(), yeniSifre_txt.Text);
                if (result == LoginStatus.basarili)
                {
                    MessageBox.Show("Şifre Değiştirme Başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (result == LoginStatus.basarisiz)
                {
                    MessageBox.Show("Şifre Değiştirme Başarısız. Lütfen bilgilerinizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == LoginStatus.eksikParametre)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                }
            }
            else
            {
                MessageBox.Show("Yeni Şifre ile Yeni Şifre Tekrar Alanı Uyuşmuyor. Lütfen Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void yeniSifre_lbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void eMailAdresi_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
