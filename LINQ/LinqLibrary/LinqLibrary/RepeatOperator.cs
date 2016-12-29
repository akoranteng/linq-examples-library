using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class RepeatOperator : ILinqOperator
	{
		public void RunDemo()
		{
			IEnumerable<int> integers = Enumerable.Repeat<int>(1, 10);
			foreach (int i in integers)
			{
				Console.WriteLine(i);
			}

			IEnumerable<Band> bands = Enumerable.Repeat<Band>(new Band() { Name = "Band" }, 10);

			Band band = new Band() { Name = "Band" };
			IEnumerable<Band> bands2 = Enumerable.Repeat<Band>(band, 10);
		}
	}
}
