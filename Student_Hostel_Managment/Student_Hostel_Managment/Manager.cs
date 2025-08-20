using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Hostel_Managment
{
    internal class Manager
    {
        string manager_name;
        string manager_id;
        List<string> student_list = new List<string>(); 

        public Manager() { }

        public Manager(string manager_name, string manager_id)
        {
            this.manager_name = manager_name;
            this.manager_id = manager_id;
        }

        public void Add_Student(params string[] student)
        {
                     
            for (int i = 0; i < student.Length; i++)
            {
                student_list.Add(student[i]);

            }
        }

        public void Remove_Student(params string[] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                if (student_list.Contains(student[i]))
                {
                    student_list.Remove(student[i]);
                }

            }
        }

        public void ShowStudentList()
        {
            Console.WriteLine("Student List : ");
            foreach (string student in student_list)
            {
                Console.WriteLine(student);

            }
        }

        public void showStudentInfo(Student student)
        {
            student.ShowInfo();
           
        }

    }
}
