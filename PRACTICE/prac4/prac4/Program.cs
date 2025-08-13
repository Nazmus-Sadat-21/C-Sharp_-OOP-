using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[][] myArray = new int[4][];

            //myArray[0] = new int[] { 1, 3, 5, 7, 9, -2 };
            //myArray[1] = new int[4];
            //myArray[2] = new int[] { 2, 4, 6, 8, 5, 3 };
            //myArray[3] = new int[4];

            //// First display (with specific increments in loops)
            //for (int row = 0; row < 4; row += 2)
            //{
            //    for (int column = 1; column < myArray[row].Length; column += 3)
            //    {
            //        Console.Write("{0} ", myArray[row][column]);
            //    }
            //    Console.WriteLine();
            //}

            //// Fill myArray[1]
            //for (int index = 0; index < myArray[1].Length; index++)
            //{
            //    myArray[1][index] = myArray[0][index + 1] * 2;
            //}

            //// Fill myArray[3]
            //for (int index = 0; index < myArray[3].Length; index++)
            //{
            //    myArray[3][index] = myArray[2][index] + myArray[2][index + 2];
            //}

            //// Display updated rows
            //for (int row = 1; row < 4; row += 2)
            //{
            //    for (int column = 0; column < myArray[row].Length; column++)
            //    {
            //        Console.Write("{0} ", myArray[row][column]);
            //    }
            //    Console.WriteLine();
            //}

            int i, j = 1, k;
            for (i = 0; i < 5; i++)
            {
                k = j++ + ++j;
                Console.Write(k + " ");
              
            }
        }
    }
}

