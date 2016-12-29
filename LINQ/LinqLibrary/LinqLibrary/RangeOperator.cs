using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class RangeOperator : ILinqOperator
	{
		public void RunDemo()
		{
			IEnumerable<int> intRange = Enumerable.Range(100, -1);
			foreach (int i in intRange)
			{
				Console.WriteLine(i);
			}


			List<int> traditional = new List<int>();
			for (int i = 1; i <= 1000; i++)
			{
				traditional.Add(i);
			}

			foreach (int i in traditional)
			{
				//Console.WriteLine(i);
			}
		}
	}
}
