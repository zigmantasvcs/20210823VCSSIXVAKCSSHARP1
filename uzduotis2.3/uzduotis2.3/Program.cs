using System;

namespace uzduotis2._3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Įveskite spalvos kodą!");

			var colorCode = Console.ReadLine();

			switch (colorCode)
			{
				case "#ff0a0a":
					Console.WriteLine("Važiuoti draudžiama");
					break;
				case "#ffe20a":
					Console.WriteLine("Pasiruoškite");
					break;
				case "#008509":
					Console.WriteLine("Važiuoti galima");
					break;
				default:
					Console.WriteLine("Neapažinta spalva");
					break;
			}
		}
	}
}
