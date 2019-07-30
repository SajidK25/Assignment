using System;

namespace Assignment1
{
    public class Person
    {
        private  string firstName;
        private string lastName;
        public string FirstName {
            get
            {
                return firstName.ToUpper();
            }
            set
            {
                firstName = value;
            }
            
        }
        public string LastName
        {
            get
            {
                return lastName.ToUpper();
            }
            set
            {
                lastName=value;
            }
        }



        public void Introduce()
        {
            Console.WriteLine("Hello! My name is " + FirstName + " " + LastName);
        }
    }
}