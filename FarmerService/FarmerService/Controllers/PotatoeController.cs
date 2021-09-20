using FarmerService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmerService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PotatoeController : ControllerBase
	{
		[HttpGet]
		public IActionResult List()
		{
			//var potatoe1 = new PotatoeModel();
			//potatoe1.Size = 50;
			//potatoe1.SoftNess = "Švelni";
			//potatoe1.Type = "Kaimiškos";
			//potatoe1.Weight = 50;
			//potatoe1.Color = "Geltona";

			//var potatoe2 = new PotatoeModel();
			//potatoe2.Size = 30;
			//potatoe2.SoftNess = "Skysta";
			//potatoe2.Type = "Miestietiškos";
			//potatoe2.Weight = 30;
			//potatoe2.Color = "Raudona";

			//var potatoes = new PotatoeModel[] { potatoe1, potatoe2 };

			var potatoe1 = new Potatoe(50, "Švelni", 50, "Geltona", "Kaimiškos");
			var potatoe2 = new Potatoe(30, "Skysta", 30, "Raudona", "Miestietiškos");

			//var potatoes = new Potatoe[] { potatoe1, potatoe2 };

			var potatoes = new List<Potatoe>();
			potatoes.Add(potatoe1);
			potatoes.Add(potatoe2);

			var filteredPotatoes = new List<Potatoe>();
			foreach (var potatoe in potatoes)
			{
				if(potatoe.Weight >= 50)
				{
					filteredPotatoes.Add(potatoe);
				}
			}

			//potatoes.Remove(potatoe1);

			return new OkObjectResult(filteredPotatoes);
		}
	}
}
