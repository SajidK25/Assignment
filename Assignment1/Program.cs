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

            //calculator class
            //var cal = new Calculator();
            // *** static implementation ***
            var result = Calculator.add(1, 2);
            Console.WriteLine(result);
        }
    }
}
