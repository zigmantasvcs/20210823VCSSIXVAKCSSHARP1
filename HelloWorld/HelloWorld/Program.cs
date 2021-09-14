using MyLibrary;
using System;

namespace HelloWorld1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, I see sharp!");
			//Console.WriteLine("Viskas, Baigiau.");
			//var justClass = new Teacher();

			Console.WriteLine("Koks vardaS?");
			var name = Console.ReadLine();

			Console.WriteLine("Koks pavarde?");
			var surname = Console.ReadLine();

			Console.WriteLine("Koks amzius?");
			int age = Convert.ToInt32(Console.ReadLine());


			int someUnknownNumber = Convert.ToInt32("a");

			int increasedAge = age + 1;


			Console.Write(string.Concat(name, " ", surname, " ", age));

			Console.Write(string.Format("{0} {1} {2}", name, surname, age));

			Console.Write("{0} {1} {2}", name, surname, age);

			Console.Write($"Jūs suvedėte: {name}/{surname}/{age}");


		}
	}
}
