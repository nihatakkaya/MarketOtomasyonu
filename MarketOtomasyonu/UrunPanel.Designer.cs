namespace MarketOtomasyonu
{
    partial class UrunPanel
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
            this.btn_geriCik = new System.Windows.Forms.Button();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.txt_qrKod = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_urunIsim = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.grpbox_urunPanel = new System.Windows.Forms.GroupBox();
            this.datetime_guncellemeTarih = new System.Windows.Forms.DateTimePicker();
            this.datetime_olusturmaTarih = new System.Windows.Forms.DateTimePicker();
            this.txt_barkodKod = new System.Windows.Forms.TextBox();
            this.txt_ciro = new System.Windows.Forms.TextBox();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpbox_urunPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_geriCik
            // 
            this.btn_geriCik.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_geriCik.Location = new System.Drawing.Point(575, 208);
            this.btn_geriCik.Name = "btn_geriCik";
            this.btn_geriCik.Size = new System.Drawing.Size(173, 35);
            this.btn_geriCik.TabIndex = 12;
            this.btn_geriCik.Text = "Geri Çık";
            this.btn_geriCik.UseVisualStyleBackColor = false;
            this.btn_geriCik.Click += new System.EventHandler(this.btn_geriCik_Click);
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_kayitSil.Location = new System.Drawing.Point(396, 208);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(173, 35);
            this.btn_kayitSil.TabIndex = 11;
            this.btn_kayitSil.Text = "Kayıt Sil";
            this.btn_kayitSil.UseVisualStyleBackColor = false;
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(204, 208);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(186, 35);
            this.btn_kayitGuncelle.TabIndex = 10;
            this.btn_kayitGuncelle.Text = "Kayıt Güncelle";
            this.btn_kayitGuncelle.UseVisualStyleBackColor = false;
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_kayitEkle.Location = new System.Drawing.Point(9, 208);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(189, 35);
            this.btn_kayitEkle.TabIndex = 9;
            this.btn_kayitEkle.Text = "Kayıt Ekle";
            this.btn_kayitEkle.UseVisualStyleBackColor = false;
            // 
            // txt_qrKod
            // 
            this.txt_qrKod.Location = new System.Drawing.Point(136, 65);
            this.txt_qrKod.Name = "txt_qrKod";
            this.txt_qrKod.Size = new System.Drawing.Size(173, 21);
            this.txt_qrKod.TabIndex = 1;
            this.txt_qrKod.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged);
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(500, 96);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(173, 21);
            this.txt_fiyat.TabIndex = 7;
            this.txt_fiyat.TextChanged += new System.EventHandler(this.txt_guvenlikCevabi_TextChanged);
            // 
            // txt_urunIsim
            // 
            this.txt_urunIsim.Location = new System.Drawing.Point(500, 30);
            this.txt_urunIsim.Name = "txt_urunIsim";
            this.txt_urunIsim.Size = new System.Drawing.Size(173, 21);
            this.txt_urunIsim.TabIndex = 5;
            this.txt_urunIsim.TextChanged += new System.EventHandler(this.txt_emailAdres_TextChanged);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(136, 30);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(173, 21);
            this.txt_id.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oluşturma Tarih :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(393, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kilo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Barkod Kod :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Qr Kod :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(393, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fiyat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "İd :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(393, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün İsim :";
            // 
            // grpbox_urunPanel
            // 
            this.grpbox_urunPanel.Controls.Add(this.datetime_guncellemeTarih);
            this.grpbox_urunPanel.Controls.Add(this.datetime_olusturmaTarih);
            this.grpbox_urunPanel.Controls.Add(this.btn_geriCik);
            this.grpbox_urunPanel.Controls.Add(this.btn_kayitSil);
            this.grpbox_urunPanel.Controls.Add(this.btn_kayitGuncelle);
            this.grpbox_urunPanel.Controls.Add(this.btn_kayitEkle);
            this.grpbox_urunPanel.Controls.Add(this.txt_barkodKod);
            this.grpbox_urunPanel.Controls.Add(this.txt_qrKod);
            this.grpbox_urunPanel.Controls.Add(this.txt_ciro);
            this.grpbox_urunPanel.Controls.Add(this.txt_fiyat);
            this.grpbox_urunPanel.Controls.Add(this.txt_kilo);
            this.grpbox_urunPanel.Controls.Add(this.txt_urunIsim);
            this.grpbox_urunPanel.Controls.Add(this.txt_id);
            this.grpbox_urunPanel.Controls.Add(this.label8);
            this.grpbox_urunPanel.Controls.Add(this.label4);
            this.grpbox_urunPanel.Controls.Add(this.label6);
            this.grpbox_urunPanel.Controls.Add(this.label3);
            this.grpbox_urunPanel.Controls.Add(this.label2);
            this.grpbox_urunPanel.Controls.Add(this.label9);
            this.grpbox_urunPanel.Controls.Add(this.label7);
            this.grpbox_urunPanel.Controls.Add(this.label5);
            this.grpbox_urunPanel.Controls.Add(this.label1);
            this.grpbox_urunPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_urunPanel.Location = new System.Drawing.Point(10, 159);
            this.grpbox_urunPanel.Name = "grpbox_urunPanel";
            this.grpbox_urunPanel.Size = new System.Drawing.Size(760, 254);
            this.grpbox_urunPanel.TabIndex = 3;
            this.grpbox_urunPanel.TabStop = false;
            this.grpbox_urunPanel.Text = "Ürün Panel";
            // 
            // datetime_guncellemeTarih
            // 
            this.datetime_guncellemeTarih.Location = new System.Drawing.Point(137, 157);
            this.datetime_guncellemeTarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetime_guncellemeTarih.Name = "datetime_guncellemeTarih";
            this.datetime_guncellemeTarih.Size = new System.Drawing.Size(173, 21);
            this.datetime_guncellemeTarih.TabIndex = 4;
            // 
            // datetime_olusturmaTarih
            // 
            this.datetime_olusturmaTarih.Location = new System.Drawing.Point(137, 128);
            this.datetime_olusturmaTarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetime_olusturmaTarih.Name = "datetime_olusturmaTarih";
            this.datetime_olusturmaTarih.Size = new System.Drawing.Size(173, 21);
            this.datetime_olusturmaTarih.TabIndex = 3;
            // 
            // txt_barkodKod
            // 
            this.txt_barkodKod.Location = new System.Drawing.Point(136, 99);
            this.txt_barkodKod.Name = "txt_barkodKod";
            this.txt_barkodKod.Size = new System.Drawing.Size(173, 21);
            this.txt_barkodKod.TabIndex = 2;
            this.txt_barkodKod.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged);
            // 
            // txt_ciro
            // 
            this.txt_ciro.Location = new System.Drawing.Point(500, 134);
            this.txt_ciro.Name = "txt_ciro";
            this.txt_ciro.Size = new System.Drawing.Size(173, 21);
            this.txt_ciro.TabIndex = 8;
            this.txt_ciro.TextChanged += new System.EventHandler(this.txt_guvenlikCevabi_TextChanged);
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(500, 62);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(173, 21);
            this.txt_kilo.TabIndex = 6;
            this.txt_kilo.TextChanged += new System.EventHandler(this.txt_emailAdres_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(7, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Güncelleme Tarih :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(393, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ciro :";
            // 
            // UrunPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 421);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpbox_urunPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UrunPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunPanel";
            this.Load += new System.EventHandler(this.UrunPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpbox_urunPanel.ResumeLayout(false);
            this.grpbox_urunPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_geriCik;
        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.TextBox txt_qrKod;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_urunIsim;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpbox_urunPanel;
        private System.Windows.Forms.TextBox txt_barkodKod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ciro;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.DateTimePicker datetime_guncellemeTarih;
        private System.Windows.Forms.DateTimePicker datetime_olusturmaTarih;
    }
}