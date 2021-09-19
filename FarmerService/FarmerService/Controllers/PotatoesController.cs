using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PotatoesController : ControllerBase
	{
		[HttpPost]
		public IActionResult CalculateResults(int[] potatoes)
		{
			string message = "";

			// sum skaiciavimas
			int sum = 0;
			for (int i = 0; i < potatoes.Length; i++)
			{
				sum += potatoes[i];
			}
			message += "Iš viso bulvių buvo parduota " + sum + " kg.";

			// vidurkio skaiciavimas
			var average = (double)sum / potatoes.Length;
			message += $"Vieno ūkininko parduotų bulvių vidurkis kilogramais yra {average} kg.";

			// suskaiciuoti tuos kurie pardave daugiau nei 50 kg bulviu
			int counter = 0;

			for (int i = 0; i < potatoes.Length; i++)
			{
				if(potatoes[i] > 50)
				{
					counter++;
				}
			}
			message += $"Ūkininkų, kurie pardavė daugiau negu 50 kilogramų yra {counter}";

			return new OkObjectResult(message);
		}
	}
}
