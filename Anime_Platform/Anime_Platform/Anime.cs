using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Platform
{
    internal abstract class Anime
    {
        protected string C_Name;
        protected string C_id;
        protected string A_Name;

        public Anime() { }  

        public Anime(string C_Name, string C_id, string A_Name) { 
        
            this.C_Name = C_Name;
            this.C_id = C_id;
            this.A_Name = A_Name;   
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Character Name : {C_Name}");
            Console.WriteLine($"Character ID   : {C_id}");
            Console.WriteLine($"Anime Name     : {A_Name}");
        }


    }
}
