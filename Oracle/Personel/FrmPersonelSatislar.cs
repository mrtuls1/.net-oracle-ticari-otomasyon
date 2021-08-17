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
    public partial class FrmPersonelSatislar : Form
    {
        OracleBaglantisi conn = new OracleBaglantisi();
        void SatisListele()
        {
            try
            {
                OracleCommand cmd = new OracleCommand("select S.SATISID,S.URUNID,S.MUSTERIID,M.MUSTERIADI,M.MUSTERISOYADI,U.URUNMARKA,U.URUNADET,U.SATISFIYATI,S.TARIH from TBL_SATISLAR S INNER JOIN TBL_URUNLER U ON (S.URUNID= U.URUNID) INNER JOIN TBL_MUSTERILER M ON(S.MUSTERIID=M.MUSTERIID)", conn.baglanti());
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
            txtSatisID.Text = null;
            txtMusteriID.Text = null;
            txtUrunID.Text = null;
            txtTarih.Text = null;
        }
        public FrmPersonelSatislar()
        {
            InitializeComponent();
        }
        
        private void FrmSatislar_Load(object sender, EventArgs e)
        {
            SatisListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("insert into TBL_SATISLAR(MUSTERIID,URUNID,TARIH) values(:P1, :P2, :P3)", conn.baglanti());
            cmd.Parameters.Add(":P1", OracleDbType.Varchar2).Value = txtMusteriID.Text;
            cmd.Parameters.Add(":P2", OracleDbType.Varchar2).Value = txtUrunID.Text;
            cmd.Parameters.Add(":P3", OracleDbType.Varchar2).Value = txtTarih.Text;
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            SatisListele();
            Reset();
            MessageBox.Show("Satis Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("update TBL_SATISLAR set MUSTERIID=:P1,URUNID=:P2,TARIH=:P3 where SATISID=:P4", conn.baglanti());
            cmd.Parameters.Add(":P1", OracleDbType.Int32).Value = txtMusteriID.Text;
            cmd.Parameters.Add(":P2", OracleDbType.Int32).Value = txtUrunID.Text;
            cmd.Parameters.Add(":P3", OracleDbType.Varchar2).Value = txtTarih.Text;
            cmd.Parameters.Add(":P4", OracleDbType.Int32).Value = txtSatisID.Text;
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            SatisListele();
            Reset();
            MessageBox.Show("Müşteri Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            txtSatisID.Text = dataGridView1.Rows[select].Cells[0].Value.ToString();
            txtMusteriID.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            txtUrunID.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            txtTarih.Text = dataGridView1.Rows[select].Cells[8].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            SatisListele();
            Reset();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("Delete TBL_SATISLAR WHERE SATISID=:P1", conn.baglanti());
            cmd.Parameters.Add(":P1", OracleDbType.Int32).Value = txtSatisID.Text;
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            SatisListele();
            Reset();
            MessageBox.Show("Müşteri Silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
