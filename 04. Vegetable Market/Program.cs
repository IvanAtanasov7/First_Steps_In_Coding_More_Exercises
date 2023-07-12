using System;

namespace _04._Vegetable_Market
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double vegetablePrice = double.Parse(Console.ReadLine());
			double fruitPrice = double.Parse(Console.ReadLine());
			int vegetableKg = int.Parse(Console.ReadLine());
			int fruitKg = int.Parse(Console.ReadLine());
			
			double vegetableTotal = vegetablePrice * vegetableKg;
			double fruitTotal = fruitPrice * fruitKg;
			
			Console.WriteLine($"{(vegetableTotal + fruitTotal) / 1.94:f2}");
		}
	}
}
