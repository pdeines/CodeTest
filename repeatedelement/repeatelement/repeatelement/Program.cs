using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeatelement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = new int[] {1,2,3,3};
            int[] input2 = new int[] {2,1,2,5,3,2};

            int output = RepeatedNTimes(input2);
            Console.WriteLine(output);
        }

        public static int RepeatedNTimes(int[] A)
        {
            Dictionary<int,int> map = new Dictionary<int, int>();

            foreach (int i in A)
            {
                if (map.ContainsKey(i))
                {
                    return i;
                }
                else
                {
                    map.Add(i,i);
                }
            }

            return -1;
        }
    }
}
