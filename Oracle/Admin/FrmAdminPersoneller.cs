using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace Oracle.Admin
{
    public partial class FrmAdminPersoneller : Form
    {
        OracleBaglantisi conn = new OracleBaglantisi();
        void PersonelListele()
        {
            try
            {
                OracleCommand cmd = new OracleCommand("select * from TBL_PERSONELLER", conn.baglanti());
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        void Reset()
        {
            txtAd.Text = null;
            txtSoyad.Text = null;
            txtGorev.Text = null;
            txtTelefon.Text = null;
            txtTC.Text = null;
            txtePosta.Text = null;
            rchAdres.Text = null;
            txtKullanici.Text = null;
            txtSifre.Text = null;
        }

        public FrmAdminPersoneller()
        {
            InitializeComponent();
        }

        private void FrmAdminPersoneller_Load(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("insert into TBL_PERSONELLER(PERSONELAD,PERSONELSOYAD,GOREV,TELEFON,TC,MAIL,ADRES,KULLANICIADI,SIFRE) values(:P1, :P2, :P3, :P4, :P5,:P6,:P7,:P8,:P9)", conn.baglanti());
            cmd.Parameters.Add(":P1", OracleDbType.Varchar2).Value = txtAd.Text;
            cmd.Parameters.Add(":P2", OracleDbType.Varchar2).Value = txtSoyad.Text;
            cmd.Parameters.Add(":P3", OracleDbType.Varchar2).Value = txtGorev.Text;
            cmd.Parameters.Add(":P4", OracleDbType.Varchar2).Value = txtTelefon.Text;
            cmd.Parameters.Add(":P5", OracleDbType.Varchar2).Value = txtTC.Text;
            cmd.Parameters.Add(":P6", OracleDbType.Varchar2).Value = txtePosta.Text;
            cmd.Parameters.Add(":P7", OracleDbType.Varchar2).Value = rchAdres.Text;
            cmd.Parameters.Add(":P8", OracleDbType.Varchar2).Value = txtKullanici.Text;
            cmd.Parameters.Add(":P9", OracleDbType.Varchar2).Value = txtSifre.Text;
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            PersonelListele();
            Reset();
            MessageBox.Show("Personel Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("update TBL_PERSONELLER set PERSONELAD=:P1,PERSONELSOYAD=:P2,GOREV=:P3,TELEFON=:P4,TC=:P5,MAIL=:P6,ADRES=:P7,KULLANICIADI=:P8,SIFRE=:P9 where PERSONELID=:P10", conn.baglanti());
            cmd.Parameters.Add(":P1", OracleDbType.Varchar2).Value = txtAd.Text;
            cmd.Parameters.Add(":P2", OracleDbType.Varchar2).Value = txtSoyad.Text;
            cmd.Parameters.Add(":P3", OracleDbType.Varchar2).Value = txtGorev.Text;
            cmd.Parameters.Add(":P4", OracleDbType.Varchar2).Value = txtTelefon.Text;
            cmd.Parameters.Add(":P5", OracleDbType.Varchar2).Value = txtTC.Text;
            cmd.Parameters.Add(":P6", OracleDbType.Varchar2).Value = txtePosta.Text;
            cmd.Parameters.Add(":P7", OracleDbType.Varchar2).Value = rchAdres.Text;
            cmd.Parameters.Add(":P8", OracleDbType.Varchar2).Value = txtKullanici.Text;
            cmd.Parameters.Add(":P9", OracleDbType.Varchar2).Value = txtSifre.Text;
            cmd.Parameters.Add(":P10", OracleDbType.Varchar2).Value = txtPersonelID.Text;
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            PersonelListele();
            Reset();
            MessageBox.Show("Personel Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            txtPersonelID.Text = dataGridView1.Rows[select].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            txtGorev.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            txtTC.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
            txtePosta.Text = dataGridView1.Rows[select].Cells[6].Value.ToString();
            rchAdres.Text = dataGridView1.Rows[select].Cells[7].Value.ToString();
            txtKullanici.Text = dataGridView1.Rows[select].Cells[8].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[select].Cells[9].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("Delete TBL_PERSONELLER WHERE PERSONELID=:P1", conn.baglanti());
            cmd.Parameters.Add(":P1", OracleDbType.Int32).Value = txtPersonelID.Text;
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            PersonelListele();
            Reset();
            MessageBox.Show("Personel Silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            PersonelListele();
            Reset();
        }
    }
}
