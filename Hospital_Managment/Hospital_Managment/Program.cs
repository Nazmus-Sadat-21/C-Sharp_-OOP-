using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor d1 = new Doctor("Dr.MD Nazmus Sadat", "243");
            Doctor d2 = new Doctor("Dr.MD Jabir Ahmed", "244");
            Doctor d3 = new Doctor("Dr.MD Fardin Ahmed", "245");
            Admin admin = new Admin();
            admin.Add_doctor(d1.doctorname(), d2.doctorname(), d3.doctorname());
            admin.Show_doctor();

           

            Console.WriteLine();

            Patient p1 = new Patient("Anowar ", "335", "fever kashi");
            Patient p2 = new Patient("Kamal ", "335", "fever kashi");
            Patient p3 = new Patient("Sorif ", "335", "fever kashi");

            admin.Add_Patient(p1.name(), p2.name(), p3.name());
            admin.Show_patient();

            Console.WriteLine();


            Console.WriteLine("Doctor Showing Patient Info : ");
            d1.ShowpatientInfo(p1);






            //Admin admin = new Admin();


            //string[] Dnames = { "Dr.MD Nazmus Sadat", "Dr.MD Jabir Ahmed", "Dr.MD Fardin Ahmed" };
            //string[] Dids = { "243", "244", "245" };

            //Doctor[] doctors = new Doctor[Dnames.Length];
            //for (int i = 0; i < Dnames.Length; i++)
            //{
            //    doctors[i] = new Doctor(Dnames[i], Dids[i]);
            //}


            //foreach (var doc in doctors)
            //{
            //    admin.Add_doctor(doc.doctorname());
            //}






        }
    }
}
