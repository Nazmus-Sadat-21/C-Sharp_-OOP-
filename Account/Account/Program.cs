using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            BankAccount acc1 = new BankAccount("Nazmus Sadat " , "12345678" , 500);
            BankAccount acc2 = new BankAccount("Jabir Aahmed ", "87654321", 2000);
            SavingsAccount sacc = new SavingsAccount("Nazmus Sadat ", "12345678", 500,0);



            
            //acc1.showInfo();
            //acc1.Deposite(2000);
            //acc1.showInfo();
            //acc1.Withdraw(1000);
            //acc1.showInfo();
            //acc2.showInfo();

            //acc1.Transfer(1000, "87654321",acc2);
            //acc1.showInfo();
            //acc2.showInfo();
                       
            sacc.showInfo();
            sacc.Deposite(1000);
            sacc.showInfo();


        }
    }
}

