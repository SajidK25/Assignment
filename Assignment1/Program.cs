using System;
using System.CodeDom;
using System.Collections.Generic;

namespace Assignment1
{
	class MainClass
    {
        public static void Main(string[] args)
        {
			var vt = new Votes();
			var post1 = new Post();
			post1.Title = "blog 1";
			post1.Description = "Description of Blog 1";
			post1.CreatedAt=new DateTime(2019, 08, 01);

			var post2 = new Post();
			post2.Title = "blog 2";
			post2.Description = "Description of Blog 2";
			post2.CreatedAt = new DateTime(2019, 08, 03);

			var blogs = new List<Post>();
			blogs.Add(post1);
			blogs.Add(post2);

			foreach (var post in blogs) {
				Console.WriteLine("Title: {0}\ndescription: {1}\nCreatedAt: {2}\n",post.Title,post.Description,post.CreatedAt);
			}

		}
	}
}
