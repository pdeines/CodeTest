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
            int[] input3 = new int[] {-1};
            int[] input4 = new int[] {-1,1};
            int[] input5 = new int[] {-1,2,2};
            int[] input6 = new int[] {0, 2};
            int[] output;

            output = SortedSquares(input6);

            foreach (int i in output)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] SortedSquares(int[] A)
        {
            int inflectionPoint = FindInflection(A);
            int left = inflectionPoint;
            int right = inflectionPoint;
            int[] output = new int[A.Length];

            if (inflectionPoint != 0)
            {
                left--;
                right = inflectionPoint;
            }
            else
            {
                left = inflectionPoint;
                if (A.Length > 1)
                {
                    right = inflectionPoint + 1;
                }
                else
                {
                    right = 0;
                }
                
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (left < 0)
                {
                    output[i] = A[right] * A[right];
                    right++;
                    continue;
                }
                if (right > A.Length - 1)
                {
                    output[i] = A[left] * A[left];
                    left--;
                    continue;
                }
                if(Math.Abs(A[right]) <= Math.Abs(A[left]))
                {
                    output[i] = A[right] * A[right];
                    right++;
                    continue;
                }
                else
                {
                    output[i] = A[left] * A[left];
                    left--;
                    continue;
                }
            }

            return output;
        }

        private static int FindInflection(int[] intArray)
        {
            if (intArray[0] >= 0)
            {
                return 0;
            }
            else
            {
                int i = 0;
                while(intArray[i] < 0)
                {
                    i++;
                    if (i == intArray.Length)
                    {
                        return 0;
                    }
                }

                return i;
            }
        }
    }

}
