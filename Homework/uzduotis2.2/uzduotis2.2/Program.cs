using System;

namespace uzduotis2._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Pažaiskime!");
			
			Console.WriteLine("Įveskite pirmą skaičių! Pirmas skaičius turi būti nuo 1 iki 3");
			var firstNumber = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Įveskite antrą skaičių!");
			var secondNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Įveskite trečią skaičių!");
			var thirdNumber = Convert.ToInt32(Console.ReadLine());

			switch (firstNumber)
			{
				case 1:
					Console.WriteLine($"Skaičiuojame visų skaičių sumą: {firstNumber + secondNumber + thirdNumber}");
					break;
				case 2:
					Console.WriteLine($"Skai2iuojame pirmo ir trečio skaičiaus skirtumą: {Math.Abs(firstNumber - thirdNumber)}");
					break;
				case 3:
					Console.WriteLine($"Skaičiuojame antro ir trečio skaičiaus sandaugą: {secondNumber * thirdNumber}");
					break;
				default:
					Console.WriteLine("Jūs turėjote pasirinkti skaičių nuo 1 iki 3");
					break;
			}
		}
	}
}
