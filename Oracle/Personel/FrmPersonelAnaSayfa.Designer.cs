namespace Oracle
{
    partial class FrmPersonelAnaSayfa
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
            this.lblPersonelAdi = new System.Windows.Forms.Label();
            this.lblPersonelGorevi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnSatislar = new System.Windows.Forms.Button();
            this.btnKullaniciAyarlari = new System.Windows.Forms.Button();
            this.btnUygulamaAyarlari = new System.Windows.Forms.Button();
            this.btnHesapMakinesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPersonelAdi
            // 
            this.lblPersonelAdi.AutoSize = true;
            this.lblPersonelAdi.Location = new System.Drawing.Point(125, 31);
            this.lblPersonelAdi.Name = "lblPersonelAdi";
            this.lblPersonelAdi.Size = new System.Drawing.Size(35, 13);
            this.lblPersonelAdi.TabIndex = 0;
            this.lblPersonelAdi.Text = "label1";
            // 
            // lblPersonelGorevi
            // 
            this.lblPersonelGorevi.AutoSize = true;
            this.lblPersonelGorevi.Location = new System.Drawing.Point(125, 55);
            this.lblPersonelGorevi.Name = "lblPersonelGorevi";
            this.lblPersonelGorevi.Size = new System.Drawing.Size(35, 13);
            this.lblPersonelGorevi.TabIndex = 1;
            this.lblPersonelGorevi.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personel Görevi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Adı: ";
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(197, 119);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(138, 122);
            this.btnUrunler.TabIndex = 4;
            this.btnUrunler.Text = "ÜRÜNLER";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Location = new System.Drawing.Point(381, 119);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(138, 122);
            this.btnMusteriler.TabIndex = 5;
            this.btnMusteriler.Text = "MÜSTERİLER";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnSatislar
            // 
            this.btnSatislar.Location = new System.Drawing.Point(570, 119);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(138, 122);
            this.btnSatislar.TabIndex = 6;
            this.btnSatislar.Text = "SATIŞLAR";
            this.btnSatislar.UseVisualStyleBackColor = true;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // btnKullaniciAyarlari
            // 
            this.btnKullaniciAyarlari.Location = new System.Drawing.Point(197, 267);
            this.btnKullaniciAyarlari.Name = "btnKullaniciAyarlari";
            this.btnKullaniciAyarlari.Size = new System.Drawing.Size(138, 122);
            this.btnKullaniciAyarlari.TabIndex = 7;
            this.btnKullaniciAyarlari.Text = "KULLANICI AYARLARI";
            this.btnKullaniciAyarlari.UseVisualStyleBackColor = true;
            // 
            // btnUygulamaAyarlari
            // 
            this.btnUygulamaAyarlari.Location = new System.Drawing.Point(381, 267);
            this.btnUygulamaAyarlari.Name = "btnUygulamaAyarlari";
            this.btnUygulamaAyarlari.Size = new System.Drawing.Size(138, 122);
            this.btnUygulamaAyarlari.TabIndex = 8;
            this.btnUygulamaAyarlari.Text = "UYGULAMA AYARLARI";
            this.btnUygulamaAyarlari.UseVisualStyleBackColor = true;
            // 
            // btnHesapMakinesi
            // 
            this.btnHesapMakinesi.Location = new System.Drawing.Point(570, 267);
            this.btnHesapMakinesi.Name = "btnHesapMakinesi";
            this.btnHesapMakinesi.Size = new System.Drawing.Size(138, 122);
            this.btnHesapMakinesi.TabIndex = 9;
            this.btnHesapMakinesi.Text = "HESAP MAKİNESİ";
            this.btnHesapMakinesi.UseVisualStyleBackColor = true;
            this.btnHesapMakinesi.Click += new System.EventHandler(this.btnHesapMakinesi_Click);
            // 
            // FrmPersonelAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapMakinesi);
            this.Controls.Add(this.btnUygulamaAyarlari);
            this.Controls.Add(this.btnKullaniciAyarlari);
            this.Controls.Add(this.btnSatislar);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPersonelGorevi);
            this.Controls.Add(this.lblPersonelAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPersonelAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonelAnaSayfa";
            this.Load += new System.EventHandler(this.FrmPersonelAnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonelAdi;
        private System.Windows.Forms.Label lblPersonelGorevi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.Button btnKullaniciAyarlari;
        private System.Windows.Forms.Button btnUygulamaAyarlari;
        private System.Windows.Forms.Button btnHesapMakinesi;
        public System.Windows.Forms.Button btnMusteriler;
    }
}