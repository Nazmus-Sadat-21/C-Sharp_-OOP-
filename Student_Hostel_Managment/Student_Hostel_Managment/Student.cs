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
        public int balance ;

        public Student() { }

        public Student(string name, string id, string gen, string room, int rent_month)
        {
            this.student_name = name;
            this.student_id = id;
            this.gender = gen;
            this.room_no = room;
            this.rent_month = rent_month;
            
        }

        public string s_name()
        {
            return this.student_name;
        }

        public void Rent()
        {
            int amount = rent_month * 3000;
            Console.WriteLine($"Total Rental Amount : {amount}");
        }

        public void pay(int p_amount)
        {
            int amount = rent_month * 3000;
            
            if (p_amount <= 0)
            {
                Console.WriteLine($"Unpaid please clear your due amount");
                balance += amount;
            }
            else if (p_amount < amount)
            {
                Console.WriteLine($"Paid : {p_amount} , due amount : {amount - p_amount}");
            }
            else if (p_amount > amount) {

                Console.WriteLine($"Paid : {p_amount} , advance paid amount : {p_amount - amount}");

            }
            else if(p_amount == amount) 
            {
                Console.WriteLine($"Payment clear :)");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Student Name   : {student_name} ");
            Console.WriteLine($"Student ID     : {student_id} ");
            Console.WriteLine($"Student Gender : {gender} ");
            Console.WriteLine($"Student Room No: {room_no} ");
            Console.WriteLine($"Rental Month   : {rent_month} ");
            
            Rent();

            Console.WriteLine($"Due Balace   : {balance} ");


        }

    }
}
