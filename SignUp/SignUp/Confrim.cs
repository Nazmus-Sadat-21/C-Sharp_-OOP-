using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp
{
    public partial class Confrim : Form
    {
        public Confrim()
        {
            InitializeComponent();
        }

        private void Confrim_Load(object sender, EventArgs e)
        {
            username.Text = Form1.userName;
            email.Text = Form1.userEmail;
            mobile.Text = Form1.userMobile;
            nationality.Text = Form1.userNation;
            pass.Text = Form1.userPass;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
