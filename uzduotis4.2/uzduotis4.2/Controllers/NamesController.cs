using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace uzduotis4._2_.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NamesController : ControllerBase
	{
		[HttpPost]
		public IActionResult ProcessNames(string[] names)
		{
			var nameList = new List<string>();

			foreach(var name in names)
			{
				var length = name.Length;

				nameList.Add($"{name} vardo ilgis yra {length} simboliai");
			}

			return new OkObjectResult(nameList);
		}
	}
}
