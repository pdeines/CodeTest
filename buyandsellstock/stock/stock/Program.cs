using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 1, 5, 3, 6, 4 };
//            int[] array = new int[10];
            Console.WriteLine(MaxProfit(array));
        }

        public static int MaxProfit(int[] prices)
        {
            if(prices.Length < 1)
            {
                return 0;
            }

            // check if simple solution works
            int min = prices.Min();
            int max = prices.Max();
            int minLocation = Array.IndexOf(prices, min);
            int maxLocation = Array.IndexOf(prices, max);

            if(minLocation < maxLocation)
            {
                return max - min;
            }

            // brute force method
            int minsofar = max;
            int profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if(prices[i] < minsofar)
                {
                    minsofar = prices[i];
                }
                else if(prices[i] - minsofar > profit)
                {
                    profit = prices[i] - minsofar;
                }
 /*               for(int j = i + 1; j < prices.Length; j++)
                {
                    if((prices[j] - prices[i]) > profit)
                    {
                        profit = prices[j] - prices[i];
                    }
 
               }
 */
            }
            return profit;
        }
    }
}
