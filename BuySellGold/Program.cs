using System;
using System.Collections;

namespace BuySellGold
{
    internal class Program
    {
        private static readonly int[] goldPrices = {7000, 10, 8, 32, 55, 3, 6000, 34, 23, 12, 110, 44, 101, 32, 5000, 7, 100, 22};

        private int buyDay = 0;
        private int sellDay = 0;

        private int highestPrice = 0;
        private int lowestPrice = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Program starting...");

            var program = new Program();
            program.GetBuyDay();
            program.GetSellDay();

            Console.WriteLine("Program ending...");
        }

        private void GetBuyDay()
        {
            for (int i = 0; i < goldPrices.Length; i++)
            {
                if (i == 0)
                {
                    lowestPrice = goldPrices[i];
                    buyDay = i;
                }
                else
                {
                    if (lowestPrice > goldPrices[i])
                    {
                        lowestPrice = goldPrices[i];
                        buyDay = i;
                    }
                }
            }

            Console.WriteLine($"Looks like it's best to buy gold on day {buyDay} for {lowestPrice} gold");
            Console.WriteLine("-------------------");
        }

        private void GetSellDay()
        {
            for (var i = buyDay; i < goldPrices.Length; i++)
            {
                if (highestPrice < goldPrices[i])
                {
                    highestPrice = goldPrices[i];
                    sellDay = i;
                }
            }

            Console.WriteLine($"Looks like it's best to sell gold on day {sellDay} for {highestPrice} gold profiting a total of {highestPrice - lowestPrice}");
            Console.WriteLine("-------------------");
        }
    }
}