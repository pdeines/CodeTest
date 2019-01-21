using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace squaresssorted
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = new int[] {-4, -1, 0, 3, 10};
            int[] input2 = new int[] {-7, -3, 2, 3, 11};
            int[] output;

            output = SortedSquares(input2);

            foreach (int i in output)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] SortedSquares(int[] A)
        {
            int[] output = new int[A.Length];
            for(int i = 0; i < A.Length; i++)
            {
                output[i] = A[i] * A[i];
            }
            Array.Sort(output);
            return output;
        }
    }
}
