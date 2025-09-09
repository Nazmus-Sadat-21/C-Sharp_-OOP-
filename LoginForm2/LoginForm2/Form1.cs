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
    public partial class Form1 : Form
    {
       

        DataAccess access = new DataAccess();
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
            string pass, user, email;
            user = UserName.Text;
            email = Email.Text;
            pass  = UserPass.Text;

            if (user.Equals("")|| email.Equals("") || pass.Equals(""))
            {
                MessageBox.Show("Fillup yopur full information","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //SqlCommand insert = new SqlCommand(
                //"INSERT INTO UserInfo (UserName, Email, Password) VALUES (@user, @email, @pass)");

                //insert.Parameters.AddWithValue("@user", user);
                //insert.Parameters.AddWithValue("@email", email);
                //insert.Parameters.AddWithValue("@pass", pass);


                //int row = access.executeQuery(insert);

                //if (row == 1)
                //{
                //    MessageBox.Show("SignUp SuccessFul", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    access.closeConn();
                //}
                //else
                //{
                //    MessageBox.Show("Invalid Information Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

                try
                {


                    string conPath = @"Data Source=DESKTOP-3LG6UHL\SQLEXPRESS;Initial Catalog=2ndDB;Integrated Security=True;Encrypt=False";
                    var con = new SqlConnection();
                    con.ConnectionString = conPath;
                    con.Open();

                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = $"INSERT INTO UserInfo  VALUES ('{user}','{email}','{pass}')";
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("SignUp SuccessFul", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            l.Show();
            this.Hide();
        }
    }
}
