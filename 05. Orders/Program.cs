using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {


            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            CalculateProducts(product, count);
        }

        static void CalculateProducts(string product, int count)
        {
            const double COFFEE = 1.50;
            const double WATER = 1.00;
            const double COKE = 1.40;
            const double SNACKS = 2.00;
            double totalCost = 0;

            switch (product)
            {
                case "coffee":
                    totalCost = count * COFFEE;
                    break;
                case "water":
                    totalCost = count * WATER;
                    break;
                case "coke":
                    totalCost = count * COKE;
                    break;
                case "snacks":
                    totalCost = count * SNACKS;
                    break;
            }

            Console.WriteLine($"{totalCost:f2}");
        }
    }
}
