using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MCOT_prj
{
    class DataBase
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Main.accdb\"";



        public OleDbConnection con = new OleDbConnection(connectionString);
        string query;

        public List<string> groups = new List<string>();

        public void findGroups()
        {
            Form1 f = new Form1();

            query = "SELECT MainTable.group FROM MainTable";
            OleDbCommand command = new OleDbCommand(query, con);
            OleDbDataReader reader= command.ExecuteReader();

            while (reader.Read())
            {
                if (!groups.Contains(reader.GetString(0)))
                {
                    groups.Add(reader.GetString(0));
                }

            }
            reader.Close();



        }

    }
}
