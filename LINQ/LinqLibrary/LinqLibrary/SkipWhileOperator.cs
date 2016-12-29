using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class SkipWhileOperator : ILinqOperator
	{
		public void RunDemo()
		{
			string[] bands = DemoCollections.GetBands();
			IEnumerable<string> res = bands.SkipWhile(s => s.Length < 10);
			foreach (string item in res)
			{
				//Console.WriteLine(item);
			}

			IEnumerable<string> res2 = bands.SkipWhile((s, i) => s.Length < 10 && i < 10);
			foreach (string item in res2)
			{
				Console.WriteLine(item);
			}
		}
	}
}
