namespace MarketOtomasyonu
{
    partial class KasiyerPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerPanel));
            this.btn_et = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_sut = new System.Windows.Forms.Button();
            this.btn_meyveAndSebze = new System.Windows.Forms.Button();
            this.btn_bakla = new System.Windows.Forms.Button();
            this.btn_cikisYap = new System.Windows.Forms.Button();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_et
            // 
            this.btn_et.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_et.ImageKey = "et.ico";
            this.btn_et.ImageList = this.ımageList1;
            this.btn_et.Location = new System.Drawing.Point(16, 44);
            this.btn_et.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_et.Name = "btn_et";
            this.btn_et.Size = new System.Drawing.Size(251, 231);
            this.btn_et.TabIndex = 0;
            this.btn_et.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "meyveAndSebze.ico");
            this.ımageList1.Images.SetKeyName(1, "baklagil.ico");
            this.ımageList1.Images.SetKeyName(2, "süt.ico");
            this.ımageList1.Images.SetKeyName(3, "et.ico");
            // 
            // btn_sut
            // 
            this.btn_sut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sut.ImageKey = "süt.ico";
            this.btn_sut.ImageList = this.ımageList1;
            this.btn_sut.Location = new System.Drawing.Point(289, 44);
            this.btn_sut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sut.Name = "btn_sut";
            this.btn_sut.Size = new System.Drawing.Size(251, 231);
            this.btn_sut.TabIndex = 1;
            this.btn_sut.UseVisualStyleBackColor = true;
            // 
            // btn_meyveAndSebze
            // 
            this.btn_meyveAndSebze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_meyveAndSebze.ImageIndex = 0;
            this.btn_meyveAndSebze.ImageList = this.ımageList1;
            this.btn_meyveAndSebze.Location = new System.Drawing.Point(289, 283);
            this.btn_meyveAndSebze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_meyveAndSebze.Name = "btn_meyveAndSebze";
            this.btn_meyveAndSebze.Size = new System.Drawing.Size(251, 231);
            this.btn_meyveAndSebze.TabIndex = 3;
            this.btn_meyveAndSebze.UseVisualStyleBackColor = true;
            this.btn_meyveAndSebze.Click += new System.EventHandler(this.btn_meyveAndSebze_Click);
            // 
            // btn_bakla
            // 
            this.btn_bakla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bakla.ImageKey = "baklagil.ico";
            this.btn_bakla.ImageList = this.ımageList1;
            this.btn_bakla.Location = new System.Drawing.Point(16, 283);
            this.btn_bakla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_bakla.Name = "btn_bakla";
            this.btn_bakla.Size = new System.Drawing.Size(251, 231);
            this.btn_bakla.TabIndex = 2;
            this.btn_bakla.UseVisualStyleBackColor = true;
            // 
            // btn_cikisYap
            // 
            this.btn_cikisYap.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_cikisYap.Location = new System.Drawing.Point(295, 529);
            this.btn_cikisYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cikisYap.Name = "btn_cikisYap";
            this.btn_cikisYap.Size = new System.Drawing.Size(251, 52);
            this.btn_cikisYap.TabIndex = 4;
            this.btn_cikisYap.Text = "Çıkış Yap";
            this.btn_cikisYap.UseVisualStyleBackColor = false;
            this.btn_cikisYap.Click += new System.EventHandler(this.btn_cikisYap_Click);
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(449, 11);
            this.lbl_saat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(33, 16);
            this.lbl_saat.TabIndex = 5;
            this.lbl_saat.Text = "saat";
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Location = new System.Drawing.Point(471, 11);
            this.lbl_dakika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(48, 16);
            this.lbl_dakika.TabIndex = 5;
            this.lbl_dakika.Text = "dakika";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Location = new System.Drawing.Point(493, 11);
            this.lbl_saniye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(47, 16);
            this.lbl_saniye.TabIndex = 5;
            this.lbl_saniye.Text = "saniye";
            this.lbl_saniye.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KasiyerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 596);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.btn_cikisYap);
            this.Controls.Add(this.btn_bakla);
            this.Controls.Add(this.btn_meyveAndSebze);
            this.Controls.Add(this.btn_sut);
            this.Controls.Add(this.btn_et);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KasiyerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KasiyerPanel";
            this.Load += new System.EventHandler(this.KasiyerPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_et;
        private System.Windows.Forms.Button btn_sut;
        private System.Windows.Forms.Button btn_meyveAndSebze;
        private System.Windows.Forms.Button btn_bakla;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_cikisYap;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Timer timer1;
    }
}