using Microsoft.AspNetCore.Mvc;

namespace uzduotis3._1_.Controllers
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

			return Ok();
		}
	}
}
