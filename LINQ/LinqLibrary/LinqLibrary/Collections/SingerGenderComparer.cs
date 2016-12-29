using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary.Collections
{
	public class SingerGenderComparer : IEqualityComparer<int>
	{
		private int _femaleSingerIdLimit = 3;
		
		public bool Equals(int x, int y)
		{
			return IsPerformedByFemaleSinger(x) == IsPerformedByFemaleSinger(y);
		}

		public int GetHashCode(int obj)
		{
			return IsPerformedByFemaleSinger(obj) ? 1 : 2;
		}

		public bool IsPerformedByFemaleSinger(int singerId)
		{
			return singerId < _femaleSingerIdLimit;
		}
	}
}
