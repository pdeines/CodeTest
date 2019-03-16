using System;
using System.Text;

namespace commonprefix
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] input1 = new[] {"flower", "flow", "flight"};
            String[] input2 = new[] {"dog", "racecar", "car"};

            String output = LongestCommonPrefix(input1);

            Console.WriteLine(output);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            var common = new StringBuilder();

            int letterIndex = 0;
            String testWord = strs[0];
            bool checkFailed = false;
            while (letterIndex < testWord.Length)
            {
                Char testChar = testWord[letterIndex];
                foreach (string str in strs)
                {
                    if (letterIndex >= str.Length || str[letterIndex] != testChar)
                    {
                        checkFailed = true;
                        break;
                    }
                }

                if (checkFailed)
                {
                    break;
                }

                letterIndex++;
                common.Append(testChar);
            }

            return common.ToString();
        }
    }
}
