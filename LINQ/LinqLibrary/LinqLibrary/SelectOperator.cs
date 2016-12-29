using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class SelectOperator : ILinqOperator
	{
		public void RunSelectOperatorExample()
		{
			string[] bands = DemoCollections.GetBands();

			IEnumerable<int> lengths = bands.Select(b => b.Length);
			foreach (int l in lengths)
			{
				Console.WriteLine(l);
			}

			var customObjects = bands.Select(b => new { Name = b, Length = b.Length });
			foreach (var item in customObjects)
			{
				Console.WriteLine("Band name: {0}, length: {1}", item.Name, item.Length);
			}

			IEnumerable<Band> bandListSimple = bands.Select(b => new Band() { AllCapitals = b.ToUpper(), Name = b, NameLength = b.Length });
			foreach (Band band in bandListSimple)
			{
				Console.WriteLine(string.Concat(band.Name, ", ", band.NameLength, ", ", band.AllCapitals));
			}

			IEnumerable<Band> bandList = bands.Select((b, i) => new Band() { AllCapitals = b.ToUpper(), BandIndex = i + 1, Name = b, NameLength = b.Length });
			foreach (Band band in bandList)
			{
				Console.WriteLine(string.Concat(band.BandIndex, ": ", band.Name, ", ", band.NameLength, ", ", band.AllCapitals));
			}
		}

		public void RunDemo()
		{
			RunSelectOperatorExample();
		}
	}
}
