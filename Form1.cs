using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCOT_prj
{
    public partial class Form1 : Form
    {
        DataBase db = new DataBase();

        List<string> subjects_mon = new List<string>();//списки пн
        List<string> teachers_mon = new List<string>();
        List<string> num_mon = new List<string>();


        List<string> subjects_tue = new List<string>();//списки вт
        List<string> teachers_tue = new List<string>();
        List<string> num_tue = new List<string>();


        List<string> subjects_wed = new List<string>();//списки ср
        List<string> teachers_wed = new List<string>();
        List<string> num_wed = new List<string>();


        List<string> subjects_thu = new List<string>();//списки чт
        List<string> teachers_thu = new List<string>();
        List<string> num_thu = new List<string>();


        List<string> subjects_fri = new List<string>();//списки пт
        List<string> teachers_fri = new List<string>();
        List<string> num_fri = new List<string>();


        List<string> subjects_sun = new List<string>();//списки сб
        List<string> teachers_sun = new List<string>();
        List<string> num_sun = new List<string>();

        public string choosedGroup;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.con.Open();
            db.findGroups();
            SetGroups();

            groupBox1.Hide();
            groupBox4.Hide();
            groupBox7.Hide();
            groupBox10.Hide();
            groupBox13.Hide();
            groupBox16.Hide();



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.con.Close();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosedGroup = comboBox1.SelectedItem.ToString();
            db.activeGroup = choosedGroup;
            SetObjects();

            groupBox1.Show();
            groupBox4.Show();
            groupBox7.Show();
            groupBox10.Show();
            groupBox13.Show();
            groupBox16.Show();

            SetLabels();


        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void SetGroups()
        {
            foreach (string s in db.groups)
            {
                comboBox1.Items.Add(s);
            }
        }

        private void SetObjects()
        {
            //Заполнение списков на пн
            foreach (string s in db.GetSubj("Понедельник"))
            {
                subjects_mon.Add(s);
            }
            foreach (string s in db.GetTeacher("Понедельник"))
            {
                teachers_mon.Add(s);
            }
            foreach (string s in db.GetClassroom("Понедельник"))
            {
                num_mon.Add(s);
            }

            //Заполнение списков на вт
            foreach (string s in db.GetSubj("Вторник"))
            {
                subjects_tue.Add(s);
            }
            foreach (string s in db.GetTeacher("Вторник"))
            {
                teachers_tue.Add(s);
            }
            foreach (string s in db.GetClassroom("Вторник"))
            {
                num_tue.Add(s);
            }

            //заполнение списков на ср
            foreach (string s in db.GetSubj("Среда"))
            {
                subjects_wed.Add(s);
            }
            foreach (string s in db.GetTeacher("Среда"))
            {
                teachers_wed.Add(s);
            }
            foreach (string s in db.GetClassroom("Среда"))
            {
                num_wed.Add(s);
            }

            //заполнение списков на чт
            foreach (string s in db.GetSubj("Четверг"))
            {
                subjects_thu.Add(s);
            }
            foreach (string s in db.GetTeacher("Четверг"))
            {
                teachers_thu.Add(s);
            }
            foreach (string s in db.GetClassroom("Четверг"))
            {
                num_thu.Add(s);
            }

            //заполнение списков на пт
            foreach (string s in db.GetSubj("Пятница"))
            {
                subjects_fri.Add(s);
            }
            foreach (string s in db.GetTeacher("Пятница"))
            {
                teachers_fri.Add(s);
            }
            foreach (string s in db.GetClassroom("Пятница"))
            {
                num_fri.Add(s);
            }

            //заполнение списков на сб
            foreach (string s in db.GetSubj("Суббота"))
            {
                subjects_sun.Add(s);
            }
            foreach (string s in db.GetTeacher("Суббота"))
            {
                teachers_sun.Add(s);
            }
            foreach (string s in db.GetClassroom("Суббота"))
            {
                num_sun.Add(s);
            }

        }

        private void SetLabels()
        {
            //Понедельник
            label1.Text = subjects_mon[0]; //предметы 
            label2.Text = subjects_mon[1];
            label3.Text = subjects_mon[2];
            label4.Text = subjects_mon[3];
            label5.Text = subjects_mon[4];

            label6.Text = teachers_mon[0];//учителя
            label7.Text = teachers_mon[1];
            label8.Text = teachers_mon[2];
            label9.Text = teachers_mon[3];
            label10.Text = teachers_mon[4];

            label11.Text = num_mon[0];//кабинеты
            label12.Text = num_mon[1];
            label13.Text = num_mon[2];
            label14.Text = num_mon[3];
            label15.Text = num_mon[4];


            //-----------------------//

            //Вторник
            label30.Text = subjects_tue[0]; //предметы 
            label43.Text = subjects_tue[1];
            label42.Text = subjects_tue[2];
            label41.Text = subjects_tue[3];
            label40.Text = subjects_tue[4];

            label25.Text = teachers_tue[0];//учителя
            label29.Text = teachers_tue[1];
            label28.Text = teachers_tue[2];
            label27.Text = teachers_tue[3];
            label26.Text = teachers_tue[4];

            label44.Text = num_tue[0];//Кабинеты
            label45.Text = num_tue[1];
            label46.Text = num_tue[2];
            label47.Text = num_tue[3];
            label48.Text = num_tue[4];

            //-----------------------//

            //Среда
            label63.Text = subjects_wed[0]; //предметы 
            label67.Text = subjects_wed[1];
            label66.Text = subjects_wed[2];
            label65.Text = subjects_wed[3];
            label64.Text = subjects_wed[4];

            label58.Text = teachers_wed[0];//учителя
            label62.Text = teachers_wed[1];
            label61.Text = teachers_wed[2];
            label60.Text = teachers_wed[3];
            label59.Text = teachers_wed[4];

            label68.Text = num_wed[0];//Кабинеты
            label69.Text = num_wed[1];
            label70.Text = num_wed[2];
            label71.Text = num_wed[3];
            label72.Text = num_wed[4];

            //-----------------------//

            //Четверг
            label87.Text = subjects_thu[0]; //предметы 
            label91.Text = subjects_thu[1];
            label90.Text = subjects_thu[2];
            label89.Text = subjects_thu[3];
            label88.Text = subjects_thu[4];

            label82.Text = teachers_thu[0];//учителя
            label86.Text = teachers_thu[1];
            label85.Text = teachers_thu[2];
            label84.Text = teachers_thu[3];
            label83.Text = teachers_thu[4];

            label92.Text = num_thu[0];//Кабинеты
            label93.Text = num_thu[1];
            label94.Text = num_thu[2];
            label95.Text = num_thu[3];
            label96.Text = num_thu[4];

            //-----------------------//

            //Пятница
            label111.Text = subjects_fri[0]; //предметы 
            label115.Text = subjects_fri[1];
            label114.Text = subjects_fri[2];
            label113.Text = subjects_fri[3];
            label112.Text = subjects_fri[4];

            label106.Text = teachers_fri[0];//учителя
            label110.Text = teachers_fri[1];
            label109.Text = teachers_fri[2];
            label108.Text = teachers_fri[3];
            label107.Text = teachers_fri[4];

            label116.Text = num_fri[0];//Кабинеты
            label117.Text = num_fri[1];
            label118.Text = num_fri[2];
            label119.Text = num_fri[3];
            label120.Text = num_fri[4];



            //Суббота
            label135.Text = subjects_sun[0]; //предметы 
            label139.Text = subjects_sun[1];
            label138.Text = subjects_sun[2];
            label137.Text = subjects_sun[3];
            label136.Text = subjects_sun[4];

            label130.Text = teachers_sun[0];//учителя
            label134.Text = teachers_sun[1];
            label133.Text = teachers_sun[2];
            label132.Text = teachers_sun[3];
            label131.Text = teachers_sun[4];

            label140.Text = num_sun[0];//Кабинеты
            label141.Text = num_sun[1];
            label142.Text = num_sun[2];
            label143.Text = num_sun[3];
            label144.Text = num_sun[4];

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
