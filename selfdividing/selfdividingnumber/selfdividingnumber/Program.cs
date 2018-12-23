using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfdividingnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> result = SelfDividingNumbers(1, 22);
            foreach(int numb in result)
            {
                Console.WriteLine(numb);
            }
        }

        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> theList = new List<int>();
            for(int i = left; i <= right; i++)
            {
                string numberAsText = i.ToString();
                if(numberAsText.Contains("0") == false)
                {
                    int divisible = 1;
                    for(int index = 0; index < numberAsText.Length; index++)
                    {
                        if (i % Convert.ToInt32(numberAsText.Substring(index, 1)) != 0)
                        {
                            divisible = 0;
                        }
                    }
                    if (divisible != 0)
                    {
                        theList.Add(i);
                    }
                }
            }
            return theList;
        }
    }
}
