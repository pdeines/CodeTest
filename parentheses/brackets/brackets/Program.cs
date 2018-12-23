using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brackets
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool IsValid(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return true;
            }

            Stack<char> stack = new Stack<char>();
            foreach(char c in s)
            {
                switch (c)
                {
                    case '(':
                        stack.Push(c);
                        break;
                    case '{':
                        stack.Push(c);
                        break;
                    case '[':
                        stack.Push(c);
                        break;
                    case ')':
                        if(stack.Count == 0)
                        {
                            return false;
                        }
                        if(stack.Pop() != '(')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (stack.Count == 0)
                        {
                            return false;
                        }
                        if (stack.Pop() != '{')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (stack.Count == 0)
                        {
                            return false;
                        }
                        if (stack.Pop() != '[')
                        {
                            return false;
                        }
                        break;
                }
            }
            if(stack.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}
