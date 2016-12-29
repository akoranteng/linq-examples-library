using LinqLibrary.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
	public class DemoCollections
	{
		public static string[] GetBands()
		{
			string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Metallica", "Cream", "Oasis", "Abba", "Blur"
							 , "Chic", "Eurythmics", "Genesis", "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers"
							 , "Noir Desir", "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Tears for Fears"
							 , "Deep Purple", "KISS"};
			return bands;
		}

		public static IEnumerable<PageComponent> GetPageComponents()
		{
			return new List<PageComponent>()
			{
				new PageComponent() { Name = "jquery.js", Type = "script", Extension = "js", SizeBytes = 12345},
				new PageComponent() { Name = "datatables.js", Type = "script", Extension = "js", SizeBytes = 2345},
				new PageComponent() { Name = "knockout.js", Type = "script", Extension = "js", SizeBytes = 70386},
				new PageComponent() { Name = "greeter.ts", Type = "script", Extension = "ts", SizeBytes = 10794},
				new PageComponent() { Name = "myscript.ts", Type = "script", Extension = "ts", SizeBytes = 86124},
				new PageComponent() { Name = "mystyle.css", Type = "stylesheet", Extension = "css", SizeBytes = 8433},
				new PageComponent() { Name = "datatables.css", Type = "stylesheet", Extension = "css", SizeBytes = 27470},
				new PageComponent() { Name = "combined.css", Type = "stylesheet", Extension = "css", SizeBytes = 24627},
				new PageComponent() { Name = "externallink.html", Type = "html", Extension = "html", SizeBytes = 72639},
				new PageComponent() { Name = "googleads.html", Type = "html", Extension = "html", SizeBytes = 15873},
				new PageComponent() { Name = "nicepic.img", Type = "image", Extension = "img", SizeBytes = 24140},
				new PageComponent() { Name = "favicon.ico", Type = "image", Extension = "ico", SizeBytes = 64152},
				new PageComponent() { Name = "daily.img", Type = "image", Extension = "img", SizeBytes = 52667},
				new PageComponent() { Name = "selfie.png", Type = "image", Extension = "png", SizeBytes = 22922},
				new PageComponent() { Name = "mybeautifulface.png", Type = "image", Extension = "png", SizeBytes = 78416},
				new PageComponent() { Name = "hello.img", Type = "image", Extension = "img", SizeBytes = 65046},

				new PageComponent() { Name = "myscript.ts", Type = "script", Extension = "ts", SizeBytes = 86124},
				new PageComponent() { Name = "mystyle.css", Type = "stylesheet", Extension = "css", SizeBytes = 8433}
			};
		}

		public static IEnumerable<WebPage> GetWebPages()
		{
			return new List<WebPage>()
			{
				new WebPage()
				{
					Name = "www.greatsite.com", PageComponents = new List<PageComponent>() {
						new PageComponent() { Name = "home.html", Type = "html", Extension = "html", SizeBytes = 35623},
						new PageComponent() { Name = "datatables.js", Type = "script", Extension = "js", SizeBytes = 2345},
						new PageComponent() { Name = "nicepic.img", Type = "image", Extension = "img", SizeBytes = 24140},
						new PageComponent() { Name = "favicon.ico", Type = "image", Extension = "ico", SizeBytes = 64152}}
				},
				new WebPage()
				{
					Name = "www.awesomeness.com", PageComponents = new List<PageComponent>() {
						new PageComponent() { Name = "home.html", Type = "html", Extension = "html", SizeBytes = 35623},
						new PageComponent() { Name = "myscript.ts", Type = "script", Extension = "ts", SizeBytes = 86124},
						new PageComponent() { Name = "daily.img", Type = "image", Extension = "img", SizeBytes = 52667},
						new PageComponent() { Name = "selfie.png", Type = "image", Extension = "png", SizeBytes = 22922},
						new PageComponent() { Name = "mybeautifulface.png", Type = "image", Extension = "png", SizeBytes = 78416},
						new PageComponent() { Name = "hello.img", Type = "image", Extension = "img", SizeBytes = 65046}}
				},
				new WebPage()
				{
					Name = "www.boring.com", PageComponents = new List<PageComponent>() {
						new PageComponent() { Name = "datatables.css", Type = "stylesheet", Extension = "css", SizeBytes = 27470},
						new PageComponent() { Name = "combined.css", Type = "stylesheet", Extension = "css", SizeBytes = 24627},
						new PageComponent() { Name = "externallink.html", Type = "html", Extension = "html", SizeBytes = 72639},
						new PageComponent() { Name = "googleads.html", Type = "html", Extension = "html", SizeBytes = 15873},
						new PageComponent() { Name = "nicepic.img", Type = "image", Extension = "img", SizeBytes = 24140}}
				}
			};
		}

		public static IEnumerable<Student> GetStudents()
		{
			return new List<Student>()
			{
				new Student() { Id = 1, Name = "John", Age = 13},
				new Student() { Id = 2, Name = "Mary", Age = 12},
				new Student() { Id = 3, Name = "Anne", Age = 14}
			};
		}

		public static IEnumerable<StudentScore> GetScores()
		{
			return new List<StudentScore>()
			{
				new StudentScore() { StudentId = 1, Subject = "Maths", Points = 54},
				new StudentScore() { StudentId = 1, Subject = "Maths", Points = 32},
				new StudentScore() { StudentId = 1, Subject = "Maths", Points = 45},
				new StudentScore() { StudentId = 1, Subject = "English", Points = 55},
				new StudentScore() { StudentId = 1, Subject = "English", Points = 54},
				new StudentScore() { StudentId = 1, Subject = "Biology", Points = 32},
				new StudentScore() { StudentId = 1, Subject = "Biology", Points = 27},
				new StudentScore() { StudentId = 1, Subject = "Biology", Points = 52},

				new StudentScore() { StudentId = 2, Subject = "Maths", Points = 44},
				new StudentScore() { StudentId = 2, Subject = "Maths", Points = 37},
				new StudentScore() { StudentId = 2, Subject = "Maths", Points = 49},
				new StudentScore() { StudentId = 2, Subject = "English", Points = 59},
				new StudentScore() { StudentId = 2, Subject = "English", Points = 64},
				new StudentScore() { StudentId = 2, Subject = "Biology", Points = 42},
				new StudentScore() { StudentId = 2, Subject = "Biology", Points = 67},
				new StudentScore() { StudentId = 2, Subject = "Biology", Points = 50},

				new StudentScore() { StudentId = 3, Subject = "Maths", Points = 53},
				new StudentScore() { StudentId = 3, Subject = "Maths", Points = 72},
				new StudentScore() { StudentId = 3, Subject = "Maths", Points = 48},
				new StudentScore() { StudentId = 3, Subject = "English", Points = 54},
				new StudentScore() { StudentId = 3, Subject = "English", Points = 59},
				new StudentScore() { StudentId = 3, Subject = "Biology", Points = 32},
				new StudentScore() { StudentId = 3, Subject = "Biology", Points = 87},
				new StudentScore() { StudentId = 3, Subject = "Biology", Points = 34}
			};
		}

		public static IEnumerable<Singer> GetSingers()
		{
			return new List<Singer>()
			{
				new Singer(){Id = 1, FirstName = "Freddie", LastName = "Mercury", BirthYear=1964}
				, new Singer(){Id = 2, FirstName = "Elvis", LastName = "Presley", BirthYear = 1954}
				, new Singer(){Id = 3, FirstName = "Chuck", LastName = "Berry", BirthYear = 1954}
				, new Singer(){Id = 4, FirstName = "Ray", LastName = "Charles", BirthYear = 1950}
				, new Singer(){Id = 5, FirstName = "David", LastName = "Bowie", BirthYear = 1964}
			};
		}

		public static IEnumerable<Concert> GetConcerts()
		{
			return new List<Concert>()
			{
				new Concert(){SingerId = 1, ConcertCount = 53, Year = 1979}
				, new Concert(){SingerId = 1, ConcertCount = 74, Year = 1980}
				, new Concert(){SingerId = 1, ConcertCount = 38, Year = 1981}
				, new Concert(){SingerId = 2, ConcertCount = 43, Year = 1970}
				, new Concert(){SingerId = 2, ConcertCount = 64, Year = 1968}
				, new Concert(){SingerId = 3, ConcertCount = 32, Year = 1960}
				, new Concert(){SingerId = 3, ConcertCount = 51, Year = 1961}
				, new Concert(){SingerId = 3, ConcertCount = 95, Year = 1962}
				, new Concert(){SingerId = 4, ConcertCount = 42, Year = 1950}
				, new Concert(){SingerId = 4, ConcertCount = 12, Year = 1951}
				, new Concert(){SingerId = 5, ConcertCount = 53, Year = 1983}
			};
		}
	}
}
