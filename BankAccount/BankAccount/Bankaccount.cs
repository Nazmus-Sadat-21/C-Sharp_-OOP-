using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Bankaccount
    {

        public string OwnerName { get; set; }

        public Guid Accountnumber { get; set; }

        public double Balance { get; private set; }

        public Bankaccount( string owner) {
            
            OwnerName = owner;
            Accountnumber = Guid.NewGuid();
            Balance = 0;
            
        
        }

        public string Depositeamount(double amount)
        {
            if (amount <=0)
            {
                return "You can not deposite " +amount;
            }
            else
            {
                Balance += amount;
                return "Deposite " + amount;
            }
        }

        public string Withdrawamount(double amount)
        {

             if (amount <= 0)
            {
                return "You can not withdraw " + amount;
            }
            else if (amount > Balance)
            {
                return "You can not withdraw "+amount;
            }
            else
            {
                Balance -= amount;
                return "Withdraw " + amount;
            }
        }



    }
}
