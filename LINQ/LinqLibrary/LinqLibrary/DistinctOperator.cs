using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class DistinctOperator : ILinqOperator
	{
		public void RunDemo()
		{
			string[] bands = DemoCollections.GetBands();
			IEnumerable<string> bandsDuplicated = bands.Concat(bands);
			IEnumerable<string> uniqueBands = bandsDuplicated.Distinct();
			foreach (String unique in uniqueBands)
			{
				Console.WriteLine(unique);
			}

			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			IEnumerable<Singer> singersDuplicates = singers.Concat(singers);
			IEnumerable<Singer> uniqueSingers = singersDuplicates.Distinct(new DefaultSingerComparer());
			
			foreach (Singer singer in uniqueSingers)
			{
				Console.WriteLine(singer.Id);
			}
		}
	}
}
