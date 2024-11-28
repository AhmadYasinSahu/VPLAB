
using System;

 namespace Arrays
{
    class Strings
    {
        static void Main(string[] args)
        {
            string[] array = { "hello ", "and ", "welcome ", "to ", "this ", "demo " };

            Merger(array);
        }
     private static void Merger(string[ ] arr)
    {
           // Console.WriteLine($" " + arr[0] + " " + arr[1] + " " + arr[3] + " " + arr[3] + " " + arr[4] + " " + arr[5]);
           string s =string.Concat(arr);
            Console.WriteLine($" "+s);
        }
    }
}