using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary.Collections;
using Newtonsoft.Json;

namespace LinqLibrary
{
	public class GroupJoinOperator : ILinqOperator
	{
		public void RunDemo()
		{
			/*
			IEnumerable<Singer> singers = DemoCollections.GetSingers();
			IEnumerable<Concert> concerts = DemoCollections.GetConcerts();

			var singerConcerts = singers.GroupJoin(concerts, s => s.Id, c => c.SingerId, (s, co) => new
			{
				Id = s.Id
				, SingerName = string.Concat(s.FirstName, " ", s.LastName)
				, ConcertCount = co.Sum(c => c.ConcertCount)
			});

			foreach (var res in singerConcerts)
			{
				Console.WriteLine(string.Concat(res.Id, ": ", res.SingerName, ", ", res.ConcertCount));
			}
			*/

			//1st silly try
			IEnumerable<Student> students = DemoCollections.GetStudents();
			IEnumerable<StudentScore> studentScores = DemoCollections.GetScores();

			IEnumerable<IGrouping<string, StudentScore>> subjectGroupings = studentScores
						.GroupBy(score => score.Subject);
			foreach (var subjectGroup in subjectGroupings)
			{
				Console.WriteLine($"Subject: {subjectGroup.Key}");
				Console.WriteLine($"Total points across all students: {subjectGroup.Sum(g => g.Points)}");
			}

			var totalStudentScores = students.GroupJoin(studentScores
				, student => student.Id, score => score.StudentId, (student, scores) =>
					new
					{
						Id = student.Id,
						StudentName = student.Name,
						TotalScore = scores.Sum(s => s.Points)
					}
			);

			foreach (var student in totalStudentScores)
			{
				Console.WriteLine($"ID: {student.Id}, Name: {student.StudentName}, Total score: {student.TotalScore} ");
			}

			//grouped try
			var groupedStudentScores = students.GroupJoin(studentScores
				, student => student.Id, score => score.StudentId, (student, scores) =>
				{
					var subjectGroups = scores.Where(score => score.StudentId == student.Id)
						.GroupBy(score => score.Subject);
					Dictionary<string, int> scoresDictionary = new Dictionary<string, int>();
					foreach (var subjectGroup in subjectGroups)
					{
						string subjectName = subjectGroup.Key;
						int subjectScoreTotal = subjectGroup.Sum(s => s.Points);
						scoresDictionary[subjectName] = subjectScoreTotal;
					}

					return new
					{
						Id = student.Id,
						StudentName = student.Name,
						Scores = scoresDictionary
					};
				}
			);

			foreach (var student in groupedStudentScores)
			{
				Console.WriteLine($"ID: {student.Id}, Name: {student.StudentName}, Total score by subject: {JsonConvert.SerializeObject(student.Scores)} ");
			}
		}
	}
}
