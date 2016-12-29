using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class TakeWhileOperator
	{
		public void RunDemo()
		{
			string[] bands = DemoCollections.GetBands();
			IEnumerable<string> res = bands.TakeWhile(b => b[0] != 'E');
			foreach (string s in res)
			{
				//Console.WriteLine(s);
			}

			IEnumerable<string> res2 = bands.TakeWhile((b, i) => b[0] != 'E' && i < 8);
			foreach (string s in res2)
			{
				Console.WriteLine(s);
			}
		}
	}
}
