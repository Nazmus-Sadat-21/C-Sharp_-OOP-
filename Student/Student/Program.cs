using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Course stu1 = new Course("Nazmus Sadat", 53534, 3.57, "JAVA", "TOC", "DLC", "DLC LAB");
            Course stu2 = new Course("Jabir Ahmed", 53549, 3.33, "OOP2", "TOC", "MATH 6");
            stu1.showInfo();
            Console.WriteLine();
            stu2.showInfo();
            stu1.AddCourse("OOP2");
            stu1.AddCourse("MATH 6");
            stu1.showInfo();
            Console.WriteLine();
            stu2.AddCourse("DLC");
            stu2.RemoveCourse("TOC");
            stu2.showInfo();
            Console.WriteLine();
            stu1.RemoveCourse("TOC");
            stu1.showInfo();
            //stu1.RemoveCourse("DLC");
            //stu1.showInfo();
        }
    }
}
