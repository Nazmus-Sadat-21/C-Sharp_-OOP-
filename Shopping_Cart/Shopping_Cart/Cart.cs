using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    internal class Cart
    {
        string name;
        string number;
        double balance;
        List<string> items = new List<string>();
        public Cart() { }

        public Cart(string name, string number) { 
          
            this.name = name;
            this.number = number;
            //this.balance = balance; 
            //this.items = new List<string>(items);
             
        }
        
        public void Addproduct(params string[] item)
        {
            for (int i = 0; i < item.Length; i++) {

                if (item[i] =="Shirt") {

                    items.Add(item[i]);

                    this.balance += 200;
                }
                else if(item[i] == "Jeans")
                {
                    items.Add(item[i]);
                    this.balance += 350;
                }
                else if (item[i] == "T-Shirt")
                {
                    items.Add(item[i]);
                    this.balance += 150;
                }
                else if (item[i] == "Glass")
                {
                    items.Add(item[i]);
                    this.balance += 100;
                }
                else if (item[i] == "Phone")
                {
                    items.Add(item[i]);
                    this.balance += 20000;
                }
                else
                {
                    Console.WriteLine($"Invalid item skipped: {item[i]}");
                    continue;
                }
            }
        }

        public void RemoveProduct(params string[] item)
        {
            foreach (string product in item)
            {
                if (items.Contains(product))
                {
                    items.Remove(product);

                   
                    switch (product)
                    {
                        case "Shirt":
                            balance -= 200;
                            break;
                        case "Jeans":
                            balance -= 350;
                            break;
                        case "T-Shirt":
                            balance -= 150;
                            break;
                        case "Glass":
                            balance -= 100;
                            break;
                        case "Phone":
                            balance -= 20000;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Product not found in cart: {product}");
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Phone Number : " + number);
            Console.Write("Your Products : ");
            for (int i = 0; i < items.Count; i++)
            {
                Console.Write(items[i] +" ");
            }
            Console.WriteLine();
            Console.WriteLine("Total Amount : "+balance);
        }

    }
}
