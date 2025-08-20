using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hospital_Managment
{
    internal class Admin
    {
        string A_name;
        string A_id;
        List<string> doctor_list = new List<string>();
        List<string> Patient_list = new List<string>();

        public Admin() { }
        public Admin(string A_name, string A_id)
        {
            this.A_name = A_name;
            this.A_id = A_id;
        }

        public void Add_doctor(params string[] doctors)

        {
           for (int i = 0; i < doctors.Length; i++)
            {
                doctor_list.Add(doctors[i]);
            }
        }

        public void Remove_doctor(params string[] doctors)

        {
            for (int i = 0; i < doctors.Length; i++)
            {
                if (doctors[i] == doctor_list[i])
                {
                    doctor_list.Remove(doctors[i]);
                }
            }
        }

        public  void Show_doctor()
        {
            Console.WriteLine("Doctors List : ");
            foreach (string doctor in doctor_list)
            {

                Console.WriteLine(doctor);
            }
            
        }
       

        public void Add_Patient(params string[] patients)

        {
            for (int i = 0; i < patients.Length; i++)
            {
                Patient_list.Add(patients[i]);
            }
        }

        public void Remove_Patient(params string[] patients)

        {
            for (int i = 0; i < patients.Length; i++)
            {
                if (patients[i] == Patient_list[i])
                {
                    doctor_list.Remove(patients[i]);
                }
               
            }
        }
        public void Show_patient()
        {
            Console.WriteLine("Patients List : ");
            foreach (string patient in Patient_list)
            {

                Console.WriteLine(patient);
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Admin Name  : {A_name}");
            Console.WriteLine($"Admin Name  : {A_id}");
        }

    }
}
