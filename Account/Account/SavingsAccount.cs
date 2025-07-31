using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class SavingsAccount : BankAccount
    {
        int savingsammount;

        public SavingsAccount() { }

     
        public SavingsAccount(string name, string accnumber, int balance, int savingsammount) : base(name, accnumber, balance)
        {
            
            this.savingsammount = savingsammount;
            
        }

        public int Savings
        {
            get { return savingsammount; }
            set
            {

                if (value < 0 || value != 1000)
                {
                    Console.WriteLine("Invalid Amount");
                    return;
                }
                savingsammount = value;

            }
        }

        public override void Deposite(int amount)
        {
            if(amount<0 || amount != 1000)
            {
                Console.WriteLine("Invalid Amount");
                return;
            }
            base.Deposite(amount);
            savingsammount += amount;
           
        }
        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine($"Savings Amount : {savingsammount}");
        }
       
    }
}
