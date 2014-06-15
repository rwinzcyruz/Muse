using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Muse
{
    class DbManager
    {
        private SqlConnection _conn = new SqlConnection();
        private SqlDataAdapter _adapter = new SqlDataAdapter();
        private DataSet _dataSet = new DataSet();

        public DbManager(string connStr)
        {
            this._conn.ConnectionString = connStr;
        }
    }
}
