namespace SignUp
{
    public partial class Form1 : Form
    {
        public static string userName;
        public static string userEmail;
        public static string userMobile;
        public static string userNation;
        public static string userPass;
        public static string userRePass;

        Confrim confrim = new Confrim();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userName= nbox.Text;
            userEmail= ebox.Text;
            userMobile= mbox.Text;
            userNation= nation.Text;
            userPass = passbox.Text;
            userRePass = retypepassbox.Text;

            if (userName == "" || userEmail == " " || userMobile == " " || userNation == "" || userPass == " " || userRePass == " ") {

                MessageBox.Show("Please FillUp your all information !");
            
            }
            else if (userPass != userRePass)
            {
                MessageBox.Show("Please check and retype your password again");
                retypepassbox.Text = " ";
            }
            else
            {
                this.Hide();
                confrim.Show();
                
            }
            
        }
    }
}
