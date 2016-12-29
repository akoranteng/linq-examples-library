using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary.Collections
{
	public class DefaultSingerComparer : IEqualityComparer<Singer>
	{
		public bool Equals(Singer x, Singer y)
		{
			return x.Id == y.Id;
		}

		public int GetHashCode(Singer obj)
		{
			return obj.Id.GetHashCode();
		}
	}
}
