using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class AverageOperator : ILinqOperator
	{
		public void RunDemo()
		{
			List<int> integers = new List<int>() { 54, 23, 76, 123, 93, 7, 3489 };
			double average = integers.Average();
			
			IEnumerable<Singer> singers = new List<Singer>() 
			{
				new Singer(){Id = 1, FirstName = "Freddie", LastName = "Mercury", BirthYear=1964}
				, new Singer(){Id = 2, FirstName = "Elvis", LastName = "Presley", BirthYear = 1954}
				, new Singer(){Id = 3, FirstName = "Chuck", LastName = "Berry", BirthYear = 1954}
				, new Singer(){Id = 4, FirstName = "Ray", LastName = "Charles", BirthYear = 1950}
				, new Singer(){Id = 5, FirstName = "David", LastName = "Bowie", BirthYear = 1964}
			};

			double averageBirthYear = singers.Average(s => s.BirthYear);

		}
	}
}
