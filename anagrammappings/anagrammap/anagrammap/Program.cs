using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagrammap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {12,28,46,32,50};
            int[] b = new int[] {50,12,32,46,28};

            int[] p = AnagramMappings(a, b);
            foreach (int x in p)
            {
                Console.WriteLine(x);
            }
        }

        static public int[] AnagramMappings(int[] A, int[] B)
        {
            int[] p = new int[A.Length];
            for(int i = 0; i < A.Length; i++)
            {
                p[i] = Array.IndexOf(B, A[i]);
            }

            return p;
        }
    }
}
