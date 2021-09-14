using System;
using System.Globalization;

namespace Homework1._1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Įvesk apskritimo spundulį:");
			string radiusInString = Console.ReadLine();
			double radius = Convert.ToDouble(radiusInString, CultureInfo.InvariantCulture);

			double c = 2 * Math.PI * radius;

			double s = Math.PI * radius * radius;

			Console.WriteLine($"Apskritimo ilgis yra: {c}");
			Console.WriteLine($"Apskritimo plotas yra: {s}");
		}
	}
}
