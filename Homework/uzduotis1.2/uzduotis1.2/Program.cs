using System;

namespace uzduotis1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Iveskite atstuma metrais");
			double atstumas = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Iveskite laika sekundemis");
			double laikas = Convert.ToDouble(Console.ReadLine());

			double atstumasKm = atstumas / 1000;
			double laikasValandomis = laikas / 3600;

			double greitis = atstumasKm / laikasValandomis;

			Console.WriteLine($"Jūsų greitis yra {greitis} km/h.");

		}

	}
}
