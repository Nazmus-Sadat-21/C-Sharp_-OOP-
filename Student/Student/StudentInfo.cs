using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal abstract  class StudentInfo
    {
        protected string name;
        protected int id;
        protected double cgpa;

        public StudentInfo() { }

        public StudentInfo(string name, int id, double cgpa)
        {
            if (cgpa< 2.5)
            {
                Console.WriteLine($"{name} you are a probation student");
            }
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Invalid Name");
                    return;
                }
                this.name = value;
            }
        }

        public double CGPA
        {
            get { return cgpa; }
            set
            {
                if(value < 2.5)
                {
                    Console.WriteLine($"{name} you are a probation student");
                }
                cgpa = value;
            }
        }

        public virtual void showInfo()
        {
            Console.WriteLine($"Name : {name} \nID : {id} \nCGPA : {cgpa}");
        }
    }
}
