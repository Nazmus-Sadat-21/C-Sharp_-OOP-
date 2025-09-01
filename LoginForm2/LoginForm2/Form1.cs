using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm2
{
    public partial class Form1 : Form
    {
        private string pass,user;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

      
        private void label5_MouseHover(object sender, EventArgs e)
        {
           UserPass.UseSystemPasswordChar = false;
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            UserPass.UseSystemPasswordChar = true;
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (UserName.Text != "Admin" || UserPass.Text != "12345")
            {
                MessageBox.Show("Invakid User Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserName.Text = "";
                UserPass.Text = "";
            }
            else
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
        }

        
    }
}
