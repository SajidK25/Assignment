using System.Windows.Markup;

namespace Assignment1
{
	public class Votes
	{
		private int _vote;

		public int Vote {
			get { return Vote; }
			private set { _vote = value; }
		}

		public int upVote()
		{
			return _vote += 1;
		}
		public int downVote()
		{
			return _vote -= 1;
		}
	}
}
