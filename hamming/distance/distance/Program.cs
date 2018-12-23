using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HammingDistance(1, 4));

        }

        public static int HammingDistance(int x, int y)
        {
            int count = 0;

            int diff = x ^ y;
            while(diff > 0)
            {
                if((diff & 1) == 1)
                {
                    count++;
                }
                diff >>= 1;
            }
            return count;
        }

    }
}
