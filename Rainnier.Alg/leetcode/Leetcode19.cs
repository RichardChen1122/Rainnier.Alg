using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if(head == null)
            {
                return null;
            }
            var dummyNode = new ListNode(-1, null);

            dummyNode.next = head;

            var currentTail = dummyNode;
            var currentHead = dummyNode;

            for (int i = 0; i < n; i++)
            {
                if (currentTail == null)
                {
                    return head;
                }
                currentTail = currentTail.next;
            }

            while (currentTail.next != null)
            {
                currentHead = currentHead.next;
                currentTail = currentTail.next;
            }

            currentHead.next = currentHead.next.next;


            return dummyNode.next;
        }
    }
}
