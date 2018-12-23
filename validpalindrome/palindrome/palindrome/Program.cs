using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
//            Console.WriteLine(ValidPalindrome("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga"));
            Console.WriteLine(ValidPalindrome("abca"));
//            Console.WriteLine(ValidPalindrome("abc"));
        }

        public static bool ValidPalindrome(string s)
        {
            if(s.Length <= 1)
            {
                return true;
            }
            if(s.Length == 2)
            {
                return true;
            }
            if (s[0] == s[s.Length-1])
            {
                return ValidPalindrome(s.Substring(1, s.Length - 2));
            }
            if((ValidPalindrome(s.Substring(1, s.Length - 1)) || ValidPalindrome(s.Substring(0,s.Length-1))) & (s.Length > 3))
            {
                return true;
            }
            return false;
        }

    }
}
