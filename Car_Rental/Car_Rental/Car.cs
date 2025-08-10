using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    internal class Car
    {
        string[] cars = new string[] { };

        public Car() { }

        public Car(params string[] cars) { 
            
            this.cars = cars;
        }

        public string[] Cars {
            
            get { return cars; }
            set { cars = value; }
        
        
        }

        public  void ShowCars()
        {
            for (int i = 0; i < cars.Length; i++) { 
                
                Console.WriteLine($"Car {i+1} : {cars[i]}");
            
            }

        }
    }
}
