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
	public class UsersController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetConnectedUser(string name, string surname)
		{
			return new OkObjectResult(name+surname);
		}


	}
}
