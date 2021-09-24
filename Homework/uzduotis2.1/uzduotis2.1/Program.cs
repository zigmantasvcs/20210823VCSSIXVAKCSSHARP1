using System;

namespace uzduotis2._1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Sveiki! Pasirinkite kokio gėrimo pageidausite?");
			Console.WriteLine("1 - limonadas.");
			Console.WriteLine("2 - arbata.");
			Console.WriteLine("3 - kakava.");
			Console.WriteLine("4 - kava.");
			Console.WriteLine("5 - nieko.");

			var choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					Console.WriteLine("Jūs pasirnkite limonadą");
					break;

				case "2":
					Console.WriteLine("Jūs pasirnkite arbatą");
					break;

				case "3":
					Console.WriteLine("Jūs pasirnkite kakavą");
					break;

				case "4":
					Console.WriteLine("Jūs pasirnkite kavą");
					break;

				default:
					Console.WriteLine("Jūs pasirnkote nieko.");
					break;
			}
		}
	}
}
