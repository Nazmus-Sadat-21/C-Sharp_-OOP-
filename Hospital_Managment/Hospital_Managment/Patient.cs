using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment
{
    internal class Patient
    {
        string p_name;
        string p_id;
        string problem;
        public Patient() { }
        public Patient(string p_name, string p_id,string p)
        {
            this.p_name = p_name;
            this.p_id = p_id;
            this.problem = p;
        }

       public string name()
        {
            return p_name;
        }

        public void ShowPatientInfo()
        {
            
            Console.WriteLine($"Patient Name : {p_name}");
            Console.WriteLine($"Patient ID : {p_id}");          
            Console.WriteLine($"Patient Problem : {problem}");
           
        }
    }
}
