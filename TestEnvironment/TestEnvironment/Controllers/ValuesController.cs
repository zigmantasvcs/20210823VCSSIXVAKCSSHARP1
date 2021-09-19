using Microsoft.AspNetCore.Mvc;

namespace TestEnvironment.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		[HttpGet]
		public IActionResult Calc(int a, int b)
		{
			var suma = Suma(a, b);
			return new OkObjectResult(suma);
		}

		private int Suma(int a, int b)
		{
			return a + b;
		}
	}
}
