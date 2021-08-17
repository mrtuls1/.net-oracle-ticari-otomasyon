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
    public partial class FrmAdminUrunler : Form
    {
        OracleBaglantisi conn = new OracleBaglantisi();
        public FrmAdminUrunler()
        {
            InitializeComponent();
        }

        void UrunListele()
        {
            try
            {
                OracleCommand cmd = new OracleCommand("select * from TBL_URUNLER", conn.baglanti());
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
            txtUrunID.Text = null;
            txtAd.Text = null;
            txtMarka.Text = null;
            txtUrnModeli.Text = null;
            txtAdet.Text = null;
            txtAlisFiyati.Text = null;
            txtSatisFiyati.Text = null;
            rchtxtAcıklama.Text = null;
            rchtxtKampanya.Text = null;
        }
        private void FrmAdminUrunler_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("insert into TBL_URUNLER(URUNADI,URUNMARKA,URUNMODEL,URUNADET,ALISFIYATI,SATISFIYATI,DETAY,KAMPANYA) values(:P1, :P2, :P3, :P4, :P5, :P6,:P7,:P8)", conn.baglanti());
            cmd.Parameters.Add(":P1", OracleDbType.Varchar2).Value = txtAd.Text;
            cmd.Parameters.Add(":P2", OracleDbType.Varchar2).Value = txtMarka.Text;
            cmd.Parameters.Add(":P3", OracleDbType.Varchar2).Value = txtUrnModeli.Text;
            cmd.Parameters.Add(":P4", OracleDbType.Int32).Value = txtAdet.Text;
            cmd.Parameters.Add(":P5", OracleDbType.Double).Value = txtAlisFiyati.Text;
            cmd.Parameters.Add(":P6", OracleDbType.Double).Value = txtSatisFiyati.Text;
            cmd.Parameters.Add(":P7", OracleDbType.Varchar2).Value = rchtxtAcıklama.Text;
            cmd.Parameters.Add(":P8", OracleDbType.Varchar2).Value = rchtxtKampanya.Text;
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            UrunListele();
            Reset();
            MessageBox.Show("Ürün Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("update TBL_URUNLER set URUNADI=:P1,URUNMARKA=:P2,URUNMODEL=:P3,URUNADET=:P4,ALISFIYATI=:P5,SATISFIYATI=:P6,DETAY=:P7,KAMPANYA=:P8 where URUNID=:P9", conn.baglanti());
            cmd.Parameters.Add(":P1", OracleDbType.Varchar2).Value = txtAd.Text;
            cmd.Parameters.Add(":P2", OracleDbType.Varchar2).Value = txtMarka.Text;
            cmd.Parameters.Add(":P3", OracleDbType.Varchar2).Value = txtUrnModeli.Text;
            cmd.Parameters.Add(":P4", OracleDbType.Int32).Value = txtAdet.Text;
            cmd.Parameters.Add(":P5", OracleDbType.Double).Value = txtAlisFiyati.Text;
            cmd.Parameters.Add(":P6", OracleDbType.Double).Value = txtSatisFiyati.Text;
            cmd.Parameters.Add(":P7", OracleDbType.Varchar2).Value = rchtxtAcıklama.Text;
            cmd.Parameters.Add(":P8", OracleDbType.Varchar2).Value = rchtxtKampanya.Text;
            cmd.Parameters.Add(":P9", OracleDbType.Varchar2).Value = txtUrunID.Text;
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            UrunListele();
            Reset();
            MessageBox.Show("Ürün Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("Delete TBL_URUNLER WHERE URUNID=:P1", conn.baglanti());
            cmd.Parameters.Add(":P1", OracleDbType.Int32).Value = txtUrunID.Text;
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            UrunListele();
            Reset();
            MessageBox.Show("Ürün Silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            txtUrunID.Text = dataGridView1.Rows[select].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            txtUrnModeli.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            txtAdet.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            txtAlisFiyati.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
            txtSatisFiyati.Text = dataGridView1.Rows[select].Cells[6].Value.ToString();
            rchtxtAcıklama.Text = dataGridView1.Rows[select].Cells[7].Value.ToString();
            rchtxtKampanya.Text = dataGridView1.Rows[select].Cells[8].Value.ToString();
        }
    }
}
