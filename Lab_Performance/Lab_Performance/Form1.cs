using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Performance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button) sender;

            btn.BackColor = Color.MidnightBlue;
            btn.ForeColor = Color.White;
        }
        private void MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            textbox.Text += btn.Text;

            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textbox.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
           if(textbox.Text == "")
            {
                MessageBox.Show("Please enter some number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                textbox.Text = textbox.Text.Substring(0, textbox.Text.Length - 1);
            }

        }

       
    }
}
