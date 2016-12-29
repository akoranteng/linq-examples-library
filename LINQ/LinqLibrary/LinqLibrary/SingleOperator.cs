using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class SingleOperator : ILinqOperator
	{
		public void RunDemo()
		{
			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			Singer singer = singers.SingleOrDefault(s => s.Id == 200);
			Console.WriteLine(singer == null ? "No such singer" : singer.LastName);
		}
	}
}
