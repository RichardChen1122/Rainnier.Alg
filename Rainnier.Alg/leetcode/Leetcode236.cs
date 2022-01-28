using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode236
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if(root == null)
            {
                return null;
            }

            if(root == p || root ==q)
            {
                return root;
            }

            var left = LowestCommonAncestor(root.left,  p,  q);
            var right = LowestCommonAncestor(root.right,  p,  q);

            if (left != null && right != null)
            {
                return root;
            }

            if(left==null && right == null)
            {
                return null;
            }

            return left == null ? right : left;
        }

        public TreeNode LowestCommonAncestor2(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }

            var stackA = new Stack<TreeNode>();
            var stackB = new Stack<TreeNode>();

            _ = NodeSearch(root, stackA, p);
            _ = NodeSearch(root, stackB, q);

            TreeNode result = null;

            while (stackA.Count>0 && stackB.Count>0)
            {
                var peekA = stackA.Pop();
                var peekB = stackB.Pop();

                if(peekA == peekB)
                {
                    result = peekA;
                }
            }

            return result;
        }

        public bool NodeSearch(TreeNode root, Stack<TreeNode> stack, TreeNode searchNode)
        {
            if (root == null)
            {
                return false;
            }

            //#1放这里也可以

            var left = NodeSearch(root.left, stack, searchNode);
            var right = NodeSearch(root.right, stack, searchNode);

            //这段代码#1放上面也可以--------------
            if (root == searchNode)
            {
                stack.Push(root);
                return true;
            }
            //-----------------------------------

            if (left || right)
            {
                stack.Push(root);
                return true;
            }
            return false;
        }
    }
}
