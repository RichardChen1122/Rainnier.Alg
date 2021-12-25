using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode160
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if(headA == null || headB == null)
            {
                return null;
            }

            var hashset = new HashSet<ListNode>();

            var currentA = headA;
            var currentB = headB;

            while(currentA != null)
            {
                hashset.Add(currentA);
                currentA = currentA.next;
            }

            while(currentB != null)
            {
                if (hashset.Contains(currentB))
                {
                    return currentB;
                }
                currentB = currentB.next;
            }

            return null;
        }

        public ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            var currentA = headA;
            var currentB = headB;

            while(currentA!=null && currentB != null)
            {
                if(currentA==null)
                {
                    currentA = headB;
                }
                else
                {
                    currentA= currentA.next;
                }
                if (currentB == null)
                {
                    currentB= headA;
                }
                else
                {
                    currentB = currentB.next;
                }
                if (currentA == currentB)
                {
                    return currentA;
                }
            }

            return null;
        }
    }
}
