using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uzduotis3._1.antras_dublis.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class IntervalController : ControllerBase
	{
		[HttpGet]
		public IActionResult Get(
			int start,
			int end)
		{
			if (start > end)
			{
				return new OkObjectResult("Blogi rėžiai");
			}
			else
			{
				var message = "";

				for(int i = start; i <= end; i++)
				{
					message += $"{i} {i * i} \n";
				}

				return new OkObjectResult(message);
			}
		}
	}
}
