using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testarray = new int[] { 1, 4, 3, 2 };
            Console.WriteLine(ArrayPairSum(testarray));
        }

        public static int ArrayPairSum(int[] nums)
        {
            int sum = 0;
            Array.Sort(nums);
            for(int i = 0; i<nums.Length; i += 2)
            {
                sum += nums[i];
            }

            return sum;

        }
    }
}
