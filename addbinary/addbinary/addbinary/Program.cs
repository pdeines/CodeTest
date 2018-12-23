using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addbinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddBinary("10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101", "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011"));
        }

        public static string AddBinary(string a, string b)
        {
            string result = ""; // Initialize result 
            int s = 0;          // Initialize digit sum 

            // Travers both strings starting from last characters 
            int i = a.Length - 1;
            int j = b.Length - 1;
            while (i >= 0 || j >= 0 || s == 1)
            {
                // Comput sum of last digits and carry 
                if(i >= 0)
                {
                    s += a[i] - '0';
                }
                else
                {
                    s += 0;
                }
                if (j >= 0)
                {
                    s += b[j] - '0';
                }
                else
                {
                    s += 0;
                }

                // If current digit sum is 1 or 3, add 1 to result 
                result = (char)(s % 2 + '0') + result;

                // Compute carry 
                s /= 2;

                // Move to next digits 
                i--;
                j--;
            }
            return result;

        }
    }
}
