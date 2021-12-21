using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode25
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if(head == null || k<=1)
            {
                return head;
            }

            var current = head;
            var count = 0;

            var dummy = new ListNode(-1, head);

            while(current != null)
            {
                current = current.next;
                count++;
            }

            var pre = dummy;
            int group = count / k;
            ListNode next = null;

            while(pre!=null)
            {
                var innerCurrent = pre;
                int innerCount=0;
                while(innerCurrent != null && innerCount < k)
                {
                    innerCurrent = innerCurrent.next;
                    innerCount++;
                }

                if(innerCurrent == null)
                {
                    break;
                }
                current = pre.next;
                for (int j = 0; j < k-1; j++)
                {
                    next= current.next;
                    current.next = next.next;
                    next.next = pre.next;
                    pre.next = next;
                }
                pre=current;
            }

            return dummy.next;
        }


    }
}
