using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraybyparityII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = new int[] {4,2,5,7};
            int[] input2 = new int[] {1,2,3,4};

            int[] output = SortArrayByParityII(input1);

            foreach (int i in output)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] SortArrayByParityII(int[] A)
        {
            int[] output = new int[A.Length];
            int oddPointer = 1;
            int evenPointer = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    output[evenPointer] = A[i];
                    evenPointer += 2;
                }
                else
                {
                    output[oddPointer] = A[i];
                    oddPointer += 2;
                }
            }

            return output;
        }
    }
}
