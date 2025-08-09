using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][]
        {
            new int[]{10,5,7},
            new[]{5,6},
            new[]{6,7,8}
        };

            int rowIndex = 0;
            foreach (int[] row in arr)
            {
                Console.WriteLine("Row:" + rowIndex);
                foreach (int col in row)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
                rowIndex++;
            }
            int multi;
            PrintArr(out multi, arr[0]);
            Console.WriteLine(multi);
        }
        static void PrintArr(out int multi, params int[] row)
        {
            multi = 1;
            for (int i = row.Length - 1; i >= 0; i--)
            {
                Console.Write(row[i] + " ");
                multi = multi * row[i];
            }
        }

    }

}

