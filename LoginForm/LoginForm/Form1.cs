namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;

            if (name != "Nazmus Sadat" || pass != "12345")
            {
                MessageBox.Show("Invalid Information");

            }
            else
            {
                this.Hide();
                Message mssg = new Message();
                mssg.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
    }
}
