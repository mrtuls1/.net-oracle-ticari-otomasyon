using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.Personel;

namespace Oracle
{
    public partial class FrmPersonelAnaSayfa : Form
    {
        public string PersonelID;
        OracleBaglantisi conn = new OracleBaglantisi();
        public FrmPersonelAnaSayfa()
        {
            InitializeComponent();
        }

        private void FrmPersonelAnaSayfa_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("Select*From TBL_PERSONELLER where PERSONELID='"+PersonelID+"'", conn.baglanti());
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblPersonelAdi.Text = dr[1].ToString() + " " + dr[2].ToString();
                lblPersonelGorevi.Text = dr[3].ToString();

            }
        }

        
        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FrmPersonelurunler fr = new FrmPersonelurunler();
            fr.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FrmPersonelMusteriler fr = new FrmPersonelMusteriler();
            fr.Show();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            FrmPersonelSatislar fr = new FrmPersonelSatislar();
            fr.Show();
        }

        private void btnHesapMakinesi_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
