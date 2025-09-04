using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Platform
{
    internal class Hero:Anime
    {



    
        int powerLevel;
        string main_character;
        int no_of_epi;
        public Hero() { }   

        public Hero (string cn, string Cid, string an ,int powerLevel,string main_character,int no_of_epi):base(cn,Cid,an) 
        {
            this.powerLevel = powerLevel;
            this.main_character = main_character;
            this.no_of_epi = no_of_epi;
        }

        public int Power
        {
            get { return powerLevel; }
            set {
               powerLevel = value;   
            }

        }

        public string MainCharacter
        {
            get { return main_character; }
            set { main_character = value; }
        }

        public int NoOfEpi
        {
            get { return no_of_epi; }
            set { no_of_epi = value; }
        }

        public void checkpopularity()
        {
            if (powerLevel < 900 || no_of_epi < 15 || main_character == "No")
            {
                Console.WriteLine("Unpopular Character");
                return;
            }
            else
            {
                Console.WriteLine("Popular Character");
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Power Level       : {powerLevel}");
            Console.WriteLine($"Main Character    : {main_character}");
            Console.WriteLine($"Number of Episode : {no_of_epi}");
            checkpopularity();
        }
    }
}


