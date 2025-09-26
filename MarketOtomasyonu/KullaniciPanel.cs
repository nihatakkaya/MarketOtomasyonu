using MarketOtomasyonu.enumaration;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class KullaniciPanel : Form
    {
        controller.Controller controller = new controller.Controller();

        public KullaniciPanel()
        {
            InitializeComponent();
        }

        private void KullaniciPanel_Load(object sender, EventArgs e)
        {
            defaultDegerleriDoldur();
            tumKullanicilariDoldur();

        }

        private void defaultDegerleriDoldur()
        {
            combo_yetki.Items.Add("admin");
            combo_yetki.Items.Add("kasiyer");
            combo_yetki.SelectedIndex = 0;
            //--------------------------------

            combo_bolge.Items.Add("istanbul");
            combo_bolge.Items.Add("sakarya");
            combo_bolge.Items.Add("ankara");
            combo_bolge.Items.Add("kocaeli");
            combo_bolge.SelectedIndex = 0;
            //--------------------------------

            combo_guvenlikSorusu.Items.Add("En Sevdiği Renk Nedir  ?");
            combo_guvenlikSorusu.Items.Add("Okuduğu Lise Nedir ? ");
            combo_guvenlikSorusu.Items.Add("En Sevdiği Oğlu ?");
            combo_guvenlikSorusu.Items.Add("Mesleği Ne ?");
            combo_guvenlikSorusu.SelectedIndex = 0;


        }

        private void tumKullanicilariDoldur()
        {
            List<User> userList = controller.tumKullanicilariGetir();
            dataGridView1.DataSource = userList;
        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = combo_yetki.SelectedItem.ToString();
            user.bolge = combo_bolge.SelectedItem.ToString();
            user.emailAdres = txt_emailAdres.Text;
            user.guvenlikSorusu = combo_guvenlikSorusu.SelectedItem.ToString();
            user.guvenlikCevabi = txt_guvenlikCevabi.Text;
            LoginStatus sonuc = controller.kullaniciEkle(user);
            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kullanıcı başarıyla eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Kullanıcı ekleme başarısız oldu.Gerekli alanların hepsini doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            combo_yetki.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            combo_bolge.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_emailAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            combo_guvenlikSorusu.SelectedItem = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_guvenlikCevabi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            

        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_kullaniciAdi.Text))
            {
            LoginStatus sonuc = controller.kullaniciSil(int.Parse(txt_kullaniciAdi.Text));

            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kullanıcı başarıyla silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else if(sonuc == LoginStatus.basarisiz)
            {
                MessageBox.Show("Kullanıcı silme başarısız oldu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz kaydın id değerini giriniz! ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz kaydın id değerini giriniz! ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_geriCik_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();

        }
    }
}
