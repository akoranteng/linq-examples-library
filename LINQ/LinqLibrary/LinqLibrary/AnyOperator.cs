using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class AnyOperator : ILinqOperator
	{
		public void RunDemo()
		{
			string[] bands = DemoCollections.GetBands();
			bool exists = bands.Any();
			//bool exists = bands.Any(b => b.EndsWith("hkhkj"));
			Console.WriteLine(exists);
		}
	}
}
