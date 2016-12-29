using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary.Collections
{
	public class ConsonantNumberComparer : IComparer<string>
	{
		public int Compare(string x, string y)
		{
			int consonantCountStringOne = GetConsonantCount(x);
			int consonantCountStringTwo = GetConsonantCount(y);

			if (consonantCountStringOne < consonantCountStringTwo) return -1;
			if (consonantCountStringOne > consonantCountStringTwo) return 1;
			return 0;
		}

		private int GetConsonantCount(string input)
		{
			char[] consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h','k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'z', 'x', 'y' };
			int count = 0;
			foreach (char c in input.ToLower())
			{
				if (consonants.Contains(c))
				{
					count++;
				}
			}

			return count;
		}
	}
}
