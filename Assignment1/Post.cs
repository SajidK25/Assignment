using System;
using System.Collections.Generic;

namespace Assignment1
{
	public class Post
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime CreatedAt { get; set; }
		public readonly List<Votes> vote = new List<Votes>();
	}
}
