using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class ConcatOperator : ILinqOperator
	{
		public void RunDemo()
		{
			string[] bands = DemoCollections.GetBands();
			IEnumerable<string> selectedItems = bands.Take(5).Concat(bands.Reverse().Take(5));
			foreach (string item in selectedItems)
			{
				Console.WriteLine(item);
			}
		}
	}
}
