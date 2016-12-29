using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary.Collections
{
	public class PageComponentSizeGrouper
	{
		public int LowerBound { get; set; }
		public int UpperBound { get; set; }

		public override string ToString()
		{
			return string.Concat(LowerBound, " - ", UpperBound);
		}
	}
}
