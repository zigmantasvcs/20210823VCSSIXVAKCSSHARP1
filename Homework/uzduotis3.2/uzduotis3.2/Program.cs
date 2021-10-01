using System;

namespace uzduotis3._2
{
	class Program
	{
		static void Main(string[] args)
		{
			string choice = "";

			Console.WriteLine("Pasirnkite: \n 1 - laptopas; \n 2 - stacionarus;");

			while(choice != "1" && choice != "2")
			{
				if(choice != "")
				{
					Console.WriteLine("Neteisingas pasirinkimas. bandykite dar kartą.");
				}

				choice = Console.ReadLine();
			}

			var message = choice == "1" ? "laptopą" : "stacionarą";

			Console.WriteLine($"Jus pasirinkote {message}");
		}
	}
}
