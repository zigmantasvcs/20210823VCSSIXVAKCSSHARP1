using System;

namespace Uzduotis.Is.Skaidres2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Įveskite pirmą skaičių:");
			var firstNumber = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Įveskite antrą skaičių:");
			var secondNumber = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Įveskite trečias skaičių:");
			var thirdNumber = Convert.ToDouble(Console.ReadLine());

			if(firstNumber > secondNumber && firstNumber < 100)
			{
				Console.WriteLine("Pirmas skaicius yra didesnis uz antra skaiciu ir pirmas skaicius yra mazesnis uz 100");
			}

			if(secondNumber > 0 && secondNumber > firstNumber)
			{
				Console.WriteLine("Antrasis skaicius yra didesnis uz 0 ir antrasis skaicius yra didesnis uz pirma skaiciu");
			}

			if(firstNumber > secondNumber && firstNumber > thirdNumber || firstNumber > 0)
			{
				Console.WriteLine("Pirmasis skaicius yra didesnis uz antraji ir didesnis uz treciaji arba teigiamas");
			}

			if(thirdNumber >= 5 && thirdNumber <= 10 || thirdNumber > firstNumber || thirdNumber > secondNumber)
			{
				Console.WriteLine("Aprasykite patys");
			}
		}
	}
}
