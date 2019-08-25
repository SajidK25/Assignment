using System;
namespace Assignment1
{
	public class Person
	{
		//******** Property get/set **********
		//Auto implementation of private property
		public DateTime BirthDate { get; private set; }
		public Person(DateTime birthDate)
		{
			BirthDate = birthDate;
		}
		public int Age {
			get {
				var timeSpan = DateTime.Today - BirthDate;
				var year = timeSpan.Days / 365;
				return year;
			}
		}
		/*
		private DateTime _birthDate;
		public DateTime BirthDate {
			get { return _birthDate; }
			set { _birthDate = value; }
		}
		*/

		/******** getter/setter **********

		private DateTime BirthDate;

		public void SetBirthDate(DateTime birthDate)
		{
			BirthDate = birthDate;
		}
		public DateTime GetBirthDate()
		{
			return BirthDate;
		}
		*/

	}
}
