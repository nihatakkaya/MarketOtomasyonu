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
    public partial class UrunPanel : Form
    {
        controller.Controller controller = new controller.Controller();
        public UrunPanel()
        {
            InitializeComponent();
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_guvenlikCevabi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_emailAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void UrunPanel_Load(object sender, EventArgs e)
        {
            tumurunlerigetir();
        }
        public void tumurunlerigetir()
        {
           dataGridView1.DataSource = controller.tumUrunleriGetir();
        }

        private void btn_geriCik_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();

        }
    }
}
