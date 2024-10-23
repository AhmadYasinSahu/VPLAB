
using System;

namespace Numbers

{
  class program
    {
         static void Main(string[] args)
        {
            SquareOfNum();
        }

        static void SquareOfNum()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value after operation of "+i+"  : "+ i * i);
            }
        }
       Console.ReadLine();
    }
}