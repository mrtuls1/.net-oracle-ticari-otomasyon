namespace Oracle
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.checkSifreGoster = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(295, 209);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(141, 20);
            this.txtkullaniciadi.TabIndex = 1;
            this.txtkullaniciadi.Text = "Admin1";
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.Tomato;
            this.btngiris.Location = new System.Drawing.Point(272, 322);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(152, 30);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(295, 258);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(141, 20);
            this.txtsifre.TabIndex = 4;
            this.txtsifre.Text = "1234";
            // 
            // checkSifreGoster
            // 
            this.checkSifreGoster.AutoSize = true;
            this.checkSifreGoster.Location = new System.Drawing.Point(348, 238);
            this.checkSifreGoster.Name = "checkSifreGoster";
            this.checkSifreGoster.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkSifreGoster.Size = new System.Drawing.Size(88, 17);
            this.checkSifreGoster.TabIndex = 5;
            this.checkSifreGoster.Text = "Şifreyi Göster";
            this.checkSifreGoster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkSifreGoster.UseVisualStyleBackColor = true;
            this.checkSifreGoster.CheckedChanged += new System.EventHandler(this.chksifregoster_CheckedChanged);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 506);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.checkSifreGoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.CheckBox checkSifreGoster;
    }
}