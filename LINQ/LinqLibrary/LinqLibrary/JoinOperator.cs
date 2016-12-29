using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class JoinOperator : ILinqOperator
	{
		public void RunDemo()
		{
			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			IEnumerable<Concert> concerts = DemoCollections.GetConcerts();

			var singerConcerts = singers.Join(concerts, s => s.Id, c => c.SingerId, (s, c) => new
			{
				Id = s.Id,
				SingerName = string.Concat(s.FirstName, " ", s.LastName),
				ConcertCount = c.ConcertCount,
				Year = c.Year
			});

			foreach (var res in singerConcerts)
			{
				Console.WriteLine(string.Concat(res.Id, ": ", res.SingerName, ", ", res.Year, ", ", res.ConcertCount));
			}
		}
	}
}
