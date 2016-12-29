using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class SelectManyOperator : ILinqOperator
	{
		public void RunSelectManyOperatorExample()
		{
			string[] bands = DemoCollections.GetBands();


			IEnumerable<char> characters = bands.SelectMany(b => b.ToArray());
			foreach (char item in characters)
			{
				Console.WriteLine(item);
			}
		}

		public void RunNewExamples()
		{
			IEnumerable<WebPage> webPages = DemoCollections.GetWebPages();
			List<PageComponent> allPageComponents = webPages.SelectMany(wps => wps.PageComponents).ToList();
			//allPageComponents.ForEach(pc => Console.WriteLine(pc.ToString()));
			List<char> chars = webPages.SelectMany(wps => wps.Name).ToList();
			//chars.ForEach(c => Console.Write(c));

			var uniqueExtensions = webPages.SelectMany(wps => wps.PageComponents
				.Select(pc => new { Extension = pc.Extension })).Distinct().OrderBy(n => n.Extension).ToList();
			//uniqueExtensions.ForEach(p => Console.WriteLine(p.Extension));

			var allPageComponentsWithIndex = webPages.SelectMany
				((wps, index) => wps.PageComponents.Select(c => new { ComponentName = c.Name, PositionOfContainer = index })).ToList();
			//allPageComponentsWithIndex.ForEach(pc => Console.WriteLine(string.Concat(pc.PositionOfContainer, ": ", pc.ComponentName)));
			var pagesWithComponents = webPages
				.SelectMany(wps => wps.PageComponents, 
				(wp, cp) => new { PageName = wp.Name, ComponentName = cp.Name }).ToList();
			//pagesWithComponents.ForEach(p => Console.WriteLine(string.Concat(p.PageName, ": ", p.ComponentName)));

			var pagesWithComponentsAndIndex = webPages.SelectMany((wps, index) => wps.PageComponents
				.Select(c => new { ComponentName = c.Name, PositionOfContainer = index }), 
				(wp, cp) => new { PageName = wp.Name, ComponentName = cp.ComponentName, PositionOfContainer = cp.PositionOfContainer }).ToList();
			pagesWithComponentsAndIndex.ForEach(c => Console.WriteLine(string.Concat("Page: ", c.PageName, ", position: ", c.PositionOfContainer, ", component: ", c.ComponentName)));
		}

		public void RunSelectManyOperatorExampleComplex()
		{
			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			IEnumerable<Concert> concerts = DemoCollections.GetConcerts();

			var singerConcerts = singers.SelectMany(s => concerts.Where(c => c.SingerId == s.Id)
				.Select(c => new {Year = c.Year, ConcertCount = c.ConcertCount, Name = string.Concat(s.FirstName, " ", s.LastName) }));

			foreach (var item in singerConcerts)
			{
				Console.WriteLine(string.Concat(item.Name, ", ", item.Year, ", ", item.ConcertCount));
			}
		}

		public void RunSelectManyOperatorExampleOop()
		{
			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			IEnumerable<Concert> concerts = DemoCollections.GetConcerts();

			IEnumerable<SingerConcert> singerConcerts = singers.SelectMany(s => concerts.Where(c => c.SingerId == s.Id)
				.Select(c => new SingerConcert() { Year = c.Year, ConcertCount = c.ConcertCount, SingerName = string.Concat(s.FirstName, " ", s.LastName) }));

			foreach (SingerConcert item in singerConcerts)
			{
				Console.WriteLine(string.Concat(item.SingerName, ", ", item.Year, ", ", item.ConcertCount));
			}
		}

		private void RunAllExamples()
		{
			RunSelectManyOperatorExample();
			RunSelectManyOperatorExampleComplex();
			RunSelectManyOperatorExampleOop();
		}

		public void RunDemo()
		{
			//RunAllExamples();
			RunNewExamples();
		}
	}
}
