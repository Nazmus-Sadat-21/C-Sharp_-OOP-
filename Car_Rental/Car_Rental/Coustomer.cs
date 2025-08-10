using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    internal class Coustomer 
    {
        string name;
        string number;
        string rentCar;
        double time;

        public Coustomer(string n,string no, string rent, double t)
        {
            if (n==" "|| no.Length != 11|| t <=0)
            {
                Console.WriteLine("Invalid Information");
                return;
            }
            this.name = n;
            this.number = no;   
            this.rentCar = rent.ToUpper();
            this.time = t;
        }

        public void Rental_Cal()
        {
            switch (rentCar) {

                case "MARCEDES":
                    Console.WriteLine($"Your total rental amount : {1000 * time} TK");
                    break;
                case "BMW":
                    Console.WriteLine($"Your total rental amount : {1200 * time} TK");
                    break;
                case "SUV":
                    Console.WriteLine($"Your total rental amount : {800 * time} TK");
                    break;
                case "TOYTA":
                    Console.WriteLine($"Your total rental amount : {750 * time} TK");
                    break;
                case "HONDA":
                    Console.WriteLine($"Your total rental amount : {650 * time} TK");
                    break;
                case "LEXUS":
                    Console.WriteLine($"Your total rental amount : {900 * time} TK");
                    break;
            }

        }

        public void ShowVoucher()
        {
            
            Console.WriteLine($"Name        : {name}");
            Console.WriteLine($"Mobile no   : {number}");
            Console.WriteLine($"Rental Car  : {rentCar} ");
            Console.WriteLine($"DurationTime: {time} hr");
            Rental_Cal();
        }

    }
}
