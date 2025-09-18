using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;








namespace CGPA_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int semes_cr = 0;
            double semes_cg = 0;

            Console.Write("Total Credit Copmpleted : ");
            int total_ccr = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Current CGPA : ");
            double curren_cg =double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Current Semester Course : ");
            int course = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i =0; i<course;i++)
            {
                Console.Write($"{i+1} no course Credit : " );
                int cr = Int32.Parse(Console.ReadLine());
                Console.Write($"{i + 1} no  course Grade : ");
                string grade = Console.ReadLine().ToUpper();
                Console.WriteLine();
                semes_cr += cr;
                if(grade == "A+")
                {
                     semes_cg +=cr * 4.00;
                }
                else if (grade== "A")
                {
                    semes_cg += cr * 3.75;
                }
                else if (grade == "B+")
                {
                    semes_cg += cr * 3.50;
                }
                else if (grade == "B")
                {
                    semes_cg += cr * 3.25;
                }
                else if (grade == "C+")
                {
                    semes_cg += cr * 3.00;
                }
                else if (grade == "C")
                {
                    semes_cg += cr * 2.75;
                }
                else if (grade == "D+")
                {
                    semes_cg += cr * 2.50;
                }
                else if (grade == "D")
                {
                    semes_cg += cr * 2.25;
                }
                else if (grade == "F")
                {
                    semes_cg += cr * 0.00;
                }




            }

            Console.WriteLine();

            double cgpa = semes_cg / semes_cr;
            
            double result = Math.Round(cgpa, 2, MidpointRounding.AwayFromZero);

            double x = result * semes_cr;
            double y = curren_cg*total_ccr;

            int z = total_ccr + semes_cr;

            double overall = (x + y) / z;

            double result2 = Math.Round(overall, 2, MidpointRounding.AwayFromZero);


            Console.WriteLine("Total Credit Completed : " + z);
            Console.WriteLine("Overall CGPA : " + result2);
            Console.WriteLine("Current Semester CGPA : " + result);








        }
    }
}

