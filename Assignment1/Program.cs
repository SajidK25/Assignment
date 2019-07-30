using System;
using Assignment1.Math;
namespace Assignment1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var sajid = new Person();
            sajid.FirstName = "Sajid";
            sajid.LastName = "khan";
            sajid.Introduce();
            Console.WriteLine();
            //calculator class
            //var cal = new Calculator();
            // *** static implementation ***
            var result = Calculator.add(1, 2);
            Console.WriteLine(result);
            //Array
            Console.WriteLine();
            int[] number = new int[3];
            number[0] = 1;
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
            Console.WriteLine();
            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

        }
    }
}
