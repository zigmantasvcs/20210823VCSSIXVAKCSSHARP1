using System;

namespace _6._4.uzduotis.Models
{
	public class Student
	{
		public Student(string name, string surname, DateTime birthDay, string documentId,string photo)
		{
			Name = name;
			Surname = surname;
			BirthDay = birthDay;
			DocumentId = documentId;
			Photo = photo;
			Age = DateTime.Now.Year - birthDay.Year;

		}

		public string Name { get; }

		public string Surname { get; }

		public DateTime BirthDay { get; }

		public string DocumentId { get; }

		public int Age { get; }

		public string Photo { get; }

		public string GetInformation()
		{
			return $"{Name} {Surname} {BirthDay.ToString("yyyy-MM-dd")} {DocumentId} {Age}";
		}
	}
}
