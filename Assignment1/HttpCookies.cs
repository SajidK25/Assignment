using System.Collections.Generic;

namespace Assignment1
{
	public class HttpCookies
	{
		private readonly Dictionary<string, string> _dictionary;

		public HttpCookies()
		{
			_dictionary = new Dictionary<string, string>();
		}

		public string this[string key] {
			get { return _dictionary[key]; }
			set { _dictionary[key] = value; }
		}
	}
}
