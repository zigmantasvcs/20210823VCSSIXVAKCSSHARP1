using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._1.uzduotis.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NamesController : ControllerBase
	{
		[HttpPost]
		public IActionResult FindLongestName(string[] names) // ["Ona", "Jonas", "Tomas", "Konstantinas"]
		{
			var maxValue = 0;
			var longestName = "";

			foreach (var name in names)
			{
				var nameLength = name.Length; // einamojo ciklo metu gauname einamą vardo ilgį
				
				if(maxValue <= nameLength)
				{
					maxValue = nameLength;
					longestName = name;
				}
			}

			return new OkObjectResult($"Ilgiausias vardas yra {longestName}, jo ilgis yra {maxValue} simbolių");
		}
	}
}
