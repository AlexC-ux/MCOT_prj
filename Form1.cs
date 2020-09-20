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
        List<string> subjects_mon = new List<string>();
        List<string> teachers_mon = new List<string>();
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

            foreach (string s in db.GetSubj("Понедельник"))
            {
                subjects_mon.Add(s);
            }
            foreach (string s in db.GetTeacher("Понедельник"))
            {
                teachers_mon.Add(s);
            }
            
        }

        private void SetLabels()
        {
            //Понедельник
            label1.Text = subjects_mon[0];
            label2.Text = subjects_mon[1];
            label3.Text = subjects_mon[2];
            label4.Text = subjects_mon[3];
            label5.Text = subjects_mon[4];

            label6.Text = teachers_mon[0];
            label7.Text = teachers_mon[1];
            label8.Text = teachers_mon[2];
            label9.Text = teachers_mon[3];
            label10.Text = teachers_mon[4];
            //-----------------------//

        }




    }
}
