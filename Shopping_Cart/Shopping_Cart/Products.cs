using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    internal class Products
    {
        List<string> product = new List<string>();
       
        public Products() { }   
        public Products(params string[] items) 
        { 
            this.product = new List<string>(items);
        }

        public void ShowProduct()
        {
            foreach (var item in product)
            {
                Console.WriteLine(item);
            }
        }
    }
}
