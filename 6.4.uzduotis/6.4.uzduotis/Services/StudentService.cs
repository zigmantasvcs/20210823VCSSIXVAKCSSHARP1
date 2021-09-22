using _6._4.uzduotis.Models;
using System;
using System.Collections.Generic;

namespace _6._4.uzduotis.Services
{
	public class StudentService
	{
		public List<Student> GetStudents()
		{
			var students = new List<Student>();

			students.Add(
				new Student(
					"Jonas", 
					"Jonaitis", 
					new DateTime(2000, 1, 1), 
					"abb123"
				)
			);

			students.Add(
				new Student(
					"Onutė",
					"Pakalnutė",
					new DateTime(2001, 1, 1),
					"abb124"
				)
			);

			students.Add(
				new Student(
					"Petras",
					"Petraitis",
					new DateTime(1999, 1, 1),
					"abb125"
				)
			);

			students.Add(
				new Student(
					"Barbora",
					"Bora",
					new DateTime(1999, 10, 1),
					"abb126"
				)
			);

			students.Add(
				new Student(
					"Greta",
					"Gerietė",
					new DateTime(1999, 11, 1),
					"abb126"
				)
			);

			return students;
		}
	}
}
