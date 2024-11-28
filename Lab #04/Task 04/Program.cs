


using System;

namespace Arrays
{
    class strings
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine(" 1) Poor  , 2) Normal  , 3)  better , 4) Best  , 5) Excellent  : ");          
            for (int i = 0; i < 40; i++)
            {               
                 string temp =  Convert.ToInt32(Console.ReadLine(arr[i]));            
                arr[temp++];
                

            }

      		foreach(var i in arr ){
		Console.WriteLine(" response 1 : " + arr[i]);	
		Console.WriteLine(" response 2 : " + arr[i]);
		Console.WriteLine(" response 3 : " + arr[i]);
		Console.WriteLine(" response 4 : " + arr[i]);
		Console.WriteLine(" response 5 : " + arr[i]);
		}
        }
    }
}