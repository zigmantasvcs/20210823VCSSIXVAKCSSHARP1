using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._2.uzduotis.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NumbersController : ControllerBase
	{
		[HttpPost]
		public IActionResult FilterNumbers(int[] numbers)
		{
			var filteredNumbers = new List<int>();
			foreach(var number in numbers)
			{
				if(number % 5 == 0) // ar skaiciu padalines modalu is 5 gausiu 0?
				{
					filteredNumbers.Add(number);
				}
			}

			return new OkObjectResult(filteredNumbers);
		}
	}
}
