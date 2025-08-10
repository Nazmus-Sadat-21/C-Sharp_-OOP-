using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Availabe Cars : ");
            Car car = new Car("TOYTA","MARCEDES","BMW","SUV","LEXUS","HONDA");
            car.ShowCars();

            Console.WriteLine();

            Coustomer c1 = new Coustomer("Nazmus Sadat", "01533447029", "honda", 2.5);
            c1.ShowVoucher();


            Console.WriteLine();


            Coustomer c2 = new Coustomer("Saadman Sakib", "01533447029", "toyta", 4);
            c2.ShowVoucher();


        }
    }
}