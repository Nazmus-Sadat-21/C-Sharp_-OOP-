using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Message : Form
    {
        public Message()

        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void mssgbox_Click(object sender, EventArgs e)
        {
           
        }
    }
}
