using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using ExcelApp = Microsoft.Office.Interop.Excel;



namespace Oracle.Admin
{
    public partial class FrmAdminSatislar : Form
    {
        OracleBaglantisi conn = new OracleBaglantisi();
        void SatisListele()
        {
            try
            {
                OracleCommand cmd = new OracleCommand("select S.SATISID,S.URUNID,S.MUSTERIID,M.MUSTERIADI,M.MUSTERISOYADI,U.URUNMARKA,U.URUNADET,U.SATISFIYATI,S.TARIH from TBL_SATISLAR S INNER JOIN TBL_URUNLER U ON (S.URUNID= U.URUNID) INNER JOIN TBL_MUSTERILER M ON(S.MUSTERIID=M.MUSTERIID)", conn.baglanti());
                OracleDataReader reader = cmd.ExecuteReader();
                System.Data.DataTable dataTable = new System.Data.DataTable();
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
        public FrmAdminSatislar()
        {
            InitializeComponent();
        }

        private void FrmAdminSatislar_Load(object sender, EventArgs e)
        {
            SatisListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn.baglanti();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_satis_sil";
                cmd.Parameters.Add("v_satis_id", OracleDbType.Varchar2).Value = txtSatisID.Text;
                cmd.ExecuteNonQuery();
                conn.baglanti().Close();
                SatisListele();
                Reset();
                MessageBox.Show("Müşteri Silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn.baglanti();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_satis_guncelle";
                cmd.Parameters.Add("v_musteri_id", OracleDbType.Varchar2).Value = txtMusteriID.Text;
                cmd.Parameters.Add("v_urun_id", OracleDbType.Varchar2).Value = txtUrunID.Text;
                cmd.Parameters.Add("v_tarih", OracleDbType.Varchar2).Value = txtTarih.Text;
                cmd.Parameters.Add("v_satis_id", OracleDbType.Varchar2).Value = txtSatisID.Text;
                cmd.ExecuteNonQuery();
                conn.baglanti().Close();
                SatisListele();
                Reset();
                MessageBox.Show("Müşteri Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn.baglanti();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_satis_kaydet";
                cmd.Parameters.Add("v_musteri_id", OracleDbType.Varchar2).Value = txtMusteriID.Text;
                cmd.Parameters.Add("v_urun_id", OracleDbType.Varchar2).Value = txtUrunID.Text;
                cmd.Parameters.Add("v_tarih", OracleDbType.Varchar2).Value = txtTarih.Text;
                cmd.ExecuteNonQuery();
                conn.baglanti().Close();
                SatisListele();
                Reset();
                MessageBox.Show("Satis Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            SatisListele();
            Reset();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            txtSatisID.Text = dataGridView1.Rows[select].Cells[0].Value.ToString();
            txtMusteriID.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            txtUrunID.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            txtTarih.Text = dataGridView1.Rows[select].Cells[8].Value.ToString();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                btnExport.Visible = true;

                string DosyaYolu;
                string DosyaAdi;
                System.Data.DataTable dt;
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Excel Dosyası | *.xls; *.xlsx; *.xlsm";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    DosyaYolu = file.FileName;// seçilen dosyanın tüm yolunu verir
                    DosyaAdi = file.SafeFileName;// seçilen dosyanın adını verir.
                    ExcelApp.Application excelApp = new ExcelApp.Application();
                    if (excelApp == null)
                    { //Excel Yüklümü Kontrolü Yapılmaktadır.
                        MessageBox.Show("Excel yüklü değil.");
                        return;
                    }

                    //Excel Dosyası Açılıyor.
                    ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DosyaYolu);
                    //Excel Dosyasının Sayfası Seçilir.
                    ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
                    //Excel Dosyasının ne kadar satır ve sütun kaplıyorsa tüm alanları alır.
                    ExcelApp.Range excelRange = excelSheet.UsedRange;
                    satirSayisi = excelRange.Rows.Count; //Sayfanın satır sayısını alır.
                    sutunSayisi = excelRange.Columns.Count;//Sayfanın sütun sayısını alır.
                    dt = ToDataTable(excelRange, satirSayisi, sutunSayisi);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    //Okuduktan Sonra Excel Uygulamasını Kapatıyoruz.
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }
                else
                {
                    MessageBox.Show("Dosya Seçilemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public System.Data.DataTable ToDataTable(ExcelApp.Range range, int rows, int cols)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            for (int i = 1; i <= rows; i++)
            {
                if (i == 1)
                { // ilk satırı Sutun Adları olarak kullanıldığından
                  // bunları Sutün Adları Olarak Kaydediyoruz.
                    for (int j = 1; j <= cols; j++)
                    {
                        //Sütunların içeriği boş mu kontrolü yapılmaktadır.
                        if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                            table.Columns.Add(range.Cells[i, j].Value2.ToString());
                        else //Boş olduğunda Kaçınsı Sutünsa Adı veriliyor.
                            table.Columns.Add(j.ToString() + ".Sütun");
                    }
                    continue;
                }
                // Yukarıda Sütunlar eklendi
                // onun şemasına göre yeni bir satır oluşturuyoruz. 
                // Okunan verileri yan yana sıralamak için
                var yeniSatir = table.NewRow();
                for (int j = 1; j <= cols; j++)
                {
                    // Sütunların içeriği boş mu kontrolü yapılmaktadır.
                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                        yeniSatir[j - 1] = range.Cells[i, j].Value2.ToString();
                    else // İçeriği boş hücrede hata vermesini önlemek için
                        yeniSatir[j - 1] = String.Empty;
                }
                table.Rows.Add(yeniSatir);
            }
            return table;
        }

        public int satirSayisi;
        public int sutunSayisi;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application exceldosya = new Excel.Application();
                exceldosya.Visible = true;
                object Missing = Type.Missing;

                Workbook bolumlistesi = exceldosya.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)bolumlistesi.Sheets[1];
                int sutun = 1;
                int satır = 1;

                for (int j = 0; j < dataGridView1.Columns.Count; j++)

                {
                    Range myrange = (Range)sheet1.Cells[satır, sutun + j];
                    myrange.Value2 = dataGridView1.Columns[j].HeaderText;


                }

                satır++;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Range myrange = (Range)sheet1.Cells[satır + i, sutun + j];
                        myrange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myrange.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
