using _6._4.uzduotis.Models;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace _6._4.uzduotis.Services
{
	public class StudentService
	{
		private string _connection;

		public StudentService()
		{
			IConfiguration config = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
				.Build();

			_connection = config.GetValue<string>("ConnectionStrings:DefaultConnection");

		}

		public List<Student> GetStudents()
		{
			MySqlConnection conn = new MySqlConnection(_connection);

			conn.Open();

			using(var cmd = conn.CreateCommand())
			{
				cmd.CommandText = "SELECT documentId, name, surname, birthDay FROM students";

				var reader = cmd.ExecuteReader(); // tas pats kas paspausti go

				using (reader)
				{
					while (reader.Read())
					{
						var student = new Student(
							reader.GetString(1),
							reader.GetString(2),
							reader.GetDateTime(3),
							reader.GetString(0)
						);
					}
				}

			}

			return null;
		}


	}
}
