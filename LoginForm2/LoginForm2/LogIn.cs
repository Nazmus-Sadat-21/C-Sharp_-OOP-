using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LoginForm2
{
    public partial class LogIn : Form
    {

        DataAccess access = new DataAccess();
        DataTable dt = new DataTable();
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, pass;
            name = Loginname.Text;
            pass = Loginpass.Text;

            if (name.Equals("")||pass.Equals(""))
            {
                MessageBox.Show("Fillup yopur full information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "Select * from UserInfo where UserName = '"+name+"' and Password ='"+pass+"' ";

                access.readDatathroughAdapter(query,dt);

                if (dt.Rows.Count==1)
                {
                    MessageBox.Show("LogIn SuccessFul", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Information Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }




        }
    }
}
