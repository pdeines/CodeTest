using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "gin", "zen", "gig", "msg" };
            Console.WriteLine(UniqueMorseRepresentations(words));

        }

        public static int UniqueMorseRepresentations(string[] words)
        {
            int count = 0;
            string[] morseDefintions = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string[] morseConversion = new string[words.Length];

            for(int i = 0; i < words.Length; i++)
            {
                morseConversion[i] = "";
                string lowerCase = words[i].ToLower();
                foreach(char c in lowerCase)
                {
                    int asciiValue = (int)c;
                    int arrayIndex = c - 97;
                    morseConversion[i] += morseDefintions[arrayIndex];
                }
            }

            var unique = morseConversion.Distinct();

            return unique.Count();
            
            
        }
    }
}
