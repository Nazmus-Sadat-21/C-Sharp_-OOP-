using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment
{
    internal class Doctor
    {
        string D_name;
        string D_id;
        public Doctor() { }
        public Doctor (string name,string id)
        {
            D_name = name;
            D_id = id;
        }

        public string doctorname()
        {
            
            return D_name;
            
               
        }
        public string doctorID()
        { 
            return D_id;


        }

        public void showDoctorInfo()
        {
            Console.WriteLine($"Doctor Name : {D_name}");
            Console.WriteLine($"Doctor ID   : {D_id}");
        }
        public  void ShowpatientInfo(Patient p)
        {
            p.ShowPatientInfo();
            
        }

    }
}
