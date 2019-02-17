using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace flowerplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = new[] {1, 0, 0, 0, 1};
            int[] input2 = new[] {1, 0, 0, 0, 0, 1};
            int[] input3 = new[] {1, 0, 1, 0, 1, 0, 1};
            int[] input4 = new[] {1, 0, 0, 0, 0};
            int n = 2;

            bool output = CanPlaceFlowers(input4, n);

            Console.WriteLine(output);
        }

        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int flowersPlaced = 0;
            int index = 0;

            while (index < flowerbed.Length)
            {
                if (flowerbed[index] == 0 && (index == 0 || flowerbed[index - 1] == 0) &&
                    (index == flowerbed.Length - 1 || flowerbed[index + 1] == 0))
                {
                    flowerbed[index] = 1;
                    flowersPlaced++;
                }

                index++;
            }

            if (flowersPlaced >= n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
