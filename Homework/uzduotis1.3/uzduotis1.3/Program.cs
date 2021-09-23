using System;

namespace uzduotis1._3_
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Įveskite vardą.");
			var name = Console.ReadLine();

			Console.WriteLine("Įveskite pavardę.");
			var surname = Console.ReadLine();

			Console.WriteLine("Įveskite gimimo vietą.");
			var place = Console.ReadLine();

			Console.WriteLine(name + " " + surname + " deginasi mieste, kuris vadinasi " + place);
		}
	}
}
