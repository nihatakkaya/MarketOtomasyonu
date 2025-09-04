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
    public partial class MeyveSebzePanel : Form
    {
        int sayi1;
        int sayi2;
        int islemTipi; // 1 toplama, 2 cikarma, 3 carpma, 4 bolme

        public MeyveSebzePanel()
        {
            InitializeComponent();
            txt_islemKutusu.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_uzum_Click(object sender, EventArgs e)
        {

        }

        private void btn_iki_Click(object sender, EventArgs e)
        {
            islemTipi = 4;
            sayi1 = Convert.ToInt32(txt_islemKutusu.Text);
            txt_islemKutusu.Text = "0";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MeyveSebzePanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void secilenTus(object sender, EventArgs e)
        {
            if (txt_islemKutusu.Text == "0")
            {
                txt_islemKutusu.Text = "";
            }
            txt_islemKutusu.Text += ((Button)sender).Text;
        }

        private void btn_arti_Click(object sender, EventArgs e)
        {
            islemTipi = 1;
            sayi1 = Convert.ToInt32(txt_islemKutusu.Text);
            txt_islemKutusu.Text = "0";

        }

        private void btn_eksi_Click(object sender, EventArgs e)
        {
            islemTipi = 2;
            sayi1 = Convert.ToInt32(txt_islemKutusu.Text);
            txt_islemKutusu.Text = "0";
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (islemTipi == 1)
            {
                sayi2 = int.Parse(txt_islemKutusu.Text);
                txt_islemKutusu.Text = (sayi1 + sayi2).ToString();
            }
            else if (islemTipi == 2)
            {
                sayi2 = int.Parse(txt_islemKutusu.Text);
                txt_islemKutusu.Text = (sayi1 - sayi2).ToString();
            }
            else if (islemTipi == 3)
            {
                sayi2 = int.Parse(txt_islemKutusu.Text);
                txt_islemKutusu.Text = (sayi1 * sayi2).ToString();
            }
            else if (islemTipi == 4)
            {
                sayi2 = int.Parse(txt_islemKutusu.Text);
                if (sayi2 != 0)
                {
                    txt_islemKutusu.Text = (sayi1 / sayi2).ToString();
                }
                else
                {
                    MessageBox.Show("Bir sayı sıfıra bölünemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_islemKutusu.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir işlem seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_gerigel_Click(object sender, EventArgs e)
        {
           if(txt_islemKutusu.Text.Length > 0)
            {
                txt_islemKutusu.Text = txt_islemKutusu.Text.Substring(0, txt_islemKutusu.Text.Length - 1);
            }
            else 
            {
                txt_islemKutusu.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString();
            lbl_dakika.Text = DateTime.Now.Minute.ToString();
            lbl_saniye.Text = DateTime.Now.Second.ToString();
        }
    }
}
