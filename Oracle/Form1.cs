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



namespace Oracle
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            try
            {
                OracleBaglantisi conn = new OracleBaglantisi();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            OracleCommand komut = new OracleCommand();
        }
    }
}
//User Id = system; Password = 123456; Data Source = localhost:1521 / XE
// OracleConnection conn = new OracleConnection("User Id = Northwind; Password = 123456; Data Source = //localhost:1521 / ORCL");