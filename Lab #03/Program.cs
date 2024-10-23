
using System;

namespace program
{
	class Factorial
	{
		static	void Main(string[] args)
		{
			Console.WriteLine($" Enter the number : ");
			int num = Convert.ToInt32(Console.ReadLine());

			int total = 1;
			for (int i = num; i > 0; i--)
			{
				total =total * i;
			}
			Console.WriteLine($" The Factorial of " + num + " is " + total);

		}
	}
}