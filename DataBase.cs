using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MCOT_prj
{
    class DataBase : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Main.accdb\"";

        public DateTime ChoosedDay = DateTime.Today;

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

                int even = CalculateTheWeek(ChoosedDay);


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

        public int CalculateTheWeek(DateTime selected)
        {
            int day = selected.DayOfYear;
            var first = new DateTime(2020, 9, 1);
            int weekNum = (day - 1) / 7 + 1;
            int even = weekNum % 2;
            return even;
        }

        public List<string> GetTeacher(string day)
        {

            List<string> teachers = new List<string>();
            query = "SELECT 'even' FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
            OleDbCommand command = new OleDbCommand(query, con);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                teachers.Add(reader.GetString(0));
            }
            reader.Close();
            if (teachers.Count < 2)
            {

                //Получение t1_teacher
                teachers.Clear();
                query = "SELECT l1_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l1_teacher = new OleDbCommand(query, con);
                reader = command_l1_teacher.ExecuteReader();
                while (reader.Read())
                {
                    teachers.Add(reader[0].ToString());
                }

                //Получение l2_teacher
                query = "SELECT l2_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l2_teacher = new OleDbCommand(query, con);
                reader = command_l2_teacher.ExecuteReader();
                while (reader.Read())
                {
                    teachers.Add(reader[0].ToString());
                }

                //Получение l3_teacher
                query = "SELECT l3_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l3_teacher = new OleDbCommand(query, con);
                reader = command_l3_teacher.ExecuteReader();
                while (reader.Read())
                {
                    teachers.Add(reader[0].ToString());
                }

                //Получение l4_teacher
                query = "SELECT l4_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l4_teacher = new OleDbCommand(query, con);
                reader = command_l4_teacher.ExecuteReader();
                while (reader.Read())
                {
                    teachers.Add(reader[0].ToString());
                }

                //Получение l5_teacher
                query = "SELECT l5_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l5_teacher = new OleDbCommand(query, con);
                reader = command_l5_teacher.ExecuteReader();
                while (reader.Read())
                {
                    teachers.Add(reader[0].ToString());
                }



                reader.Close();
            }
            else
            {

                int even = CalculateTheWeek(ChoosedDay);


                if (even == 0)
                {
                    //Получение l1_teacher
                    teachers.Clear();
                    query = "SELECT l1_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l1_teacher = new OleDbCommand(query, con);
                    reader = command_l1_teacher.ExecuteReader();
                    while (reader.Read())
                    {
                        teachers.Add(reader[0].ToString());
                    }

                    //Получение l2_teacher
                    query = "SELECT l2_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l2_teacher = new OleDbCommand(query, con);
                    reader = command_l2_teacher.ExecuteReader();
                    while (reader.Read())
                    {
                        teachers.Add(reader[0].ToString());
                    }

                    //Получение l3_teacher
                    query = "SELECT l3_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l3_teacher = new OleDbCommand(query, con);
                    reader = command_l3_teacher.ExecuteReader();
                    while (reader.Read())
                    {
                        teachers.Add(reader[0].ToString());
                    }

                    //Получение l4_teacher
                    query = "SELECT l4_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l4_teacher = new OleDbCommand(query, con);
                    reader = command_l4_teacher.ExecuteReader();
                    while (reader.Read())
                    {
                        teachers.Add(reader[0].ToString());
                    }

                    //Получение l5_teacher
                    query = "SELECT l5_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l5_teacher = new OleDbCommand(query, con);
                    reader = command_l5_teacher.ExecuteReader();
                    while (reader.Read())
                    {
                        teachers.Add(reader[0].ToString());
                    }
                }
                else
                {
                    //Получение l1_teacher
                    teachers.Clear();
                    query = "SELECT l1_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l1_teacher = new OleDbCommand(query, con);
                    reader = command_l1_teacher.ExecuteReader();
                    while (reader.Read())
                    {
                        teachers.Add(reader[0].ToString());
                    }

                    //Получение l2_teacher
                    query = "SELECT l2_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l2_teacher = new OleDbCommand(query, con);
                    reader = command_l2_teacher.ExecuteReader();
                    while (reader.Read())
                    {
                        teachers.Add(reader[0].ToString());
                    }

                    //Получение l3_teacher
                    query = "SELECT l3_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='1'";
                    OleDbCommand command_l3_teacher = new OleDbCommand(query, con);
                    reader = command_l3_teacher.ExecuteReader();
                    while (reader.Read())
                    {
                        teachers.Add(reader[0].ToString());
                    }

                    //Получение l4_teacher
                    query = "SELECT l4_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='1'";
                    OleDbCommand command_l4_teacher = new OleDbCommand(query, con);
                    reader = command_l4_teacher.ExecuteReader();
                    while (reader.Read())
                    {
                        teachers.Add(reader[0].ToString());
                    }

                    //Получение l5_teacher
                    query = "SELECT l5_teacher FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='1'";
                    OleDbCommand command_l5_teacher = new OleDbCommand(query, con);
                    reader = command_l5_teacher.ExecuteReader();
                    while (reader.Read())
                    {
                        teachers.Add(reader[0].ToString());
                    }
                }

            }

            return teachers;
        }

        public List<string> GetClassroom(string day)
        {

            List<string> classRooms = new List<string>();
            query = "SELECT 'even' FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
            OleDbCommand command = new OleDbCommand(query, con);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                classRooms.Add(reader.GetString(0));
            }
            reader.Close();
            if (classRooms.Count < 2)
            {

                //Получение t1_num
                classRooms.Clear();
                query = "SELECT l1_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l1_num = new OleDbCommand(query, con);
                reader = command_l1_num.ExecuteReader();
                while (reader.Read())
                {
                    classRooms.Add(reader[0].ToString());
                }

                //Получение l2_num
                query = "SELECT l2_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l2_num = new OleDbCommand(query, con);
                reader = command_l2_num.ExecuteReader();
                while (reader.Read())
                {
                    classRooms.Add(reader[0].ToString());
                }

                //Получение l3_num
                query = "SELECT l3_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l3_num = new OleDbCommand(query, con);
                reader = command_l3_num.ExecuteReader();
                while (reader.Read())
                {
                    classRooms.Add(reader[0].ToString());
                }

                //Получение l4_num
                query = "SELECT l4_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l4_num = new OleDbCommand(query, con);
                reader = command_l4_num.ExecuteReader();
                while (reader.Read())
                {
                    classRooms.Add(reader[0].ToString());
                }

                //Получение l5_num
                query = "SELECT l5_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "'";
                OleDbCommand command_l5_num = new OleDbCommand(query, con);
                reader = command_l5_num.ExecuteReader();
                while (reader.Read())
                {
                    classRooms.Add(reader[0].ToString());
                }



                reader.Close();
            }
            else
            {

                int even = CalculateTheWeek(ChoosedDay);


                if (even == 0)
                {
                    //Получение l1_num
                    classRooms.Clear();
                    query = "SELECT l1_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l1_num = new OleDbCommand(query, con);
                    reader = command_l1_num.ExecuteReader();
                    while (reader.Read())
                    {
                        classRooms.Add(reader[0].ToString());
                    }

                    //Получение l2_num
                    query = "SELECT l2_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l2_num = new OleDbCommand(query, con);
                    reader = command_l2_num.ExecuteReader();
                    while (reader.Read())
                    {
                        classRooms.Add(reader[0].ToString());
                    }

                    //Получение l3_num
                    query = "SELECT l3_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l3_num = new OleDbCommand(query, con);
                    reader = command_l3_num.ExecuteReader();
                    while (reader.Read())
                    {
                        classRooms.Add(reader[0].ToString());
                    }

                    //Получение l4_num
                    query = "SELECT l4_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l4_num = new OleDbCommand(query, con);
                    reader = command_l4_num.ExecuteReader();
                    while (reader.Read())
                    {
                        classRooms.Add(reader[0].ToString());
                    }

                    //Получение l5_num
                    query = "SELECT l5_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l5_num = new OleDbCommand(query, con);
                    reader = command_l5_num.ExecuteReader();
                    while (reader.Read())
                    {
                        classRooms.Add(reader[0].ToString());
                    }
                }
                else
                {
                    //Получение l1_num
                    classRooms.Clear();
                    query = "SELECT l1_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l1_num = new OleDbCommand(query, con);
                    reader = command_l1_num.ExecuteReader();
                    while (reader.Read())
                    {
                        classRooms.Add(reader[0].ToString());
                    }

                    //Получение l2_num
                    query = "SELECT l2_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='2'";
                    OleDbCommand command_l2_num = new OleDbCommand(query, con);
                    reader = command_l2_num.ExecuteReader();
                    while (reader.Read())
                    {
                        classRooms.Add(reader[0].ToString());
                    }

                    //Получение l3_num
                    query = "SELECT l3_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='1'";
                    OleDbCommand command_l3_num = new OleDbCommand(query, con);
                    reader = command_l3_num.ExecuteReader();
                    while (reader.Read())
                    {
                        classRooms.Add(reader[0].ToString());
                    }

                    //Получение l4_num
                    query = "SELECT l4_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='1'";
                    OleDbCommand command_l4_num = new OleDbCommand(query, con);
                    reader = command_l4_num.ExecuteReader();
                    while (reader.Read())
                    {
                        classRooms.Add(reader[0].ToString());
                    }

                    //Получение l5_num
                    query = "SELECT l5_num FROM MainTable WHERE MainTable.group='" + activeGroup + "' AND MainTable.dayoftheweek ='" + day + "' AND MainTable.even='1'";
                    OleDbCommand command_l5_num = new OleDbCommand(query, con);
                    reader = command_l5_num.ExecuteReader();
                    while (reader.Read())
                    {
                        classRooms.Add(reader[0].ToString());
                    }
                }

            }

            return classRooms;
        }

    }
}
