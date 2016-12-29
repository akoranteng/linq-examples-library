using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class AggregateOperator : ILinqOperator
	{
		public void RunDemo()
		{
			IEnumerable<int> ints = Enumerable.Range(1, 5);
			int factorial = ints.Aggregate((f, s) => { Console.WriteLine("{0}, {1}", f, s); return f + s; } );

			int sum = ints.Aggregate(0, (f, s) => f + s);
		}
	}
}
