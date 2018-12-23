using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    class Program
    {
        static void Main(string[] args)
        {
            string moves = "UD";
            Console.WriteLine(JudgeCircle(moves));
        }

        public static bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;
            foreach(char c in moves)
            {
                switch(c)
                {
                    case 'U':
                        y++;
                        break;
                    case 'D':
                        y--;
                        break;
                    case 'L':
                        x--;
                        break;
                    case 'R':
                        x++;
                        break;
                    default:
                        break;
                }
            }
            if(x == 0 & y == 0)
            {
                return true;
            }
            return false;
        }

    }
}
