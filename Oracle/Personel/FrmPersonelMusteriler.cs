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

namespace Oracle.Personel
{
    public partial class FrmPersonelMusteriler : Form
    {
        OracleBaglantisi conn = new OracleBaglantisi();
        void MusteriListele()
        {
            try
            {
                OracleCommand cmd = new OracleCommand("select * from TBL_MUSTERILER", conn.baglanti());
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
            txtMusteriID.Text = null;
            txtAd.Text = null;
            txtSoyad.Text = null;
            txtTelefon.Text = null;
            txtePosta.Text = null;
            rchAdres.Text = null;
        }
        public FrmPersonelMusteriler()
        {
            InitializeComponent();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("insert into TBL_MUSTERILER(MUSTERIADI,MUSTERISOYADI,TELEFON,MAIL,ADRES) values(:P1, :P2, :P3, :P4, :P5)", conn.baglanti());
            cmd.Parameters.Add(":P1", OracleDbType.Varchar2).Value = txtAd.Text;
            cmd.Parameters.Add(":P2", OracleDbType.Varchar2).Value = txtSoyad.Text;
            cmd.Parameters.Add(":P3", OracleDbType.Varchar2).Value = txtTelefon.Text;
            cmd.Parameters.Add(":P4", OracleDbType.Varchar2).Value = txtePosta.Text;
            cmd.Parameters.Add(":P5", OracleDbType.Varchar2).Value = rchAdres.Text;
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            MusteriListele();
            Reset();
            MessageBox.Show("Müşteri Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("update TBL_MUSTERILER set MUSTERIADI=:P1,MUSTERISOYADI=:P2,TELEFON=:P3,MAIL=:P4,ADRES=:P5 where MUSTERIID=:P6", conn.baglanti());
            cmd.Parameters.Add(":P1", OracleDbType.Varchar2).Value = txtAd.Text;
            cmd.Parameters.Add(":P2", OracleDbType.Varchar2).Value = txtSoyad.Text;
            cmd.Parameters.Add(":P3", OracleDbType.Varchar2).Value = txtTelefon.Text;
            cmd.Parameters.Add(":P4", OracleDbType.Varchar2).Value = txtePosta.Text;
            cmd.Parameters.Add(":P5", OracleDbType.Varchar2).Value = rchAdres.Text;
            cmd.Parameters.Add(":P6", OracleDbType.Int32).Value = txtMusteriID.Text;
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            MusteriListele();
            Reset();
            MessageBox.Show("Müşteri Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            txtMusteriID.Text = dataGridView1.Rows[select].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            txtePosta.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            rchAdres.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("Delete TBL_MUSTERILER WHERE MUSTERIID=:P1", conn.baglanti());
            cmd.Parameters.Add(":P1", OracleDbType.Int32).Value = txtMusteriID.Text;
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            MusteriListele();
            Reset();
            MessageBox.Show("Müşteri Silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            MusteriListele();
            Reset();
        }
    }
}
