using System;
using System.Collections;

namespace Assignment1
{
	public class DS169
	{
		public DS169()
		{
			
		}
		public static void SolutionDS169()
		{
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i <= t; i++) {

				var input = Console.ReadLine().Split(' ');
				double v = double.Parse(input[0]);
				double s = double.Parse(input[1]);

				Console.WriteLine("{0:F2}", -(v / s));
			}
		}
	}
}
