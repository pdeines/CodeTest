using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 1, 2, 4 };
            int[] sorted = SortArrayByParity(numbers);

            foreach(int i in sorted)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] SortArrayByParity(int[] A)
        {
            int[] sorted = new int[A.Length];
            int front = 0;
            int back = A.Length - 1;


            foreach (int i in A)
            {
                if (i % 2 == 0)
                {
                    sorted[front] = i;
                    front++;
                }
                else
                {
                    sorted[back] = i;
                    back--;
                }
            }

            return sorted;
        }

    }
}
