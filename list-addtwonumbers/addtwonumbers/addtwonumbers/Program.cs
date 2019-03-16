using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addtwonumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(2);
            list1.Add(4);
            list1.Add(3);
            List<int> list2 = new List<int>();
            list2.Add(5);
            list2.Add(6);
            list2.Add(4);

            List<int> output = AddTwoNumbers(list1, list2);

            foreach (int i in output)
            {
                Console.WriteLine(i);
            }


        }

        public static List<int> AddTwoNumbers(List<int> l1, List<int> l2)
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            List<int> listSum = new List<int>();

            foreach (var i in l1)
            {
                stack1.Push(i);
            }

            foreach (var i in l2)
            {
                stack2.Push(i);
            }

            while (stack1.Count > 0)
            {
                listSum.Add(stack1.Pop() + stack2.Pop());
            }

            return listSum;
        }


    }
}
