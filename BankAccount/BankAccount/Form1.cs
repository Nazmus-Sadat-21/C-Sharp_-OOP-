namespace BankAccount
{
    public partial class Form1 : Form
    {

        List<Bankaccount> banks = new List<Bankaccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ownertext.Text == "")
            {
                return;
            }
            else
            {
                Bankaccount bank = new Bankaccount(ownertext.Text);
                banks.Add(bank);
                Bankgrid.DataSource = null;
                Bankgrid.DataSource = banks;
                ownertext.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Bankgrid.SelectedRows.Count == 1 && Amount.Value > 0)
            {

                Bankaccount select = Bankgrid.SelectedRows[0].DataBoundItem as Bankaccount;

                string message = select.Depositeamount((double)Amount.Value); ;
                Bankgrid.DataSource = null;
                Bankgrid.DataSource = banks;
                Amount.Value = 0;
                MessageBox.Show(message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Bankgrid.SelectedRows.Count == 1 && Amount.Value > 0)
            {

                Bankaccount select = Bankgrid.SelectedRows[0].DataBoundItem as Bankaccount;

                string message = select.Withdrawamount((double)Amount.Value);
                Bankgrid.DataSource = null;
                Bankgrid.DataSource = banks;
                Amount.Value = 0;
                MessageBox.Show(message);

            }
        }
    }
 }

