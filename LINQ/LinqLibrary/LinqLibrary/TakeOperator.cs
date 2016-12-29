using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class TakeOperator : ILinqOperator
	{
		public void RunTakeDemo()
		{
			string[] bands = DemoCollections.GetBands();

			IEnumerable<String> topItems = bands.Take(10);
			foreach (string item in topItems)
			{
				//Console.WriteLine(item);
			}

			var anonymous = bands.Take(10).Select(b => new { Name = b, Length = b.Length });
			foreach (var anon in anonymous)
			{
				Console.WriteLine("Band name: {0}, length: {1}", anon.Name, anon.Length);
			}
		}

		public void RunDemo()
		{
			RunTakeDemo();
		}
	}
}
