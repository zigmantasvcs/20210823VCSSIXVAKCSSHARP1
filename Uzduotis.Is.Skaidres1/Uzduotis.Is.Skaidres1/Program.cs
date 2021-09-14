using System;

namespace Uzduotis.Is.Skaidres1
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = 5;
			int secondNumber = 10;

			// tikriname ar antrasis skaicius didesnis uz pirma skaiciu
			if(secondNumber > firstNumber)
			{
				Console.WriteLine($"Antrasis skaičius yra didesnis už pirmą. Antrojo skaičiaus reikšmė yra {secondNumber}");
			}
		}
	}
}
