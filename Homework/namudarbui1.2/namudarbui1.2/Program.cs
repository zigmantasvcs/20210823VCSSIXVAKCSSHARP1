using System;

namespace namudarbui1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(
				"Programa skaičiuoja greitį. Jūs įvedate kelią metrais ir laiką sekundėmis, " +
				"o programa apskaičiuoja kilometrais per valandą!");

			Console.WriteLine("Įveskite kelią metrais");
			double kelias = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Įveskite kelią sekundemis");
			double laikas = Convert.ToDouble(Console.ReadLine());

			double keliasKilometrais = kelias / 1000;
			double laikasValandomis = laikas / 3600;

			var greitis = keliasKilometrais / laikasValandomis;

			Console.WriteLine(
				$"Įvedus laiką sekundėmis: {laikas} s. ir kelią metrais: {kelias} m.. " +
				$"Gauname {greitis} km/h greitį.");
		}
	}
}
