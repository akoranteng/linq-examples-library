using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class OrderByOperator : ILinqOperator
	{
		public void RunDemo()
		{
			string[] bands = DemoCollections.GetBands();

			IEnumerable<string> orderedOne = bands.OrderBy(band => band.Length);
			foreach (string item in orderedOne)
			{
				//Console.WriteLine(item);
			}

			IEnumerable<string> orderedTwo = bands.OrderBy(band => band, new ConsonantNumberComparer());
			foreach (string item in orderedTwo)
			{
				//Console.WriteLine(item);
			}

			IEnumerable<string> orderedThree = bands.OrderBy(band => band, new ConsonantNumberComparer()).ThenBy(band => band);
			foreach (string item in orderedThree)
			{
				//Console.WriteLine(item);
			}

			IEnumerable<string> ordered = bands.OrderByDescending(band => band, new ConsonantNumberComparer()).ThenByDescending(band => band);
			foreach (string item in ordered)
			{
				Console.WriteLine(item);
			}
		}
	}
}
