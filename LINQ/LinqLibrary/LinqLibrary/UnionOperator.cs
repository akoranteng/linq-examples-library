﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;

namespace LinqLibrary
{
	public class UnionOperator : ILinqOperator
	{
		public void RunDemo()
		{
			string[] first = new string[] {"hello", "hi", "good evening", "good day", "good morning", "goodbye" };
			string[] second = new string[] {"whatsup", "how are you", "hello", "bye", "hi"};

			IEnumerable<string> union = first.Union(second);
			foreach (string value in union)
			{
				//Console.WriteLine(value);
			}

			IEnumerable<Singer> singersA = new List<Singer>() 
			{
				new Singer(){Id = 1, FirstName = "Freddie", LastName = "Mercury"} 
				, new Singer(){Id = 2, FirstName = "Elvis", LastName = "Presley"}
				, new Singer(){Id = 3, FirstName = "Chuck", LastName = "Berry"}
				
			};

			IEnumerable<Singer> singersB = new List<Singer>() 
			{
				new Singer(){Id = 1, FirstName = "Freddie", LastName = "Mercury"} 
				, new Singer(){Id = 2, FirstName = "Elvis", LastName = "Presley"}
				, new Singer(){Id = 4, FirstName = "Ray", LastName = "Charles"}
				, new Singer(){Id = 5, FirstName = "David", LastName = "Bowie"}
			};

			IEnumerable<Singer> singersUnion = singersA.Union(singersB, new DefaultSingerComparer());
			foreach (Singer s in singersUnion)
			{
				Console.WriteLine(s.Id);
			}
		}
	}
}
