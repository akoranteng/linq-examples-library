using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary.Collections
{
	public class PageComponent
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public string Extension { get; set; }
		public int SizeBytes { get; set; }

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this);
		}
	}
}
