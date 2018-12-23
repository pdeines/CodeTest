using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverselist
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }

        public ListNode ReverseList(ListNode head)
        {
            if(head == null)
            {
                return null;
            }
            ListNode current = head;
            Stack<ListNode> stack = new Stack<ListNode>();
            while(current != null)
            {
                stack.Push(current);
                current = current.next;
            }

            ListNode newlistHead = new ListNode(stack.Pop().val);
            current = newlistHead;
            while(stack.Count != 0)
            {
                current.next = new ListNode(stack.Pop().val);
                current = current.next;
            }

            return newlistHead;
        }
    }
}
