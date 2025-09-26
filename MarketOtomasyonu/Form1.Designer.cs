namespace MarketOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kullaniciAdi = new System.Windows.Forms.Label();
            this.kullaniciAdi_txt = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.girisYap_btn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sifreSifirlama_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdi.Location = new System.Drawing.Point(219, 63);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(99, 15);
            this.kullaniciAdi.TabIndex = 4;
            this.kullaniciAdi.Text = "Kullanıcı Adı : ";
            this.kullaniciAdi.Click += new System.EventHandler(this.label1_Click);
            // 
            // kullaniciAdi_txt
            // 
            this.kullaniciAdi_txt.Location = new System.Drawing.Point(353, 63);
            this.kullaniciAdi_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciAdi_txt.Name = "kullaniciAdi_txt";
            this.kullaniciAdi_txt.Size = new System.Drawing.Size(231, 22);
            this.kullaniciAdi_txt.TabIndex = 0;
            this.kullaniciAdi_txt.TextChanged += new System.EventHandler(this.kullaniciAdi_txt_TextChanged);
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(219, 119);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(49, 15);
            this.sifre.TabIndex = 5;
            this.sifre.Text = "Şifre : ";
            this.sifre.Click += new System.EventHandler(this.label1_Click);
            // 
            // sifre_txt
            // 
            this.sifre_txt.Location = new System.Drawing.Point(353, 119);
            this.sifre_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(231, 22);
            this.sifre_txt.TabIndex = 1;
            // 
            // girisYap_btn
            // 
            this.girisYap_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.girisYap_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYap_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.girisYap_btn.ImageIndex = 0;
            this.girisYap_btn.ImageList = this.ımageList1;
            this.girisYap_btn.Location = new System.Drawing.Point(447, 162);
            this.girisYap_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.girisYap_btn.Name = "girisYap_btn";
            this.girisYap_btn.Size = new System.Drawing.Size(137, 39);
            this.girisYap_btn.TabIndex = 2;
            this.girisYap_btn.Text = "Giriş Yap";
            this.girisYap_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.girisYap_btn.UseVisualStyleBackColor = false;
            this.girisYap_btn.Click += new System.EventHandler(this.girisYap_btn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "girisYap.ico");
            // 
            // sifreSifirlama_lbl
            // 
            this.sifreSifirlama_lbl.AutoSize = true;
            this.sifreSifirlama_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreSifirlama_lbl.ForeColor = System.Drawing.Color.Navy;
            this.sifreSifirlama_lbl.Location = new System.Drawing.Point(219, 174);
            this.sifreSifirlama_lbl.Name = "sifreSifirlama_lbl";
            this.sifreSifirlama_lbl.Size = new System.Drawing.Size(111, 15);
            this.sifreSifirlama_lbl.TabIndex = 3;
            this.sifreSifirlama_lbl.Text = "Şifremi Unuttum";
            this.sifreSifirlama_lbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(596, 229);
            this.Controls.Add(this.sifreSifirlama_lbl);
            this.Controls.Add(this.girisYap_btn);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.kullaniciAdi_txt);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label kullaniciAdi;
        private System.Windows.Forms.TextBox kullaniciAdi_txt;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.Button girisYap_btn;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label sifreSifirlama_lbl;
    }
}

