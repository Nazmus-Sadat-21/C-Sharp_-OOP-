using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Hostel_Managment
{
    internal class Student
    {
        string student_name;
        string student_id;
        string gender;
        string room_no;
        int rent_month;
        int balance;
        int totalRentAmount;
        public Student() { }

        public Student(string name, string id, string gen, string room, int rent_month)
        {
            this.student_name = name;
            this.student_id = id;
            this.gender = gen;
            this.room_no = room;
            this.rent_month = rent_month;
            this.totalRentAmount = rent_month * 3000;
            this.balance = totalRentAmount; 


        }

        public string s_name()
        {
            return this.student_name;
        }

        public int GetTotalRent()
        {
            return totalRentAmount;
        }

        public int GetBalance()
        {
            return balance;
        }

        public void pay(int p_amount)
        {
            if (p_amount <= 0)
            {
                Console.WriteLine("Invalid payment amount! Amount must be greater than 0.");
                return;
            }

            if (balance <= 0)
            {
                Console.WriteLine("No due amount remaining. Payment refunded.");
                return;
            }

            if (p_amount > balance)
            {
                Console.WriteLine($"Payment of {p_amount} exceeds due amount of {balance}. Only {balance} will be accepted.");
                p_amount = balance; 
            }

            balance -= p_amount;

            if (balance == 0)
            {
                Console.WriteLine("Payment complete! All dues cleared.");
            }
            else
            {
                Console.WriteLine($"Paid {p_amount}. Remaining due: {balance}");
            }

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Student Name   : {student_name} ");
            Console.WriteLine($"Student ID     : {student_id} ");
            Console.WriteLine($"Student Gender : {gender} ");
            Console.WriteLine($"Student Room No: {room_no} ");
            Console.WriteLine($"Rental Month   : {rent_month} ");
            Console.WriteLine($"Total Rental Amount : {totalRentAmount}");
            Console.WriteLine($"Paid Amount     : {totalRentAmount - balance}");
            Console.WriteLine($"Due Balance     : {balance} ");
        }

    }
}

