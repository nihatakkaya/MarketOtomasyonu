namespace MarketOtomasyonu
{
    partial class KullaniciPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpbox_kullanici = new System.Windows.Forms.GroupBox();
            this.btn_geriCik = new System.Windows.Forms.Button();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.combo_bolge = new System.Windows.Forms.ComboBox();
            this.combo_guvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.combo_yetki = new System.Windows.Forms.ComboBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.txt_emailAdres = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpbox_kullanici.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // grpbox_kullanici
            // 
            this.grpbox_kullanici.Controls.Add(this.btn_geriCik);
            this.grpbox_kullanici.Controls.Add(this.btn_kayitSil);
            this.grpbox_kullanici.Controls.Add(this.btn_kayitGuncelle);
            this.grpbox_kullanici.Controls.Add(this.btn_kayitEkle);
            this.grpbox_kullanici.Controls.Add(this.combo_bolge);
            this.grpbox_kullanici.Controls.Add(this.combo_guvenlikSorusu);
            this.grpbox_kullanici.Controls.Add(this.combo_yetki);
            this.grpbox_kullanici.Controls.Add(this.txt_sifre);
            this.grpbox_kullanici.Controls.Add(this.txt_guvenlikCevabi);
            this.grpbox_kullanici.Controls.Add(this.txt_emailAdres);
            this.grpbox_kullanici.Controls.Add(this.txt_kullaniciAdi);
            this.grpbox_kullanici.Controls.Add(this.label4);
            this.grpbox_kullanici.Controls.Add(this.label6);
            this.grpbox_kullanici.Controls.Add(this.label3);
            this.grpbox_kullanici.Controls.Add(this.label2);
            this.grpbox_kullanici.Controls.Add(this.label7);
            this.grpbox_kullanici.Controls.Add(this.label5);
            this.grpbox_kullanici.Controls.Add(this.label1);
            this.grpbox_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_kullanici.Location = new System.Drawing.Point(13, 199);
            this.grpbox_kullanici.Margin = new System.Windows.Forms.Padding(4);
            this.grpbox_kullanici.Name = "grpbox_kullanici";
            this.grpbox_kullanici.Padding = new System.Windows.Forms.Padding(4);
            this.grpbox_kullanici.Size = new System.Drawing.Size(1007, 313);
            this.grpbox_kullanici.TabIndex = 1;
            this.grpbox_kullanici.TabStop = false;
            this.grpbox_kullanici.Text = "Kullanıcı Panel";
            // 
            // btn_geriCik
            // 
            this.btn_geriCik.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_geriCik.Location = new System.Drawing.Point(808, 256);
            this.btn_geriCik.Margin = new System.Windows.Forms.Padding(4);
            this.btn_geriCik.Name = "btn_geriCik";
            this.btn_geriCik.Size = new System.Drawing.Size(190, 43);
            this.btn_geriCik.TabIndex = 9;
            this.btn_geriCik.Text = "Geri Çık";
            this.btn_geriCik.UseVisualStyleBackColor = false;
            this.btn_geriCik.Click += new System.EventHandler(this.btn_geriCik_Click);
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_kayitSil.Location = new System.Drawing.Point(569, 256);
            this.btn_kayitSil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(190, 43);
            this.btn_kayitSil.TabIndex = 9;
            this.btn_kayitSil.Text = "Kayıt Sil";
            this.btn_kayitSil.UseVisualStyleBackColor = false;
            this.btn_kayitSil.Click += new System.EventHandler(this.btn_kayitSil_Click);
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(313, 256);
            this.btn_kayitGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(207, 43);
            this.btn_kayitGuncelle.TabIndex = 8;
            this.btn_kayitGuncelle.Text = "Kayıt Güncelle";
            this.btn_kayitGuncelle.UseVisualStyleBackColor = false;
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_kayitEkle.Location = new System.Drawing.Point(53, 256);
            this.btn_kayitEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(211, 43);
            this.btn_kayitEkle.TabIndex = 7;
            this.btn_kayitEkle.Text = "Kayıt Ekle";
            this.btn_kayitEkle.UseVisualStyleBackColor = false;
            this.btn_kayitEkle.Click += new System.EventHandler(this.btn_kayitEkle_Click);
            // 
            // combo_bolge
            // 
            this.combo_bolge.FormattingEnabled = true;
            this.combo_bolge.Location = new System.Drawing.Point(184, 159);
            this.combo_bolge.Margin = new System.Windows.Forms.Padding(4);
            this.combo_bolge.Name = "combo_bolge";
            this.combo_bolge.Size = new System.Drawing.Size(188, 23);
            this.combo_bolge.TabIndex = 3;
            // 
            // combo_guvenlikSorusu
            // 
            this.combo_guvenlikSorusu.FormattingEnabled = true;
            this.combo_guvenlikSorusu.Location = new System.Drawing.Point(622, 78);
            this.combo_guvenlikSorusu.Margin = new System.Windows.Forms.Padding(4);
            this.combo_guvenlikSorusu.Name = "combo_guvenlikSorusu";
            this.combo_guvenlikSorusu.Size = new System.Drawing.Size(188, 23);
            this.combo_guvenlikSorusu.TabIndex = 5;
            // 
            // combo_yetki
            // 
            this.combo_yetki.FormattingEnabled = true;
            this.combo_yetki.Location = new System.Drawing.Point(184, 118);
            this.combo_yetki.Margin = new System.Windows.Forms.Padding(4);
            this.combo_yetki.Name = "combo_yetki";
            this.combo_yetki.Size = new System.Drawing.Size(188, 23);
            this.combo_yetki.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(184, 80);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(188, 21);
            this.txt_sifre.TabIndex = 1;
            // 
            // txt_guvenlikCevabi
            // 
            this.txt_guvenlikCevabi.Location = new System.Drawing.Point(622, 121);
            this.txt_guvenlikCevabi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guvenlikCevabi.Name = "txt_guvenlikCevabi";
            this.txt_guvenlikCevabi.Size = new System.Drawing.Size(188, 21);
            this.txt_guvenlikCevabi.TabIndex = 6;
            // 
            // txt_emailAdres
            // 
            this.txt_emailAdres.Location = new System.Drawing.Point(622, 37);
            this.txt_emailAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emailAdres.Name = "txt_emailAdres";
            this.txt_emailAdres.Size = new System.Drawing.Size(188, 21);
            this.txt_emailAdres.TabIndex = 4;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(184, 37);
            this.txt_kullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(188, 21);
            this.txt_kullaniciAdi.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bölge :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(420, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Güvenlik Sorusu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yetki :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(420, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Güvenlik cevabi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(420, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "E -Mail Adresi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // KullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 520);
            this.Controls.Add(this.grpbox_kullanici);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciPanel";
            this.Load += new System.EventHandler(this.KullaniciPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpbox_kullanici.ResumeLayout(false);
            this.grpbox_kullanici.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpbox_kullanici;
        private System.Windows.Forms.ComboBox combo_bolge;
        private System.Windows.Forms.ComboBox combo_guvenlikSorusu;
        private System.Windows.Forms.ComboBox combo_yetki;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_guvenlikCevabi;
        private System.Windows.Forms.TextBox txt_emailAdres;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.Button btn_geriCik;
    }
}