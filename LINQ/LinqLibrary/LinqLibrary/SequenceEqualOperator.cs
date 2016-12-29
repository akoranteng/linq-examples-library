using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class SequenceEqualOperator : ILinqOperator
	{
		public void RunDemo()
		{
			string[] bands = DemoCollections.GetBands();
			string[] bandsTwo = DemoCollections.GetBands();
			bool equal = bands.SequenceEqual(bandsTwo);
			Console.WriteLine(equal);

			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			IEnumerable<Singer> singersTwo = DemoCollections.GetSingers();
			bool singersEqual = singers.SequenceEqual(singersTwo, new DefaultSingerComparer());
			Console.WriteLine(singersEqual);
		}
	}
}
