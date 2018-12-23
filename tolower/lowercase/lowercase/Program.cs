using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerCase("Hello"));

        }

        public static string ToLowerCase(string str)
        {
            string newString = "";
            foreach (char c in str)
            {
                int asciichar = (int)c;
                if (asciichar > 64 & asciichar < 91)
                {
                    char lower = (char)(asciichar + 32);
                    newString += lower.ToString();
                }
                else
                {
                    newString += c;
                }
            }
            return newString;
        }
    }
}
