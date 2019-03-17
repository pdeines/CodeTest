using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace maxsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};

            int output = MaxSubArray(input1);
            Console.WriteLine(output);
        }

        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return -1;
            }

            // Using Kadane's Algorithm
            int globalMax = nums[0];
            int localMax = nums[0];

            for (int index = 1; index < nums.Length; index++)
            {
                localMax = Math.Max(nums[index], localMax + nums[index]);
                if (localMax > globalMax)
                {
                    globalMax = localMax;
                }
            }
            return globalMax;
        }
    }
}
