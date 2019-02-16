using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace fibonaccinumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fib(2));
            Console.WriteLine(fib(3));
            Console.WriteLine(fib(4));
            Console.WriteLine(fib(20));
        }

        static int fib(int N)
        {
            if (N == 0)
            {
                return 0;
            }

            if (N == 1)
            {
                return 1;
            }
            Dictionary<int,int> fibnumbers = new Dictionary<int, int>();
            fibnumbers.Add(0,0);
            fibnumbers.Add(1,1);
            for (int i = 2; i <= N; i++)
            {
                int tempsum = fibnumbers[i - 2] + fibnumbers[i - 1];
                fibnumbers.Add(i, tempsum);
            }

            return fibnumbers[N - 2] + fibnumbers[N - 1];
        }


    }
}
