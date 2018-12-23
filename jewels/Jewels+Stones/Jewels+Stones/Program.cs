using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
//            string J = "aA";
//            string S = "aAAbbbb";
            string J = "z";
            string S = "ZZ";

            Console.WriteLine(NumJewelsInStones(J, S));
        }

        static int NumJewelsInStones(string J, string S)
        {
            int count = 0;
            foreach(char c in S)
            {
                if (J.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
