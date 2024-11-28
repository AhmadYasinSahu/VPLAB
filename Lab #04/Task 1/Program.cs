

using System;

namespace Arrays
{
    class Pragram
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2 },{2,3 },{4,5 } };
           Console.WriteLine("The elements  of the 2D array : ");
            Print2DArray(array);
        }

        private static void Print2DArray(int[,] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}