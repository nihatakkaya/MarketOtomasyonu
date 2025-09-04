using MarketOtomasyonu.controller;
using MarketOtomasyonu.enumaration;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            SifreDegistirme SD = new SifreDegistirme();
            SD.ShowDialog();

        }

        private void girisYap_btn_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            User result = controller.login(kullaniciAdi_txt.Text, sifre_txt.Text);
            if(result!=null && result.status==LoginStatus.basarili && result.yetki=="admin")
            {
                AdminPanel admin = new AdminPanel();
                admin.Show();
                this.Hide();
            }
            else if(result!=null && result.status==LoginStatus.basarili && result.yetki=="kasiyer")
            {
                KasiyerPanel kasiyer = new KasiyerPanel();
                kasiyer.Show();
                this.Hide();
            }
            else if(result!=null && result.status==LoginStatus.basarisiz)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(result!=null && result.status==LoginStatus.eksikParametre)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void kullaniciAdi_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
