using System;

namespace _03._Celsius_to_Fahrenheit
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double temperatureC = double.Parse(Console.ReadLine());
			double temperatureF = temperatureC * 9 / 5 + 32;
			Console.WriteLine($"{temperatureF:f2}");
		}
	}
}
