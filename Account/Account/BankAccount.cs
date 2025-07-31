using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class BankAccount
    {
        protected string name;
        protected string accNumber;
        protected int balance;

        public BankAccount() { }

        public BankAccount(string name, string accNumber, int balance)
        {
            if(name == " " || accNumber.Length != 8 || balance < 0)
            {
                Console.WriteLine("Invalid Information");
                return;
            }
            this.name = name;
            this.accNumber = accNumber;
            this.balance = balance;  
            
        }
        public string Name
        {
            get { return name; }
            set { 
                if(string.IsNullOrWhiteSpace(value)) {
                    Console.WriteLine("Invalid Name");
                    return;
                }
                this.name = value;

            }
        }

        public string AccNumber
        {
            get { return accNumber; }
            set
            {
                if(value.Length != 8)
                {
                    Console.WriteLine("Invalid Account Number");
                    return;
                }
                this.accNumber = value;
            }
        }

        public int Balance
        {
            get{ return balance; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Invalid Amountt");
                    return;
                   
                }
                this.balance = value;
            }
        }

        public virtual void Deposite (int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Invalid Amount");
                return;
            }
            balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (amount > balance || amount ==0)
            {
                Console.WriteLine("Ivvalid Amount");
                return;
            }
            balance -= amount;
        }

        public void Transfer(int amount,string accnumber,BankAccount reciver)
        {
            if (reciver.accNumber != accnumber)
            {
                Console.WriteLine("Invalid Account");
                return;
            }
            else if (amount > balance) {

                Console.WriteLine("Insufficient amount");
                return;
            }
            balance -= amount;
            reciver.Balance += amount;
        }

        public virtual void showInfo()
        {
            Console.WriteLine("Name : " +name);
            Console.WriteLine("Account Number : " + accNumber);
            Console.WriteLine("Balance : " + balance);
        }

    }
}
