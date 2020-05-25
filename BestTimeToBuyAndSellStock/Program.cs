using System;

namespace BestTimeToBuyAndSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] inputArr = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(inputArr));
        }
        public static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            var maximumValue = 0;
            var currentValue = prices[0];
            for (int i = 1 ; i < prices.Length; i++)
            {
                if (prices[i]<currentValue)
                {
                    currentValue = prices[i];
                }
                else
                {
                    maximumValue = Math.Max(maximumValue, prices[i] - currentValue);
                }
            }
            return maximumValue;
        }

    }
}

