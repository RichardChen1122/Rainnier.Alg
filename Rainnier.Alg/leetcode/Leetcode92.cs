using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode

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

    public class Leetcode92
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            // 设置 dummyNode 是这一类问题的一般做法
            ListNode dummyNode = new ListNode(-1);
            dummyNode.next = head;
            ListNode pre = dummyNode;
            for (int i = 0; i < left - 1; i++)
            {
                pre = pre.next;
            }
            ListNode cur = pre.next;
            ListNode next;
            for (int i = 0; i < right - left; i++)
            {
                next = cur.next;
                cur.next = next.next;
                next.next = pre.next;
                pre.next = next;
            }
            return dummyNode.next;
        }

        public ListNode ReverseBetween2(ListNode head, int left, int right)
        {
            var current = 1;
            var node = head;
            var stack = new Stack<ListNode>();

            ListNode previous = null;
            while (current < left)
            {
                current++;
                previous = node;
                node = node.next;
            }

            while(current <= right)
            {
                current++;
                stack.Push(node);
                node = node.next;
            }

            while(stack.Count > 0)
            {
                var peek = stack.Pop();
                if (previous != null)
                {
                    previous.next = peek;
                }
                else
                {
                    head = peek;
                }
                previous = peek;
            }

            previous.next = node;

            return head;
        }
    }
}
