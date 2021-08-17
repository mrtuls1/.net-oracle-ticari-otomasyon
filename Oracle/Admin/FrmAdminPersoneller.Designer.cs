namespace Oracle.Admin
{
    partial class FrmAdminPersoneller
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.txtePosta = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(746, 69);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(103, 37);
            this.btnTemizle.TabIndex = 76;
            this.btnTemizle.Text = "LİSTELE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(608, 29);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(132, 69);
            this.rchAdres.TabIndex = 75;
            this.rchAdres.Text = "";
            // 
            // txtePosta
            // 
            this.txtePosta.Location = new System.Drawing.Point(259, 53);
            this.txtePosta.Name = "txtePosta";
            this.txtePosta.Size = new System.Drawing.Size(100, 20);
            this.txtePosta.TabIndex = 74;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(218, 56);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(36, 13);
            this.lblmail.TabIndex = 73;
            this.lblmail.Text = "E-Mail";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(452, 26);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Telefon: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Adres: ";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(96, 78);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Personel Soyadı: ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(96, 52);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Personel Adı: ";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Enabled = false;
            this.txtPersonelID.Location = new System.Drawing.Point(96, 26);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelID.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Personel ID:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(855, 69);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(104, 37);
            this.btnSil.TabIndex = 63;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(855, 20);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(104, 37);
            this.btnGuncelle.TabIndex = 62;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(746, 20);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 37);
            this.btnEkle.TabIndex = 61;
            this.btnEkle.Text = "PERSONEL EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(949, 413);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(259, 80);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "TC: ";
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(259, 27);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(100, 20);
            this.txtGorev.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Görevi: ";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(452, 53);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(100, 20);
            this.txtKullanici.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "Kullanıcı Adı: ";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(452, 81);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Şifre: ";
            // 
            // FrmAdminPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 568);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.rchAdres);
            this.Controls.Add(this.txtePosta);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmAdminPersoneller";
            this.Text = "FrmAdminPersoneller";
            this.Load += new System.EventHandler(this.FrmAdminPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.TextBox txtePosta;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label8;
    }
}