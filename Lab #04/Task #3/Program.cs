
using System;
 
namespace Arrays
{
    class strings
    {
        static void Main(string[] args)
        {
            string[] array = { "Ahmad", "Maaz",  "Zain", "Hasnain" };
            Extracter(array);
        }

         static void Extracter(string[] arr)
        {
            Console.WriteLine(" The elements of the array containing 4 or 5 characters : ");
            for (int i = 0; i < 4; i++)
            {
                if (arr[i].Length == 4 || arr[i].Length == 5)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            Console.WriteLine(" The elements of the array containing vowels characters : ");
            for (int i = 0; i < 4; i++)
            {
                if (arr[i] == "a" || arr[i] == "i" || arr[i] == "e" || arr[i] == "o" || arr[i] == "u")
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}