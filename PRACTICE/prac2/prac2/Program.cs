using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace prac2
{
    internal class Program
    {

        class Device
        {
            public string Brand;
            public Device(string brand)
            {
                Brand = brand;
                Console.WriteLine($"Device {brand} created");
            }
            public float GetBasePrice()
            {
                return 100.0f;
            }
        }

        class Phone : Device
        {
            public int CameraCount;

            public Phone(string brand) : base(brand)
            {
                CameraCount = 1;
                Console.WriteLine($"Phone {brand} created");
            }

            public float GetPhonePrice()
            {
                return GetBasePrice() + CameraCount * 50;
            }
        }

        class PriceChecker
        {
            public static void ShowPrice(Device d)
            {
                Console.WriteLine($"Device Price: {d.GetBasePrice()}");

            }

            public static void ShowPrice(Phone p)
            {
                Console.WriteLine($"Phone Price:    {p.GetPhonePrice()}");

            }
        }

        static void Main(string[] args)
        {
            Device d1 = new Device("GenericBrand");
            Phone p1 = new Phone("Samsung");


            PriceChecker.ShowPrice(d1);
            PriceChecker.ShowPrice(p1);

        }
    }
}
