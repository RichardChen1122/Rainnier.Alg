using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class TreeNode
    {

        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }


    public class Offer54
    {

        public int KthLargest(TreeNode root, int k)
        {
            if (root == null)
            {
                return -1;
            }
            int count = 0;
            var stack = new Stack<TreeNode>();

            var current = root;
            while(current != null)
            {
                stack.Push(current);
                current = current.right;
                while(current == null && stack.Count > 0)
                {
                    count++;
                    var result = stack.Pop();
                    current = result.left;
                    if(count == k)
                    {
                        return result.val;
                    }
                }
            }

            return -1;
        }
    }
}
