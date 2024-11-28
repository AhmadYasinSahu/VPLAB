

using System;

namespace Numbers;

class Arrays
{

    static void Main(string[] args)
    {
        // SingleDimensionArray();
        //  MUltiDimemsionArray();
        JaggedArray();
    }

    private static void JaggedArray()
    {
        int[][] array = new int[1][];
        array[0] = new int[] {1,2};
        array[1] = new int[] {3,4};

        Console.WriteLine($"Jagged Array : ");
        for (int i =0; i< array.Length;i++)
        {
            for (int j = 0; j < array[i].Length; ) 
            {
                Console.WriteLine(" "+array[i][j] ,j < array[i].Length - 1 ? " " : " ");

            }
        }
    }

    private static void MUltiDimemsionArray()
    {
        int[,] array = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9,10} };
        Console.WriteLine($"Multi Dimension Array : ");

        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }

    private static void SingleDimensionArray()
    {
        int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"Single Dimension Array : ");
        foreach (int i in Numbers)
        {
            Console.WriteLine(i);
        }
    }
}