using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class EmptyOperator : ILinqOperator
	{
		public void RunDemo()
		{
			IEnumerable<string> emptyStringSequence = Enumerable.Empty<string>();
		}
	}
}
