using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.Admin;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Oracle
{
    public partial class FrmGiris : Form
    {
        OracleBaglantisi conn = new OracleBaglantisi();
        public FrmGiris()
        {
            InitializeComponent();
        }
           private void FrmGiris_Load(object sender, EventArgs e)
        {
           
        }

        private void chksifregoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSifreGoster.Checked)
            {
                txtsifre.PasswordChar = '\0';
            }
            else
            {
                txtsifre.PasswordChar = '*';

            }
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("Select * From TBL_PERSONELLER where KULLANICIADI=:P1 and SIFRE=:P2", conn.baglanti());
            cmd.Parameters.Add("P1",OracleDbType.Varchar2).Value = txtkullaniciadi.Text;
            cmd.Parameters.Add("P2",OracleDbType.Varchar2).Value = txtsifre.Text;
            
            OracleDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                FrmPersonelAnaSayfa fr = new FrmPersonelAnaSayfa();
                fr.PersonelID = dr[0].ToString();
                fr.Show();
                this.Hide();
                conn.baglanti().Close();
            }
            else
            {
                OracleCommand cmd2 = new OracleCommand("Select * From TBL_ADMIN where KULLANICIADI=:P1 and SIFRE=:P2", conn.baglanti());
                cmd2.Parameters.Add("P1", OracleDbType.Varchar2).Value = txtkullaniciadi.Text;
                cmd2.Parameters.Add("P2", OracleDbType.Varchar2).Value = txtsifre.Text;

                OracleDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.Read())
                {
                    FrmAdminAnasayfa fr2 = new FrmAdminAnasayfa();
                    fr2.AdminID = dr2[3].ToString()+" "+dr2[4].ToString();
                    fr2.Show();
                    this.Hide();
                    conn.baglanti().Close();
                }
                else
                {
                    MessageBox.Show("Kullanıc adı veya Şifre Hatalı!");
                }
            }
          
        }
    }
}
