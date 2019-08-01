using System;
using Assignment1.Math;
namespace Assignment1
{

	class MainClass
    {
        public static void Main(string[] args)
        {

			var customer = new Customer();
			customer.Id = 1;
			customer.Name = "john";

			var order = new Order();
			customer.Orders.Add(order);
			Console.WriteLine(customer.Id);
			Console.WriteLine(customer.Name );

        }
    }
}
