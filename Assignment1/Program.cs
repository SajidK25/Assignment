using System;
namespace Assignment1
{
	class MainClass
    {
        public static void Main(string[] args)
        {
			var person = new Person(new DateTime(1981, 01, 06));
			//person.BirthDate = new DateTime(1981, 01, 06);
			Console.WriteLine(person.Age);
			/******** getter/setter **********
			var person = new Person();
			person.SetBirthDate(new DateTime(1985,01,06));
			var dob=person.GetBirthDate();
			Console.WriteLine(dob);
			*/
		}
	}
}
