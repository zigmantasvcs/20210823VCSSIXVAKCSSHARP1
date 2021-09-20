using System;

namespace uzduotis._1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Įveskite atstumą metrais.");
			double atstumas = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Įveskite laiką sekundėmis.");
			double laikas = Convert.ToDouble(Console.ReadLine());

			double atstumasKilometrais = atstumas / 1000;
			double laikasValandomis = laikas / 3600;

			double greitis = atstumasKilometrais / laikasValandomis;

			Console.WriteLine($"Jūsų greitis yra {greitis} km/h.");
		}
	}
}
