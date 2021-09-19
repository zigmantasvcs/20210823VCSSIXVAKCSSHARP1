using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerService.Models
{
	public class Automobilis
	{
		// duomenys/atributai
		public string Marke { get; set; }
		public string Modelis { get; set; }
		public int GamybosMetai { get; set; }
		public int Rida { get; set; }

		// algoritmai.metodai
		public double KilometraiPerMetus()
		{
			var praejoMetu = DateTime.Now.Year - GamybosMetai;
			double kmPerMetus = (double)Rida / praejoMetu;

			int[] aaa = new int[] { };

			foreach(var a in aaa)
			{

			}


			var suma = 0;







			return kmPerMetus;
		}
	}

	public class AutomobiliuServisas
	{

	}
}
