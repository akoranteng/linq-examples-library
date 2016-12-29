using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class SumOperator : ILinqOperator
	{
		public void RunDemo()
		{
			IEnumerable<int> integers = Enumerable.Range(1, 100);
			int sum = integers.Sum();
			Console.WriteLine(sum);

			IEnumerable<Concert> concerts = DemoCollections.GetConcerts();
			int allConcerts = concerts.Sum(c => c.ConcertCount);
			Console.WriteLine(allConcerts);
		}
	}
}
