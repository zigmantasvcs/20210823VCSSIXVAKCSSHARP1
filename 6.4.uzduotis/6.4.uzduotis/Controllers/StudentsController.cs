using _6._4.uzduotis.Models;
using _6._4.uzduotis.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._4.uzduotis.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		//{
		//  "name":"Jonas",
		//  "surname":"Jonaitis",
		//  "documentId":"asp123",
		//  "birthDay":"2000-01-01"
		//}

		[HttpPost]
		public IActionResult Create(Student student)
		{
			if(student.Name == "")
			{
				return ValidationProblem("Nenurodėte vardo!");
			}

			if(student.Surname == "")
			{
				return ValidationProblem("Nenurodėte pavardės!");
			}

			if (student.DocumentId == "")
			{
				return ValidationProblem("Nenurodėte dokumento!");
			}

			if (student.BirthDay == DateTime.MinValue)
			{
				return ValidationProblem("Nenurodėte Gimimo datos!");
			}

			return Ok();
		}

		[HttpGet("list")]
		public IActionResult List()
		{
			var service = new StudentService();

			var students = service.GetStudents();

			return new OkObjectResult(students);
		}

		[HttpGet]
		public IActionResult Get(string documentId)
		{
			var service = new StudentService();

			var students = service.GetStudents();

			foreach(var student in students)
			{
				if(student.DocumentId == documentId)
				{
					return new OkObjectResult(student);
				}
			}

			return NotFound();
		}

		[HttpGet("filter")]
		public IActionResult Filter(string text)
		{
			var service = new StudentService();

			var students = service.GetStudents();

			var filteredStudents = new List<Student>();
			foreach(var student in students)
			{
				if (student.GetInformation().Contains(text))
				{
					filteredStudents.Add(student);
				}
			}

			return new OkObjectResult(filteredStudents);
		}
	}
}
