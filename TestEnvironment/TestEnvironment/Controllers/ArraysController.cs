using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestEnvironment.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class ArraysController : ControllerBase
	{
		//[HttpGet]
		//public IActionResult TryArrays()
		//{
		//	//string[] names1 = { "Jonas", "Onutė", "Petras" }; // pirmas būdas

		//	//string[] names2 = new string[3];
		//	//names2[0] = "Jonas";
		//	//names2[1] = "Onutė";
		//	//names2[2] = "Petras";

		//	int[] ages = new int[5];
		//	ages[0] = 45;
		//	ages[1] = 36;
		//	ages[3] = 18;
		//	ages[4] = 20;

		//	var sum = ages[0] + ages[1] + ages[2] + ages[3] + ages[4];

		//	var average = (double)sum / ages.Length;

		//	return new OkObjectResult(average);
		//}

		[HttpPost]
		public IActionResult CalculateAverage(int[] ages) // [50, 36, 18, 50]
		{
			double sum = 0;
			for(int i = 0; i < ages.Length; i++)
			{
				sum += ages[i];
			}

			double average = sum / ages.Length;

			return new OkObjectResult(average);
		}
	}
}
