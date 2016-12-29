using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class CastAndOfTypeOperator : ILinqOperator
	{
		public void RunDemo()
		{
			ArrayList list = new ArrayList() { "this", "is", "a", "string", "list" };
			IEnumerable<string> stringListP = list.Cast<string>();
			foreach (string s in stringListP)
			{
				Console.WriteLine(s);
			}


			ArrayList stringList = new ArrayList() { "this", "is", "a", "string", "list", 1, 3, new Band() };
			IEnumerable<string> stringListProper = stringList.OfType<string>();
			foreach (string s in stringListProper)
			{
				Console.WriteLine(s);
			}

		}
	}
}
