using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary.Collections
{
	public class WebPage
	{
		public string Name { get; set; }
		public IEnumerable<PageComponent> PageComponents { get; set; }
	}
}
