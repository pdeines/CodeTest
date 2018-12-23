using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayproduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 2, 3, 4 };
            int[] output = new int[4];
            output = ProductExceptSelf(input);
        }

        static public int[] ProductExceptSelf(int[] nums)
        {
            int[] output = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                output[i] = 1;

            }
        }
    }
}
