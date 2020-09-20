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

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.con.Close();
        }
    }
}
