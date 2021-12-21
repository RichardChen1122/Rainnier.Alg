using Rainnier.Alg.tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode206
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;

        }
    }
    public class Leetcode206
    {
        public ListNode ReverseList(ListNode head)
        {

            if(head == null)
            {
                return head;
            }
            var dummyNode = new ListNode(-1, head);

            var current = head;
            ListNode next = null;

            while (current.next != null)
            {
                next = current.next;
                current.next = next.next;
                next.next = dummyNode.next;
                dummyNode.next = next;
            }
            var result = dummyNode.next;
            dummyNode.next=null;
            return result;
        }
    }
}
