using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findmountain
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 0 };
            Console.WriteLine(PeakIndexInMountainArray(array));
        }

        public static int PeakIndexInMountainArray(int[] A)
        {
            for(int i = 1; i < A.Length -1; i++)
            {
                if(A[i-1] < A[i] & A[i+1] < A[i])
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
