using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int stuntMan = int.Parse(Console.ReadLine());
            double PriceForClotches = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.10;
            double totalPriceForClotches = stuntMan * PriceForClotches;

            if (stuntMan > 150)
            {
                double discount = totalPriceForClotches * 0.10;
                totalPriceForClotches -= discount;
            }
            double totalMoney = decorPrice + totalPriceForClotches;
            double neededMoney = totalMoney - budget;
            double moneyLeft = budget - totalMoney;

            if (totalMoney > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");

            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");


            }



        }
    }
}
