using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		static TempConverter()
		{
		}
		public static double FahrenheitToCelsius(double temp)
		{
			return (temp - 32) * (5 / 9);
		}
		public static double CelsiusToFahrenheit(double temp)
		{
			return (9 / 5) * temp + 32;
		}
	}
}

