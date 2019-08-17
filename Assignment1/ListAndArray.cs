using System;
using System.Collections.Generic;
using System.Threading;

namespace Assignment1
{
	public class ListAndArray
	{
		public ListAndArray()
		{
		}
		/// Write a program and continuously ask the user to enter different names, until the user presses Enter 
		/// (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
		///
		public static void Excercise1()
		{
			//Take a List<string> to take the name
			var names = new List<string>();
			// write a loop to add the input name untill the input is nullOrWhitepace()
			while (true) {
				var input = Console.ReadLine();
				if (String.IsNullOrWhiteSpace(input)) 
					break;
				names.Add(input);
			}
			// count the list and show how many people like the post
			if (names.Count>2) 
				Console.WriteLine("{0}, {1} and {2} others people liked you",names[0],names[1],names.Count-2);
			else if(names.Count==2)
				Console.WriteLine("{0}, {1} liked you", names[0], names[1]);
			else if(names.Count==1)
				Console.WriteLine("{0}, liked you", names[0]);
			else
				Console.WriteLine();


		}
		/// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
		/// Display the reversed name on the console.
		public static void Excercise2()
		{
			// Ask name
			Console.WriteLine("What is your Name? : ");
			// Read the name string
			var name = Console.ReadLine();
			// take array  to keep the name string
			var array = new char[name.Length];
			// run a loop and replace array[nameChar.Lenth-1]=array[i-1]
			for (var i = name.Length; i > 0; i--) {
				array[name.Length - i] = array[i - 1];

			}
			var reversedName = new string(array);
			Console.WriteLine("Your Reversed Name is :" + reversedName);

		}
		/// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
		/// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
		/// and display the result on the console.
		///
		public static void Excercise3()
		{
			// 1. Take a List to take Five unique numbers
			var numbers = new List<int>();
			
			// 2. write a while loop over the number List with condition a condition of numbers.Count<5
			while (numbers.Count < 5) {
				Console.WriteLine("write a number :");
				var number = Convert.ToInt32(Console.ReadLine());
				// 3. check a  number whether it is previously entered or not, usiing number.Contains(inout)
				if (numbers.Contains(number)) {
					Console.WriteLine("You've previously entered " + number);
					continue;
				}
					
				numbers.Add(number);
					
			}

			// 4. sort the list and display
			numbers.Sort();
			foreach (var n in numbers) {
				Console.WriteLine(n);
			}


		}

		// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
		/// include duplicates. Display the unique numbers that the user has entered.
		public static void Excercise4()
		{
			// 1. Take a List named "numbers" to cointains the random numbers
			var numbers = new List<int>();
			// 2. write a loop to add the number to List, if input "quit" then break
			while (true) {
				Console.WriteLine("Write a number or write Quit to leave:");
				var input=Console.ReadLine();
				if (input.ToLower() == "quit")
					break;
				numbers.Add(Convert.ToInt32(input));
			}
			// 3. Take a List named "uniques" to add unique numbers picked from the numbers list
			var uniques = new List<int>();
			foreach (var number in numbers) {
				if (!uniques.Contains(number))
					uniques.Add(number);
			}
			// 4. display the unique numbers
			Console.WriteLine("Unique Numbers are :");
			foreach (var number in uniques) {
				Console.WriteLine(number);
			}
		}
		/// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
		/// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
		/// the 3 smallest numbers in the list.

		public static void Excercise5()
		{
			// 1. Take String array 
			string[] elements;
			// write a loop to split the comma separated string to input
			while (true) {
				Console.Write("Enter a list of comma-separated numbers: ");
				var input = Console.ReadLine();

				if (!String.IsNullOrWhiteSpace(input)) {
					elements = input.Split(',');
					if (elements.Length >= 5)
						break;
				}

				Console.WriteLine("Invalid List");
			}
			// 3. take a List named number and add the number from elements to Number List
			var numbers = new List<int>();
			foreach (var number in elements)
				numbers.Add(Convert.ToInt32(number));
			// 4. Take a List Named smallests
			var smallests = new List<int>();
			while (smallests.Count < 3) {
				// Assume the first number is the smallest
				var min = numbers[0];
				foreach (var number in numbers) {
					if (number < min)
						min = number;
				}
				smallests.Add(min);

				numbers.Remove(min);
			}

			Console.WriteLine("The 3 smallest numbers are: ");
			foreach (var number in smallests)
				Console.WriteLine(number);
		}
	}
}
