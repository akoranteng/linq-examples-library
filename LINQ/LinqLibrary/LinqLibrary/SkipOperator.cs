using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class SkipOperator : ILinqOperator
	{
		public void RunDemo()
		{
			string[] bands = DemoCollections.GetBands();
			IEnumerable<string> res = bands.Skip(10);
			foreach (string item in res)
			{
				Console.WriteLine(item);
			}
		}
	}
}
