using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MCOT_prj
{
    class DataBase
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Main.accdb\"";

        public SqlConnection con = new SqlConnection(connectionString);

    }
}
