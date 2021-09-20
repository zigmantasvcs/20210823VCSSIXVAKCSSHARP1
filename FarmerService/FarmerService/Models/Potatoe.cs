namespace FarmerService.Models
{
	public class Potatoe
	{
		public double Size { get; }
		public string SoftNess { get; }
		public double Weight { get; }
		public string Color { get; }
		public string Type { get; }
		public string Description { get; }

		public Potatoe(
			double localSize, 
			string localSoftNess, 
			double localWeight, 
			string localColor, 
			string localType)
		{
			Size = localSize;
			SoftNess = localSoftNess;
			Weight = localWeight;
			Color = localColor;
			Type = localType;
			Description = GetInformation();
		}

		private string GetInformation()
		{
			return $"Bulvės dydis: {Size}. Bulvės minkštumas: {SoftNess}. Bulvės svoris: {Weight}";
		}
	}
}
