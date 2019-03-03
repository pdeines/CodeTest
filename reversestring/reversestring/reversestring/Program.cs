using System;

namespace reversestring
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input1 = new[] {'h', 'e', 'l', 'l', 'o'};
            char[] input2 = new[] {'H', 'a', 'n', 'n', 'a', 'h'};

            ReverseString(input2);
            Console.WriteLine(input2);
        }

        public static void ReverseString(char[] s) 
        {
            if (s.Length <= 1)
            {
                return;
            }

            int frontIndex = 0;
            int backIndex = s.Length - 1;

            while (frontIndex < backIndex)
            {
                char temp = s[frontIndex];
                s[frontIndex] = s[backIndex];
                s[backIndex] = temp;
                frontIndex++;
                backIndex--;
            }
        }
    }
}
