using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];
            arr[0] = new int[5] { 5, 3, 5, 3, 4 };
            arr[1] = new int[2];
            arr[2] = new int[3];
            arr[3] = new int[4];

            for (int i = 1; i <= arr.Length; i++) { 
            
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j]=i*arr[0][j];
                }
            
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
