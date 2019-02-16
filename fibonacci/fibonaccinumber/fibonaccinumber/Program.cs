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

            return fib(N - 2) + fib(N - 1);
        }


    }
}
