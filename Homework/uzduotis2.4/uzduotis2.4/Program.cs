using System;

namespace uzduotis2._4_
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Sveiki! Ši išspausdins skaičius nuo 0 iki 20 kas trečią dviem algortimais.");

			Console.WriteLine("Pirmas algortimas:");

			for(int i = 0; i < 20; i++)
			{
				if(i % 3 == 0)
				{
					Console.WriteLine(i);
				}
			}

			Console.WriteLine("Antras algortimas:");

			for(int i = 0; i < 20; i += 3)
			{
				Console.WriteLine(i);
			}
		}
	}
}
