using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Oracle
{
    class OracleBaglantisi
    {
        public CommandType CommandType { get; internal set; }

        public OracleConnection baglanti()
        {
            OracleConnection baglan = new OracleConnection("User Id = mert; Password = 123456; Data Source = //localhost:1521 / ORCL");
            baglan.Open();
            return baglan;
        }
    }
}
