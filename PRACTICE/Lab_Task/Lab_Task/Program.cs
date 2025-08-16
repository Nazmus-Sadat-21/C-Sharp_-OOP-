using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task
{
    internal class Program
    {
        static void Main(string[] args)

        {


            //for(int i =0; i < 4; i++)
            //{
            //    for(int j =0; j <6; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //        {
            //            Console.Write("X"+" ");
            //        }
            //        else
            //        {
            //            Console.Write("O" +" ");
            //        }
            //    }

            //    Console.WriteLine();
            //}




            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //        {
            //            Console.Write(i + j + 1 + " ");
            //        }
            //        else
            //        {
            //            Console.Write(i + j + 1 + " ");
            //        }
            //    }

            //    Console.WriteLine();
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write(i + 1 + " ");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }

            //    }

            //    Console.WriteLine();
            //}


            //int n = 10;
            //for (int i = 1; i <= n; i++)
            //{
            //    int col = 0;
            //    if (i <= 5)
            //    {
            //        col = i;

            //    }
            //    else
            //    {
            //        col = n - i;
            //    }

            //    for (int j = 1; j <= col; j++)
            //    {

            //        Console.Write("*");


            //    }


            //    Console.WriteLine();
            //}


            //int n = Int32.Parse(Console.ReadLine());
            //int sum = 0;
            //Console.WriteLine("Even Numbers : ");
            //for (int i = 0; i<=n; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    } 
            //}


            //int sum_even = 0;
            //int sum_odd = 0;
            //for (int i = 1; i <= 100; i++) {

            //    if (i%2 == 0)
            //    {
            //        sum_even += i;
            //    }
            //    else
            //    {
            //        sum_odd += i;
            //    }

            //}

            //Console.WriteLine($"Sum of even number {sum_even}");
            //Console.WriteLine($"Sum of odd number {sum_odd}");


            //int n = Int32.Parse(Console.ReadLine());
            //int fac = 1;
            //for (int i = 1; i <= n; i++) {

            //      fac *= i;

            //}

            //Console.WriteLine($"The factorial of {n} is {fac}");


            //Console.Write("Enter Physics marks: ");
            //double physics = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Chemistry marks: ");
            //double chemistry = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Biology marks: ");
            //double biology = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Mathematics marks: ");
            //double math = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Computer marks: ");
            //double computer = Convert.ToDouble(Console.ReadLine());

            //// Calculate total and percentage
            //double total = physics + chemistry + biology + math + computer;
            //double percentage = (total / 500)*100;

            //Grade(physics,"Physics");
            //Grade(chemistry, "Chemistry");
            //Grade(biology, "Biology");
            //Grade(math, "Math");
            //Grade(computer, "Computer");

            //Console.WriteLine();

            //Console.WriteLine($"\nPercentage: {percentage}%");

           


        }

        static void Grade(double num, string sub)
        {
            if (num >= 90)
            {
                Console.WriteLine($"{sub} : A+");
            }
            else if (num >= 85 && num < 90)
            {
                Console.WriteLine($"{sub} : A");

            }
            else if (num >= 80 && num < 85)
            {
                Console.WriteLine($"{sub} : B+");
            }
            else if (num >= 75 && num < 80)
            {
                Console.WriteLine($"{sub} : B");
            }

            if (num >= 50 && num < 75)
            {
                Console.WriteLine($"{sub} : C+");
            }
            else if (num < 50)
            {
                Console.WriteLine($"{sub} : F");
            }
        }



    }
}
