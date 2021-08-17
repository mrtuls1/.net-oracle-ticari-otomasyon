namespace Oracle.Admin
{
    partial class FrmAdminAnasayfa
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
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnUygulamaAyarlari = new System.Windows.Forms.Button();
            this.btnKullaniciAyarlari = new System.Windows.Forms.Button();
            this.btnSatislar = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPersonelAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Location = new System.Drawing.Point(582, 245);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(138, 122);
            this.btnPersoneller.TabIndex = 19;
            this.btnPersoneller.Text = "PERSONELLER";
            this.btnPersoneller.UseVisualStyleBackColor = true;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnUygulamaAyarlari
            // 
            this.btnUygulamaAyarlari.Location = new System.Drawing.Point(393, 245);
            this.btnUygulamaAyarlari.Name = "btnUygulamaAyarlari";
            this.btnUygulamaAyarlari.Size = new System.Drawing.Size(138, 122);
            this.btnUygulamaAyarlari.TabIndex = 18;
            this.btnUygulamaAyarlari.Text = "KULLANICI AYARLARI";
            this.btnUygulamaAyarlari.UseVisualStyleBackColor = true;
            this.btnUygulamaAyarlari.Click += new System.EventHandler(this.btnUygulamaAyarlari_Click);
            // 
            // btnKullaniciAyarlari
            // 
            this.btnKullaniciAyarlari.Location = new System.Drawing.Point(209, 245);
            this.btnKullaniciAyarlari.Name = "btnKullaniciAyarlari";
            this.btnKullaniciAyarlari.Size = new System.Drawing.Size(138, 122);
            this.btnKullaniciAyarlari.TabIndex = 17;
            this.btnKullaniciAyarlari.Text = "UYGULAMA AYARLARI";
            this.btnKullaniciAyarlari.UseVisualStyleBackColor = true;
            this.btnKullaniciAyarlari.Click += new System.EventHandler(this.btnKullaniciAyarlari_Click);
            // 
            // btnSatislar
            // 
            this.btnSatislar.Location = new System.Drawing.Point(582, 97);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(138, 122);
            this.btnSatislar.TabIndex = 16;
            this.btnSatislar.Text = "SATIŞLAR";
            this.btnSatislar.UseVisualStyleBackColor = true;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Location = new System.Drawing.Point(393, 97);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(138, 122);
            this.btnMusteriler.TabIndex = 15;
            this.btnMusteriler.Text = "MÜSTERİLER";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(209, 97);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(138, 122);
            this.btnUrunler.TabIndex = 14;
            this.btnUrunler.Text = "ÜRÜNLER";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Yönetici Adı: ";
            // 
            // lblPersonelAdi
            // 
            this.lblPersonelAdi.AutoSize = true;
            this.lblPersonelAdi.Location = new System.Drawing.Point(26, 42);
            this.lblPersonelAdi.Name = "lblPersonelAdi";
            this.lblPersonelAdi.Size = new System.Drawing.Size(69, 13);
            this.lblPersonelAdi.TabIndex = 10;
            this.lblPersonelAdi.Text = "Yönetici Adı: ";
            // 
            // FrmAdminAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPersoneller);
            this.Controls.Add(this.btnUygulamaAyarlari);
            this.Controls.Add(this.btnKullaniciAyarlari);
            this.Controls.Add(this.btnSatislar);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPersonelAdi);
            this.Name = "FrmAdminAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminAnasayfa";
            this.Load += new System.EventHandler(this.FrmAdminAnasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Button btnUygulamaAyarlari;
        private System.Windows.Forms.Button btnKullaniciAyarlari;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPersonelAdi;
    }
}