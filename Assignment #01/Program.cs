
using System;


class program
{
    static void  Main(string[] args)
{
        int[,,] array ={

            { { 1,2,3},{ 4,5,6},{ 7, 8 ,9} },
            { { 1,2,3},{ 4,5,6},{ 7, 8 ,9} },
            { { 1,2,3},{ 4,5,6},{ 7, 8 ,9} }

        } ;

        int sumOfDiagonal = 0;        

        for (int i = 0; i < 3; i++)
        {
            sumOfDiagonal += array[i, i, i];
        }
        Console.WriteLine($" Sum of the diagonal values : {sumOfDiagonal}");
               
}

}