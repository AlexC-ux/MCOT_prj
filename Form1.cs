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
            //elEditor.SetGroups(comboBox1, sub.Groups);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

    }
}
