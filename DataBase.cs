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
            query = "SELECT 'even' FROM MainTable WHERE MainTable.group='"+activeGroup+"' AND MainTable.dayoftheweek ='"+day+"'";
            OleDbCommand command = new OleDbCommand(query, con);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                subjects.Add(reader.GetString(0));
            }
            reader.Close();
            if (subjects.Count<2)
            {

                //Получение l1
                subjects.Clear();
                query= "SELECT l1 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l1 = new OleDbCommand(query, con);
                reader = command_l1.ExecuteReader();
                while (reader.Read())
                {
                    subjects.Add(reader[0].ToString());
                }

                //Получение l2
                query = "SELECT l2 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l2 = new OleDbCommand(query, con);
                reader = command_l2.ExecuteReader();
                while (reader.Read())
                {
                    subjects.Add(reader[0].ToString());
                }

                //Получение l3
                query = "SELECT l3 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l3 = new OleDbCommand(query, con);
                reader = command_l3.ExecuteReader();
                while (reader.Read())
                {
                    subjects.Add(reader[0].ToString());
                }

                //Получение l4
                query = "SELECT l4 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l4 = new OleDbCommand(query, con);
                reader = command_l4.ExecuteReader();
                while (reader.Read())
                {
                    subjects.Add(reader[0].ToString());
                }

                //Получение l5
                query = "SELECT l5 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l5 = new OleDbCommand(query, con);
                reader = command_l5.ExecuteReader();
                while (reader.Read())
                {
                    subjects.Add(reader[0].ToString());
                }



                reader.Close();
            }
            else
            {
                var first = new DateTime(2020, 9, 1);
                DateTime today = DateTime.Today;
                int weekNum = (today.DayOfYear - 1) / 7 + 1;
                int even = weekNum % 2;

                if ( even==0 )
                {
                    //Получение l1
                    subjects.Clear();
                    query = "SELECT l1 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l1 = new OleDbCommand(query, con);
                    reader = command_l1.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(reader[0].ToString());
                    }

                    //Получение l2
                    query = "SELECT l2 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l2 = new OleDbCommand(query, con);
                    reader = command_l2.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(reader[0].ToString());
                    }

                    //Получение l3
                    query = "SELECT l3 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l3 = new OleDbCommand(query, con);
                    reader = command_l3.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(reader[0].ToString());
                    }

                    //Получение l4
                    query = "SELECT l4 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l4 = new OleDbCommand(query, con);
                    reader = command_l4.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(reader[0].ToString());
                    }

                    //Получение l5
                    query = "SELECT l5 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l5 = new OleDbCommand(query, con);
                    reader = command_l5.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(reader[0].ToString());
                    }
                }
                else
                {
                    //Получение l1
                    subjects.Clear();
                    query = "SELECT l1 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l1 = new OleDbCommand(query, con);
                    reader = command_l1.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(reader[0].ToString());
                    }

                    //Получение l2
                    query = "SELECT l2 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l2 = new OleDbCommand(query, con);
                    reader = command_l2.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(reader[0].ToString());
                    }

                    //Получение l3
                    query = "SELECT l3 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='1'";
                    OleDbCommand command_l3 = new OleDbCommand(query, con);
                    reader = command_l3.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(reader[0].ToString());
                    }

                    //Получение l4
                    query = "SELECT l4 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='1'";
                    OleDbCommand command_l4 = new OleDbCommand(query, con);
                    reader = command_l4.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(reader[0].ToString());
                    }

                    //Получение l5
                    query = "SELECT l5 FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='1'";
                    OleDbCommand command_l5 = new OleDbCommand(query, con);
                    reader = command_l5.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(reader[0].ToString());
                    }
                }

            }

            return subjects;
        }

    }
}
