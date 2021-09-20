using Microsoft.AspNetCore.Mvc;
using System;

namespace FarmerService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PotatoesController : ControllerBase
	{
		/// <summary>
		/// Suskaičiuoja kiek iš viso buvo parduota, vidurkį 
		/// ir kiek ūkininkų kurie pardavė daugiau nei 50 kilogramų
		/// </summary>
		/// <param name="potatoes"></param>
		/// <returns></returns>
		[HttpPost]
		public IActionResult CalculateResults(int[] potatoes)
		{
			string message = "";

			var sum = CalculateSum(potatoes);
			message += "Iš viso bulvių buvo parduota " + sum + " kg.";

			var average = CalculateAverage(sum, potatoes.Length);
			message += $"Vieno ūkininko parduotų bulvių vidurkis kilogramais yra {average} kg.";

			int counter = CalculatesFarmersWhoSoldMoreThenFiftyKilograms(potatoes);
			message += $"Ūkininkų, kurie pardavė daugiau negu 50 kilogramų yra {counter}";

			return new OkObjectResult(message);
		}

		private int CalculateSum(int[] collection)
		{
			int sum = 0;
			for (int i = 0; i < collection.Length; i++)
			{
				sum += collection[i];
			}

			return sum;
		}

		private double CalculateAverage(int sum, int count)
		{
			return sum / count;
		}

		private int CalculatesFarmersWhoSoldMoreThenFiftyKilograms(int[] potatoes)
		{
			int counter = 0;

			for (int i = 0; i < potatoes.Length; i++)
			{
				if (potatoes[i] > 50)
				{
					counter++;
				}
			}

			return counter;
		}
	}
}
