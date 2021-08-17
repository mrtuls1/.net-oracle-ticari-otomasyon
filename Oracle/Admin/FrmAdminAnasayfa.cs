using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle.Admin
{
    public partial class FrmAdminAnasayfa : Form
    {
        public string AdminID;
        public FrmAdminAnasayfa()
        {
            InitializeComponent();
        }

        private void FrmAdminAnasayfa_Load(object sender, EventArgs e)
        {
            label2.Text = AdminID;
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FrmAdminUrunler fr = new FrmAdminUrunler();
            fr.Show();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            FrmAdminPersoneller fr = new FrmAdminPersoneller();
            fr.Show();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            FrmAdminSatislar fr = new FrmAdminSatislar();
            fr.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FrmAdminMusteriler fr = new FrmAdminMusteriler();
            fr.Show();
        }

        private void btnUygulamaAyarlari_Click(object sender, EventArgs e)
        {
            FrmAdminAyarlar fr = new FrmAdminAyarlar();
            fr.Show();
        }

        private void btnKullaniciAyarlari_Click(object sender, EventArgs e)
        {

        }
    }
}
