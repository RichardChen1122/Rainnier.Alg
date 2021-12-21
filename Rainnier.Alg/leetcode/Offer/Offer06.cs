using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class Offer06
    {
        public int[] ReversePrint(ListNode head)
        {
            var stack = new Stack<int>();

            var current = head;

            while(current != null)
            {
                stack.Push(current.val);
                current = current.next;
            }

            return stack.ToArray();
        }
    }
}
