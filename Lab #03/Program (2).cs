

using System;

namespace Numbers
{
   class program
    {
        static void Main(string[] args)
        {
            TemperatureConverter();
    }

        private static void TemperatureConverter()
        {
            Console.WriteLine(" Enter the Fohrenheit Temperature : ");
            int F = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The Centigrade temperature : " +((double)(F-32)/(double)9 ) );
        }
    }
}