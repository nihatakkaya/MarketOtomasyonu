namespace MarketOtomasyonu
{
    partial class SifreDegistirme
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
            this.guvenlikSoruYontemi_grpbox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GuvenlikSorusu_comboBox = new System.Windows.Forms.ComboBox();
            this.guvenlikCevabi_txt = new System.Windows.Forms.TextBox();
            this.GuvenlikCevabi_lbl = new System.Windows.Forms.Label();
            this.GuvenlikSorusu_lbl = new System.Windows.Forms.Label();
            this.kullaniciAdi_txt = new System.Windows.Forms.TextBox();
            this.kullaniciAdi_lbl = new System.Windows.Forms.Label();
            this.mailAlani_grpbox = new System.Windows.Forms.GroupBox();
            this.onayla_btn = new System.Windows.Forms.Button();
            this.dogrulamaKodu_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dogrulamaKoduGonder_btn = new System.Windows.Forms.Button();
            this.eMailAdresi_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sifreDegistirmeAlani_grpbox = new System.Windows.Forms.GroupBox();
            this.degistir_btn = new System.Windows.Forms.Button();
            this.yeniSifreTkr_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yeniSifre_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guvenlikSoruYontemi_grpbox.SuspendLayout();
            this.mailAlani_grpbox.SuspendLayout();
            this.sifreDegistirmeAlani_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // guvenlikSoruYontemi_grpbox
            // 
            this.guvenlikSoruYontemi_grpbox.Controls.Add(this.button1);
            this.guvenlikSoruYontemi_grpbox.Controls.Add(this.GuvenlikSorusu_comboBox);
            this.guvenlikSoruYontemi_grpbox.Controls.Add(this.guvenlikCevabi_txt);
            this.guvenlikSoruYontemi_grpbox.Controls.Add(this.GuvenlikCevabi_lbl);
            this.guvenlikSoruYontemi_grpbox.Controls.Add(this.GuvenlikSorusu_lbl);
            this.guvenlikSoruYontemi_grpbox.Controls.Add(this.kullaniciAdi_txt);
            this.guvenlikSoruYontemi_grpbox.Controls.Add(this.kullaniciAdi_lbl);
            this.guvenlikSoruYontemi_grpbox.Location = new System.Drawing.Point(0, 0);
            this.guvenlikSoruYontemi_grpbox.Name = "guvenlikSoruYontemi_grpbox";
            this.guvenlikSoruYontemi_grpbox.Size = new System.Drawing.Size(288, 279);
            this.guvenlikSoruYontemi_grpbox.TabIndex = 0;
            this.guvenlikSoruYontemi_grpbox.TabStop = false;
            this.guvenlikSoruYontemi_grpbox.Text = "Güvenlik Soru Yöntemi";
            this.guvenlikSoruYontemi_grpbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(12, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuvenlikSorusu_comboBox
            // 
            this.GuvenlikSorusu_comboBox.FormattingEnabled = true;
            this.GuvenlikSorusu_comboBox.Location = new System.Drawing.Point(106, 87);
            this.GuvenlikSorusu_comboBox.Name = "GuvenlikSorusu_comboBox";
            this.GuvenlikSorusu_comboBox.Size = new System.Drawing.Size(169, 21);
            this.GuvenlikSorusu_comboBox.TabIndex = 1;
            this.GuvenlikSorusu_comboBox.SelectedIndexChanged += new System.EventHandler(this.GuvenlikSorusu_comboBox_SelectedIndexChanged);
            // 
            // guvenlikCevabi_txt
            // 
            this.guvenlikCevabi_txt.Location = new System.Drawing.Point(106, 123);
            this.guvenlikCevabi_txt.Name = "guvenlikCevabi_txt";
            this.guvenlikCevabi_txt.Size = new System.Drawing.Size(169, 20);
            this.guvenlikCevabi_txt.TabIndex = 2;
            // 
            // GuvenlikCevabi_lbl
            // 
            this.GuvenlikCevabi_lbl.AutoSize = true;
            this.GuvenlikCevabi_lbl.Location = new System.Drawing.Point(6, 126);
            this.GuvenlikCevabi_lbl.Name = "GuvenlikCevabi_lbl";
            this.GuvenlikCevabi_lbl.Size = new System.Drawing.Size(94, 13);
            this.GuvenlikCevabi_lbl.TabIndex = 0;
            this.GuvenlikCevabi_lbl.Text = "Güvenlik Cevabı : ";
            this.GuvenlikCevabi_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // GuvenlikSorusu_lbl
            // 
            this.GuvenlikSorusu_lbl.AutoSize = true;
            this.GuvenlikSorusu_lbl.Location = new System.Drawing.Point(6, 90);
            this.GuvenlikSorusu_lbl.Name = "GuvenlikSorusu_lbl";
            this.GuvenlikSorusu_lbl.Size = new System.Drawing.Size(94, 13);
            this.GuvenlikSorusu_lbl.TabIndex = 0;
            this.GuvenlikSorusu_lbl.Text = "Güvenlik Sorusu : ";
            this.GuvenlikSorusu_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // kullaniciAdi_txt
            // 
            this.kullaniciAdi_txt.Location = new System.Drawing.Point(106, 48);
            this.kullaniciAdi_txt.Name = "kullaniciAdi_txt";
            this.kullaniciAdi_txt.Size = new System.Drawing.Size(169, 20);
            this.kullaniciAdi_txt.TabIndex = 0;
            // 
            // kullaniciAdi_lbl
            // 
            this.kullaniciAdi_lbl.AutoSize = true;
            this.kullaniciAdi_lbl.Location = new System.Drawing.Point(8, 48);
            this.kullaniciAdi_lbl.Name = "kullaniciAdi_lbl";
            this.kullaniciAdi_lbl.Size = new System.Drawing.Size(73, 13);
            this.kullaniciAdi_lbl.TabIndex = 0;
            this.kullaniciAdi_lbl.Text = "Kullanıcı Adı : ";
            this.kullaniciAdi_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // mailAlani_grpbox
            // 
            this.mailAlani_grpbox.Controls.Add(this.onayla_btn);
            this.mailAlani_grpbox.Controls.Add(this.dogrulamaKodu_txt);
            this.mailAlani_grpbox.Controls.Add(this.label2);
            this.mailAlani_grpbox.Controls.Add(this.dogrulamaKoduGonder_btn);
            this.mailAlani_grpbox.Controls.Add(this.eMailAdresi_txt);
            this.mailAlani_grpbox.Controls.Add(this.label1);
            this.mailAlani_grpbox.Location = new System.Drawing.Point(307, 0);
            this.mailAlani_grpbox.Name = "mailAlani_grpbox";
            this.mailAlani_grpbox.Size = new System.Drawing.Size(317, 124);
            this.mailAlani_grpbox.TabIndex = 1;
            this.mailAlani_grpbox.TabStop = false;
            this.mailAlani_grpbox.Text = "Mail Alanı";
            // 
            // onayla_btn
            // 
            this.onayla_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.onayla_btn.Location = new System.Drawing.Point(194, 77);
            this.onayla_btn.Name = "onayla_btn";
            this.onayla_btn.Size = new System.Drawing.Size(102, 31);
            this.onayla_btn.TabIndex = 5;
            this.onayla_btn.Text = "Onayla";
            this.onayla_btn.UseVisualStyleBackColor = false;
            this.onayla_btn.Click += new System.EventHandler(this.onayla_btn_Click);
            // 
            // dogrulamaKodu_txt
            // 
            this.dogrulamaKodu_txt.Location = new System.Drawing.Point(105, 83);
            this.dogrulamaKodu_txt.Name = "dogrulamaKodu_txt";
            this.dogrulamaKodu_txt.Size = new System.Drawing.Size(83, 20);
            this.dogrulamaKodu_txt.TabIndex = 3;
            this.dogrulamaKodu_txt.TextChanged += new System.EventHandler(this.dogrulamaKodu_lbl_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğrulama Kodu : ";
            // 
            // dogrulamaKoduGonder_btn
            // 
            this.dogrulamaKoduGonder_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dogrulamaKoduGonder_btn.Location = new System.Drawing.Point(132, 48);
            this.dogrulamaKoduGonder_btn.Name = "dogrulamaKoduGonder_btn";
            this.dogrulamaKoduGonder_btn.Size = new System.Drawing.Size(164, 27);
            this.dogrulamaKoduGonder_btn.TabIndex = 1;
            this.dogrulamaKoduGonder_btn.Text = "Doğrulama Kodu Gönder";
            this.dogrulamaKoduGonder_btn.UseVisualStyleBackColor = false;
            // 
            // eMailAdresi_txt
            // 
            this.eMailAdresi_txt.Location = new System.Drawing.Point(105, 19);
            this.eMailAdresi_txt.Name = "eMailAdresi_txt";
            this.eMailAdresi_txt.Size = new System.Drawing.Size(191, 20);
            this.eMailAdresi_txt.TabIndex = 0;
            this.eMailAdresi_txt.TextChanged += new System.EventHandler(this.eMailAdresi_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Adresi : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sifreDegistirmeAlani_grpbox
            // 
            this.sifreDegistirmeAlani_grpbox.Controls.Add(this.degistir_btn);
            this.sifreDegistirmeAlani_grpbox.Controls.Add(this.yeniSifreTkr_txt);
            this.sifreDegistirmeAlani_grpbox.Controls.Add(this.label4);
            this.sifreDegistirmeAlani_grpbox.Controls.Add(this.yeniSifre_txt);
            this.sifreDegistirmeAlani_grpbox.Controls.Add(this.label3);
            this.sifreDegistirmeAlani_grpbox.Location = new System.Drawing.Point(307, 137);
            this.sifreDegistirmeAlani_grpbox.Name = "sifreDegistirmeAlani_grpbox";
            this.sifreDegistirmeAlani_grpbox.Size = new System.Drawing.Size(317, 142);
            this.sifreDegistirmeAlani_grpbox.TabIndex = 2;
            this.sifreDegistirmeAlani_grpbox.TabStop = false;
            this.sifreDegistirmeAlani_grpbox.Text = "Şifre Değiştirme";
            // 
            // degistir_btn
            // 
            this.degistir_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.degistir_btn.Location = new System.Drawing.Point(187, 84);
            this.degistir_btn.Name = "degistir_btn";
            this.degistir_btn.Size = new System.Drawing.Size(109, 39);
            this.degistir_btn.TabIndex = 4;
            this.degistir_btn.Text = "Değiştir";
            this.degistir_btn.UseVisualStyleBackColor = false;
            this.degistir_btn.Click += new System.EventHandler(this.degistir_btn_Click);
            // 
            // yeniSifreTkr_txt
            // 
            this.yeniSifreTkr_txt.Location = new System.Drawing.Point(105, 58);
            this.yeniSifreTkr_txt.Name = "yeniSifreTkr_txt";
            this.yeniSifreTkr_txt.Size = new System.Drawing.Size(191, 20);
            this.yeniSifreTkr_txt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yeni Şifre Tkr : ";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // yeniSifre_txt
            // 
            this.yeniSifre_txt.Location = new System.Drawing.Point(105, 32);
            this.yeniSifre_txt.Name = "yeniSifre_txt";
            this.yeniSifre_txt.Size = new System.Drawing.Size(191, 20);
            this.yeniSifre_txt.TabIndex = 0;
            this.yeniSifre_txt.TextChanged += new System.EventHandler(this.yeniSifre_lbl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yeni Şifre : ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // SifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 285);
            this.Controls.Add(this.sifreDegistirmeAlani_grpbox);
            this.Controls.Add(this.mailAlani_grpbox);
            this.Controls.Add(this.guvenlikSoruYontemi_grpbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegistirme";
            this.Load += new System.EventHandler(this.SifreDegistirme_Load);
            this.guvenlikSoruYontemi_grpbox.ResumeLayout(false);
            this.guvenlikSoruYontemi_grpbox.PerformLayout();
            this.mailAlani_grpbox.ResumeLayout(false);
            this.mailAlani_grpbox.PerformLayout();
            this.sifreDegistirmeAlani_grpbox.ResumeLayout(false);
            this.sifreDegistirmeAlani_grpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox guvenlikSoruYontemi_grpbox;
        private System.Windows.Forms.Label kullaniciAdi_lbl;
        private System.Windows.Forms.TextBox guvenlikCevabi_txt;
        private System.Windows.Forms.Label GuvenlikCevabi_lbl;
        private System.Windows.Forms.Label GuvenlikSorusu_lbl;
        private System.Windows.Forms.TextBox kullaniciAdi_txt;
        private System.Windows.Forms.ComboBox GuvenlikSorusu_comboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox mailAlani_grpbox;
        private System.Windows.Forms.Button dogrulamaKoduGonder_btn;
        private System.Windows.Forms.TextBox eMailAdresi_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button degistir_btn;
        private System.Windows.Forms.TextBox dogrulamaKodu_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox sifreDegistirmeAlani_grpbox;
        private System.Windows.Forms.Button onayla_btn;
        private System.Windows.Forms.TextBox yeniSifreTkr_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yeniSifre_txt;
        private System.Windows.Forms.Label label3;
    }
}