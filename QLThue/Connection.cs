using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLThue
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=ZEN-SPRIGGAN;Initial Catalog=QLThueVayCuoi;User ID=gosu;Password=29041976";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
