using System;
using Assignment1.Math;
namespace Assignment1
{

	class MainClass
    {
        public static void Main(string[] args)
        {
			try {
				var point = new Point(10, 20);
				//point.Move(new Point(40, 60));
				point.Move(null);
				Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

				point.Move(400, 500);
				Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
			} catch (Exception ex) {
				Console.WriteLine("An Unxpected error occured");
			}

			

			var customer = new Customer();
			customer.Id = 1;
			customer.Name = "john";

			var order = new Order();
			customer.Orders.Add(order);
			Console.WriteLine(customer.Id);
			Console.WriteLine(customer.Name );
			// Object Initializer syntex
			var anotherCustmer = new Customer() {
				Id = 2,
				Name = "Sajid"

			};
			var name = anotherCustmer.Name;
			Console.WriteLine(name);

        }
    }
}
