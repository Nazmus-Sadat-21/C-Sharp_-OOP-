using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Product list : ");
            Products p = new Products("Shirt","Jeans","T-Shirt","Glass","Phone");
            p.ShowProduct();
            Console.WriteLine();
            Cart coustomer = new Cart("Nazmus Sadat","01533447029");
            coustomer.Addproduct("Shirt", "Jeans","Glass","Phone");
            coustomer.ShowInfo();
            Console.WriteLine();
            coustomer.RemoveProduct("Jeans","Phone","udf");
            Console.WriteLine();
            coustomer.ShowInfo();
        }
    }
}
