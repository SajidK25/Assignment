using System;
using System.CodeDom;

namespace Assignment1
{

	class MainClass
    {
        public static void Main(string[] args)
        {
			var cookies = new HttpCookies();
			cookies["name"] = "sajid";
			Console.WriteLine(cookies["name"]);
		}
	}
}
