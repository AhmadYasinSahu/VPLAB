


using System;

namespace Arrays
{
    class strings
    {
        static void Main(string[] args)
        {


            DecimalToBinaryConverter();


        }

        private static void DecimalToBinaryConverter()
        {
            Console.WriteLine("Conversion of Decimal numbers from 1 to 10 into Binary :");

            Console.WriteLine("How many nubmers ou want to convert ");
            int n =Convert.ToInt16(  Console.ReadLine());
            int i;
            int[] array = new int[10];
            for( i = 0; i<n ;i++) {
               array[i] =n%2;
                n=n/2;
            }
            Console.WriteLine("Binary representation :");
            for (i = i - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}