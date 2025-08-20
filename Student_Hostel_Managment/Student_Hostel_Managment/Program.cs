using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Hostel_Managment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            Student s1 = new Student("MD NAZMUS SADAT","3454","MALE","03",6);
            Student s2 = new Student("MD JABIR AHMED", "3464", "MALE", "04", 5);
            Student s3 = new Student("MD SAADMAN SAKIB", "3486", "MALE", "06", 6);
            Student s4 = new Student("MD AHMED JOBAYER", "3457", "MALE", "03", 3);

            manager.Add_Student(s1.s_name(), s2.s_name(), s3.s_name(), s4.s_name());

            manager.ShowStudentList();

            Console.WriteLine();

            manager.showStudentInfo(s3);
            s2.pay(16000);
        }
    }
}
