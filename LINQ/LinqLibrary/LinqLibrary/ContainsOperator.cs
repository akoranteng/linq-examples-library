using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class ContainsOperator : ILinqOperator
	{
		public void RunDemo()
		{
			string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Metallica", "Cream", "Oasis"
								 , "Abba", "Blur", "Chic", "Eurythmics", "Genesis", "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers"
								 , "Noir Desir", "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Tears for Fears"
			                     , "Deep Purple", "KISS"};
			bool contains = bands.Contains("Queen");
			Console.WriteLine(contains);

			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			Singer s = new Singer() { Id = 2, FirstName = "Elvis", LastName = "Presley", BirthYear = 1954 };
			bool containsSinger = singers.Contains(s, new DefaultSingerComparer());
			Console.WriteLine(containsSinger);
		}
	}
}
