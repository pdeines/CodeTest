using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productofarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = new[] {1, 2, 3, 4};
            int[] output = ProductExceptSelf(input1);

            foreach (int i in output)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int sizeOfArray = nums.Length;
            int productFromStart = 1;
            int productFromEnd = 1;
            int[] output = new int[sizeOfArray];

            // Initialize the array to 1 instead of 0 as default value
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = 1;
            }
            
            for (int index = 0; index < sizeOfArray; index++)
            {
                output[index] *= productFromStart;
                productFromStart *= nums[index];
                output[sizeOfArray - 1 - index] *= productFromEnd;
                productFromEnd *= nums[sizeOfArray - 1 - index];
            }

            return output;
        }
    }
}
