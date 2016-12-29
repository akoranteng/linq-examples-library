using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class ReverseOperator : ILinqOperator
	{
		public void RunDemo()
		{
			string[] bands = DemoCollections.GetBands();
			IEnumerable<string> bandsReversed = bands.Reverse();
			foreach (string item in bandsReversed)
			{
				Console.WriteLine(item);
			}
		}
	}
}
