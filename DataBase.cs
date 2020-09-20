using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MCOT_prj
{
    class DataBase:Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Main.accdb\"";



        public OleDbConnection con = new OleDbConnection(connectionString);
        string query;
        public string activeGroup { get; set; }
        public List<string> groups = new List<string>();

        public void findGroups()
        {


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


        public List<string> GetSubj( string day)
        {

            List<string> subjects = new List<string>();
            query = "SELECT even FROM MainTable WHERE MainTable.group='"+activeGroup+"' AND MainTable.dayoftheweek ='"+day+"'";
            MessageBox.Show(query);
            OleDbCommand command = new OleDbCommand(query, con);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                subjects.Add(reader.GetString(0));
            }

            return subjects;
        }

    }
}
