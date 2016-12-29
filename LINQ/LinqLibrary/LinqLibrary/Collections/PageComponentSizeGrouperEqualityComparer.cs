using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary.Collections
{
	public class PageComponentSizeGrouperEqualityComparer : IEqualityComparer<PageComponentSizeGrouper>
	{
		public bool Equals(PageComponentSizeGrouper x, PageComponentSizeGrouper y)
		{
			return x.LowerBound == y.LowerBound && x.UpperBound == y.UpperBound;
		}

		public int GetHashCode(PageComponentSizeGrouper obj)
		{
			return obj.LowerBound * obj.UpperBound;
		}
	}
}
