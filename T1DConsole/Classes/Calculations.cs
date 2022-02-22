using System;
namespace T1DConsole.Classes
{
	public class Calculations
	{
		// Values
		public float Carb { get; set; }
		public float CarbRatio { get; set; }
		public float BloodSugar { get; set; }
		public float TargetBloodSugar { get; set; }
		public float CorrectionFactor { get; set; }


		// Carbs formula
		public float CalculateCarbs(float carb, float carbRatio)
        {
			float result = carb / carbRatio;
			return result;
        }

		// Blood sugar formula
		public float CalculateBloodSugar(float bloodSugar, float targetBloodSugar, float correctionFactor)
		{
			float result = (bloodSugar - targetBloodSugar) / correctionFactor;
			return result;
		}
	}
}

