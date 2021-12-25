using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class Offer33
    {
        //输入一个整数数组，判断该数组是不是某二叉搜索树的后序遍历结果。如果是则返回 true，否则返回 false。假设输入的数组的任意两个数字都互不相同。
        public bool VerifyPostorder(int[] postorder)
        {
            if(postorder == null|| postorder.Length == 0)
            {
                return false;
            }
            var length = postorder.Length;
            var midOrder = postorder.Clone() as int[];
            Array.Sort(midOrder);

            var root = postorder[length - 1];

            return VerifyPostOrder(postorder, midOrder, root, 0, length - 1, 0, length - 1);
        }

        public bool VerifyPostOrder(int[] postorder, int[] midOrder, int root, int postStart, int postEnd, int midStart, int midEnd)
        {
            if (midStart == midEnd)
            {
                return true;
            }

            int index = 0;
            while(midOrder[index] != root)
            {
                index++;
            }

            var gap = index - midStart;
            bool leftValid = true;
            bool rightValid = true;
            if(gap > 0)
            {
                if(root < postorder[postStart + gap - 1])
                {
                    return false;
                }
                leftValid = VerifyPostOrder(postorder, midOrder, postorder[postStart + gap - 1], postStart, postStart + gap - 1, midStart, midStart + gap - 1);
            }

            if (index < midEnd)
            {
                if(root > postorder[postEnd - 1])
                {
                    return false;
                }
                rightValid = VerifyPostOrder(postorder, midOrder, postorder[postEnd - 1], postStart+ gap, postEnd - 1, index+1, midEnd);
            }


            return leftValid && rightValid; 
        }
    }
}
