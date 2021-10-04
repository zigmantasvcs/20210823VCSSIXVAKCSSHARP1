using Microsoft.AspNetCore.Mvc;

namespace uzduotis4._1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WeatherController : ControllerBase
	{
		[HttpPost]
		public IActionResult ProcessData(double[] data)
		{
			var maxValue = FindMaxValue(data);

			var minValue = FindMinValue(data);

			var average = FindAverage(data);

			return Ok(
				$"Iš pateiktų oro temperatūrų mažiausia temperatūra yra {minValue} " +
				$"laipsniai celcijaus, didžiausia temperatūra yra {maxValue} " +
				$"laipsnių celcijaus, o vidutinė temperatūra yra {average} " +
				$"laipsnių celcijaus");
		}

		private double FindMaxValue(double[] data)
		{
			double max = 0;
			foreach (var value in data)
			{
				if (max < value)
				{
					max = value;
				}
			}

			return max;
		}

		private double FindMinValue(double[] data)
		{
			double min = 0;
			foreach (var value in data)
			{
				if (min > value)
				{
					min = value;
				}
			}

			return min;
		}

		private double FindAverage(double[] data)
		{
			double sum = 0;
			foreach (var value in data)
			{
				sum += value;
			}

			return sum / data.Length;
		}
	}
}
