using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class GroupByOperator : ILinqOperator
	{
		public void RunDemo()
		{
			//RunFirstPrototype();
			//RunSecondPrototype();
			RunVariousExamples();
		}

		private void RunFirstPrototype()
		{
			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			IEnumerable<Concert> concerts = DemoCollections.GetConcerts();

			IEnumerable<IGrouping<int, Concert>> concertGroups = concerts.GroupBy(c => c.SingerId);
			foreach (IGrouping<int, Concert> concertGroup in concertGroups)
			{
				Console.WriteLine("Concerts for singer of ID {0}:", concertGroup.Key);
				foreach (Concert concert in concertGroup)
				{
					Console.WriteLine("Number of concerts: {0}, in the year of {1}.", concert.ConcertCount, concert.Year);
				}
			}

			IEnumerable<IGrouping<int, int>> concertGroupsFiltered = concerts.GroupBy(c => c.SingerId, c => c.ConcertCount);
			foreach (IGrouping<int, int> concertGroup in concertGroupsFiltered)
			{
				Console.WriteLine("Concerts for singer of ID {0}:", concertGroup.Key);
				foreach (int concertCount in concertGroup)
				{
					Console.WriteLine("Number of concerts: {0}.", concertCount);
				}
			}
		}

		private void RunSecondPrototype()
		{
			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			IEnumerable<Concert> concerts = DemoCollections.GetConcerts();
			SingerGenderComparer comparer = new SingerGenderComparer();

			IEnumerable<IGrouping<int, Concert>> concertGroups = concerts.GroupBy(c => c.SingerId, comparer);
			foreach (IGrouping<int, Concert> concertGroup in concertGroups)
			{
				Console.WriteLine("Concerts of {0} singers: ", comparer.IsPerformedByFemaleSinger(concertGroup.Key) ? "female" : "male");
				foreach (Concert concert in concertGroup)
				{
					Console.WriteLine("Number of concerts: {0}, in the year of {1} by singer {2}.", concert.ConcertCount, concert.Year, concert.SingerId);
				}
			}

			IEnumerable<IGrouping<int, int>> concertGroupsFiltered = concerts.GroupBy(c => c.SingerId, c => c.ConcertCount, comparer);
			foreach (IGrouping<int, int> concertGroup in concertGroupsFiltered)
			{
				Console.WriteLine("Concerts of {0} singers: ", comparer.IsPerformedByFemaleSinger(concertGroup.Key) ? "female" : "male");
				foreach (int concertCount in concertGroup)
				{
					Console.WriteLine("Number of concerts: {0}.", concertCount);
				}
			}
		}

		private void RunVariousExamples()
		{
			IEnumerable<PageComponent> pageComponents = DemoCollections.GetPageComponents();
			//group by type
			IEnumerable<IGrouping<string, PageComponent>> groupByTypeBasic = pageComponents.GroupBy(g => g.Type);
			foreach (var group in groupByTypeBasic)
			{
				/*
				Console.WriteLine($"Element type: {group.Key}, items in group: {group.Count()}, total size: {group.Sum(g => g.SizeBytes)}");
				Console.WriteLine("============================");
				foreach (PageComponent pc in group)
				{
					Console.WriteLine($"Element name: {pc.Name}");
				}
				Console.WriteLine("============================");
				Console.WriteLine();
				*/
			}

			//group by extension
			IEnumerable<IGrouping<string, PageComponent>> groupByExtensionBasic = pageComponents.GroupBy(g => g.Extension);
			foreach (var group in groupByExtensionBasic)
			{
				/*
				Console.WriteLine($"Extension: {group.Key}");
				Console.WriteLine("============================");
				foreach (PageComponent pc in group)
				{
					Console.WriteLine($"Element name: {pc.Name}");
				}
				Console.WriteLine("============================");
				Console.WriteLine();
				*/
			}

			var groupByComponentSizeRange = pageComponents.GroupBy(pe =>
			{
				int groupSize = 10000;
				int lowerBound = pe.SizeBytes - pe.SizeBytes % groupSize;
				int upperBound = lowerBound + groupSize;
				return new PageComponentSizeGrouper() { LowerBound = lowerBound, UpperBound = upperBound };
			}, new PageComponentSizeGrouperEqualityComparer());

			foreach (var group in groupByComponentSizeRange.OrderBy(g => g.Key.LowerBound))
			{
				/*
				Console.WriteLine($"Size range: {group.Key.ToString()}, items in group: {group.Count()}");
				Console.WriteLine("============================");
				foreach (PageComponent pc in group)
				{
					Console.WriteLine($"Element name: {pc.Name}");
				}
				Console.WriteLine("============================");
				Console.WriteLine();
				*/
			}

			var duplicatesFinder = pageComponents.GroupBy(pe => pe, new PageElementEqualityComparer());
			foreach (var group in duplicatesFinder)
			{
				//Console.WriteLine($"Element name: {group.Key.Name}, occurrence: {group.Count()}");				
			}

			var groupByTypeWithElementSelector = pageComponents.GroupBy(
				pe => pe.Type, 
				pe =>
				new { NameCapitals = pe.Name.ToUpper(), ShortName = pe.Name.Substring(0, 5), CharCount = pe.Name.Count() });
			foreach (var group in groupByTypeWithElementSelector)
			{
				/*
				Console.WriteLine($"Element type: {group.Key}");
				Console.WriteLine("============================");
				foreach (var pc in group)
				{
					Console.WriteLine($"Element name capitals: {pc.NameCapitals}, short name: {pc.ShortName}, chars: {pc.CharCount}");
				}
				Console.WriteLine("============================");
				Console.WriteLine();				
				*/
			}

		var groupByComponentSizeWithResultSelector = pageComponents.GroupBy(pe =>
		{
			int groupSize = 10000;
			int lowerBound = pe.SizeBytes - pe.SizeBytes % groupSize;
			int upperBound = lowerBound + groupSize;
			return new PageComponentSizeGrouper() { LowerBound = lowerBound, UpperBound = upperBound };
		}, 
		(sizeGroup, pageElements) => 
			new
			{
				ElementCountInGroup = pageElements.Count(),
				MinElementSize = pageElements.Min(pe => pe.SizeBytes),
				MaxElementSize = pageElements.Max(pe => pe.SizeBytes),
				GroupingKeyOrderer = sizeGroup.LowerBound,
				GroupingKeyToString = sizeGroup.ToString()				
			}
		, new PageComponentSizeGrouperEqualityComparer());

		foreach (var group in groupByComponentSizeWithResultSelector.OrderBy(g => g.GroupingKeyOrderer))
		{	
			/*		
			Console.WriteLine($"Size range: {group.GroupingKeyToString}");
			Console.WriteLine($"Item count in group: { group.ElementCountInGroup}");
			Console.WriteLine($"Min element size: {group.MinElementSize}");
			Console.WriteLine($"Max element size: {group.MaxElementSize}");
			Console.WriteLine("============================");
			Console.WriteLine();			
			*/
		}

			var groupByComponentSizeWithResultAndElementSelector = pageComponents.GroupBy(pe =>
			{
				int groupSize = 10000;
				int lowerBound = pe.SizeBytes - pe.SizeBytes % groupSize;
				int upperBound = lowerBound + groupSize;
				return new PageComponentSizeGrouper() { LowerBound = lowerBound, UpperBound = upperBound };
			}, pe =>
				new
				{
					ElementName = pe.Name,
					ModifiedSize = pe.SizeBytes - 1000
				},
			(sizeGroup, pageElements) =>
			{
				int minElementSize = pageElements.Min(pe => pe.ModifiedSize);
				int maxElementSize = pageElements.Max(pe => pe.ModifiedSize);
				string minElementName = (from pe in pageElements where pe.ModifiedSize == minElementSize select pe.ElementName).FirstOrDefault();
				string maxElementName = (from pe in pageElements where pe.ModifiedSize == maxElementSize select pe.ElementName).FirstOrDefault();
				return new
				{
					ElementCountInGroup = pageElements.Count(),
					MinElementSize = minElementSize,
					MaxElementSize = maxElementSize,
					MinElementName = minElementName,
					MaxElementName = maxElementName,
					GroupingKeyOrderer = sizeGroup.LowerBound,
					GroupingKeyToString = sizeGroup.ToString()
				};
			}
			, new PageComponentSizeGrouperEqualityComparer());

			foreach (var group in groupByComponentSizeWithResultAndElementSelector.OrderBy(g => g.GroupingKeyOrderer))
			{						
				Console.WriteLine($"Size range: {group.GroupingKeyToString}");
				Console.WriteLine($"Item count in group: { group.ElementCountInGroup}");
				Console.WriteLine($"Min element size: {group.MinElementSize}");
				Console.WriteLine($"Max element size: {group.MaxElementSize}");
				Console.WriteLine($"Min element name: {group.MinElementName}");
				Console.WriteLine($"Max element name: {group.MaxElementName}");
				Console.WriteLine("============================");
				Console.WriteLine();				
			}
		}
	}
}
