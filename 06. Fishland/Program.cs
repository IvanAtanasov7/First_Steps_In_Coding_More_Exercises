using System;

namespace _06._Fishland
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double priceMackerel = double.Parse(Console.ReadLine());
			double priceSprat = double.Parse(Console.ReadLine());
			double bonitoKg = double.Parse(Console.ReadLine());
			double scadKg = double.Parse(Console.ReadLine());
			int musselsKg = int.Parse(Console.ReadLine());
			
			double priceBonito = priceMackerel + priceMackerel * 0.6;
			double priceScad = priceSprat + priceSprat * 0.8;
			double priceMussels = 7.50;

			double SumBonito = priceBonito * bonitoKg;
			double SumScad = priceScad * scadKg;
			double SumMussels = priceMussels * musselsKg;

			double totalPrice = SumBonito + SumScad + SumMussels;
            Console.WriteLine($"{totalPrice:F2}");

        }
	}
}
