using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    internal class Offer22
    {
        //这种方式只能证明有环
        public ListNode DetectCycle(ListNode head)
        {
            if(head == null) { return null; }
            var currentFast = head;
            var currentSlow = head;

            do
            {
                currentSlow = currentSlow.next;
                if (currentFast.next != null)
                {
                    currentFast = currentFast.next.next;
                }
                else
                {
                    currentFast = null;
                }
            }
            while (currentFast != null && currentFast != currentSlow);

            return currentFast;
        }

        //确定有环了以后, 计算出环的大小, 然后有寻找倒数K个节点类似的办法找到入口
        public ListNode DetectCycleAndEntryPoint(ListNode head)
        {
            if (head == null) { return null; }
            var currentFast = head;
            var currentSlow = head;

            do
            {
                currentSlow = currentSlow.next;
                if (currentFast.next != null)
                {
                    currentFast = currentFast.next.next;
                }
                else
                {
                    currentFast = null;
                }
            }
            while (currentFast != null && currentFast != currentSlow);

            if(currentFast == null) { return null; }

            var current = currentFast;

            int loopSize = 0;
            do
            {
                current = current.next;
                loopSize++;
            }
            while (current != currentFast);

            var pEnd = head;
            var pStart = head;

            for (int i = 0; i < loopSize; i++)
            {
                pEnd = pEnd.next;
            }

            while (pEnd != pStart)
            {
                pStart = pStart.next;
                pEnd = pEnd.next;
            }

            return pStart;
        }
    }
}
