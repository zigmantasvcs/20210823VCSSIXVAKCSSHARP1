using System;

namespace ifai
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Iveskite amziu:");
			
			var age = Convert.ToInt32(Console.ReadLine());

			if(age >= 20 && age < 50)
			{
				Console.WriteLine("Sveiki prisijungę!!!");
			}
			else if (age >= 50 && age <=70)
			{
				Console.WriteLine("Sveiki prisijungę!!! Jums yra specialus pasiūlymas!");
			}
			else
			{
				Console.WriteLine("Gal ateikite kitą kartą");
			}
		}
	}
}
