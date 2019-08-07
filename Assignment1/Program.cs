using System;
using Assignment1.Math;
using System.Collections.Generic;
namespace Assignment1
{

	class MainClass
    {
        public static void Main(string[] args)
        {
			// ***************** List *********************
			var numbers = new List<int> { 1, 2, 3, 4, 5 };
			numbers.Add(1);
			numbers.AddRange(new int[3] {6,7,8 });// When see IEnumrable interaface provide a instance of List or Array
			foreach (var number in numbers) {
				Console.WriteLine(number);
			}
			//Indexof
			
			Console.WriteLine("Index of 1 :"+ numbers.IndexOf(1));
			Console.WriteLine("LastIndex of 1 :" + numbers.LastIndexOf(1));

			//Count()
			Console.WriteLine("Count :" + numbers.Count);

			//Remove()
			for (int i = 0; i < numbers.Count; i++) {
				if (numbers[i] == 1) {
					numbers.Remove(numbers[i]);

				}
			}
			
			foreach (var number in numbers) {
				Console.WriteLine(number);
			}
			//Clear()
			numbers.Clear();
			Console.WriteLine("Count :" + numbers.Count);

			/*
			 // ***************** Arrays *********************
			var numbers = new [] { 3, 7, 9, 2, 14, 6 };

			//length
			Console.WriteLine("Length : "+numbers.Length);
			//IndexOf
			var index = Array.IndexOf(numbers, 9);
			Console.WriteLine(index);
			//clear()
			Array.Clear(numbers, 0, 2);
			foreach (var n in numbers) {
				Console.WriteLine(n);
			}

			var booleanArray = new[] { true, false, false, true };
			var strArray = new[] { "sajid", "mollika", "raskin", "rahat", "riad" };

			Array.Clear(booleanArray, 0,2);
			Console.WriteLine("after clear booleanArray");
			foreach (var ba in booleanArray) {
				Console.WriteLine(ba);
			}

			Array.Clear(strArray, 0, 2);
			Console.WriteLine("after clear strArray");
			foreach (var sa in strArray) {
				Console.WriteLine(sa);
			}
			Console.WriteLine("Length of strArray : "+strArray.Length);

			//Copy()
			var anotherNumbers = new int[4];
			Array.Copy(numbers, anotherNumbers, 4);
			Console.WriteLine("effect of Copy():");
			foreach (var an in anotherNumbers) {
				Console.WriteLine(an);
			}
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
			*/

		}
	}
}
