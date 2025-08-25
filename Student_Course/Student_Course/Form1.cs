using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Course
{
    public partial class Form1 : Form
    {
        public static string name;
        public static string password;
        public static string id;
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            name = username.Text;
            id = userid.Text;
            password = userpass.Text;

            if(name == ""||id == ""||password == "")
            {
                MessageBox.Show("Please Fillup all information", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Course c = new Course();
                c.Show();
                this.Hide();
            }

           

        }
    }
}
