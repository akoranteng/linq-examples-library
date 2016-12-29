using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class LastOperator : ILinqOperator
	{
		public void RunDemo()
		{
			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			Singer singer = singers.LastOrDefault(s => s.BirthYear == 2000);
			Console.WriteLine(singer == null ? "No such singer" : singer.LastName);
		}
	}
}
