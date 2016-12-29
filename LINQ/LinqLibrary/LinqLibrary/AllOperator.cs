using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class AllOperator : ILinqOperator
	{
		public void RunDemo()
		{
			string[] bands = DemoCollections.GetBands();
			bool all = bands.All(b => b.Length > 2);
			Console.WriteLine(all);
		}
	}
}
