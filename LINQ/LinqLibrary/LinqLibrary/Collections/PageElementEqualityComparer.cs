using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary.Collections
{
	public class PageElementEqualityComparer : IEqualityComparer<PageComponent>
	{
		public bool Equals(PageComponent x, PageComponent y)
		{
			return x.Name.Equals(y.Name, StringComparison.InvariantCultureIgnoreCase);
		}

		public int GetHashCode(PageComponent obj)
		{
			return obj.Name.GetHashCode();
		}
	}
}
