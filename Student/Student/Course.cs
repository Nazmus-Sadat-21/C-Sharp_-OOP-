using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Course:StudentInfo
    {
        string[] course = new string[] {};

        public Course() { }

        public Course(string n, int id, double cgpa, params string[] course) : base(n, id, cgpa)
        {
            this.course = course;
        }

        public string[] Courses
        {
            get { return course;}
            set { course = value; }
        }

        public void AddCourse(string c)
        {
                  
           
            string[] newCourseArray = new string[course.Length + 1];

            
            for (int i = 0; i < course.Length; i++)
            {
                newCourseArray[i] = course[i];
            }

            
            newCourseArray[course.Length] = c;

            
            course = newCourseArray;
        

        }

        public void RemoveCourse(string r)
        {
            for (int i = 0; i < course.Length; i++) {

                if (course[i] == r)
                    //break;
                    course[i] = "Droped";


            }

        }
        public override void showInfo()
        {
            base.showInfo();
            for (int i = 0; i < course.Length; i++)
            {

                Console.WriteLine($"Course {i+1} : {course[i]}");

            }
        }
    }
}
