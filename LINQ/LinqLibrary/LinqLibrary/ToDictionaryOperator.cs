using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class ToDictionaryOperator : ILinqOperator
	{
		public void RunDemo()
		{
			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			Dictionary<int, Singer> singersDictionary = singers.ToDictionary(s => s.Id);
			Console.WriteLine(singersDictionary[2].FirstName);

			Dictionary<int, string> singersDictionaryNames = 
				singers.ToDictionary(s => s.Id, si => string.Format("Last name: {0}", si.LastName));
			Console.WriteLine(singersDictionaryNames[2]);
		}
	}
}
