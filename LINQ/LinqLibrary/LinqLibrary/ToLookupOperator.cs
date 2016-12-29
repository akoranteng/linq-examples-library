using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class ToLookupOperator : ILinqOperator
	{
		public void RunDemo()
		{
			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			ILookup<int, Singer> singersByBirthYear = singers.ToLookup(s => s.BirthYear);
			IEnumerable<Singer> filtered = singersByBirthYear[1964];
			foreach (Singer s in filtered)
			{
				Console.WriteLine(s.LastName);
			}

			ILookup<int, string> singerNamesByBirthYear = singers.ToLookup(s => s.BirthYear, si => string.Concat(si.LastName, ", ", si.FirstName));
			IEnumerable<string> filtered2 = singerNamesByBirthYear[1964];
			foreach (string s in filtered2)
			{
				Console.WriteLine(s);
			}
		}
	}
}
