using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class MinOperator : ILinqOperator
	{
		public void RunDemo()
		{
			List<int> integers = new List<int>() { 54, 23, 76, 123, 93, 7, 3489 };
			int intMin = integers.Min();

			string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Metallica", "Cream", "Oasis", "Abba", "Blur"
							 , "Chic", "Eurythmics", "Genesis", "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers"
							 , "Noir Desir", "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Tears for Fears"
							 , "Deep Purple", "KISS"};
			string stringMin = bands.Min();

			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			int minSingerBirthYear = singers.Min(s => s.BirthYear);

			String minSingerName = singers.Min(s => s.FirstName);

			

		}
	}
}
