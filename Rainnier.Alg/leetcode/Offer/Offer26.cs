using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    //树的子结构
    public class Offer26
    {
        public bool IsSubStructure(TreeNode A, TreeNode B)
        {
            if(A == null && B != null)
            {
                return false;
            }

            if(B==null)
            {
                return true;
            }

            bool left;
            bool right;

            if (A.val == B.val && IsSub(A, B))
            {
                return true;
            }
            else
            {
                left = IsSubStructure(A.left, B);
                right = IsSubStructure(A.right, B);
                return left || right;
            }

            
        }

        public bool IsSub(TreeNode target, TreeNode B)
        {
            if(target == null && B != null)
            {
                return false;
            }

            if (B == null)
            {
                return true;
            }

            if(target.val != B.val)
            {
                return false;
            }

            var left = IsSub(target.left, B.left);
            var right = IsSub(target.right, B.right);

            return left && right;
        }

        public bool IsSubStructure2(TreeNode A, TreeNode B)
        {
            if (A == null && B != null)
            {
                return false;
            }

            if (B == null)
            {
                return true;
            }

            var stack = new Stack<TreeNode>();

            stack.Push(A);

            while(stack.Count > 0)
            {
                var cur = stack.Pop();

                if (cur.val == B.val && IsSub2(cur, B))
                {
                    return true;
                }

                if (cur.left != null)
                {
                    stack.Push(cur.left);
                }
                if (cur.right != null)
                {
                    stack.Push(cur.right);
                }
            }

            return false;
        }

        public bool IsSub2(TreeNode target, TreeNode B)
        {
            if (target == null && B != null)
            {
                return false;
            }

            if (B == null)
            {
                return true;
            }

            var stackA = new Stack<TreeNode>();
            var stackB = new Stack<TreeNode>();

            stackA.Push(target);
            stackB.Push(B);

            while(stackB.Count > 0)
            {
                if (stackA.Count == 0)
                {
                    return false;
                }

                var curA = stackA.Pop();
                var curB = stackB.Pop();

                if (curA.val != curB.val)
                {
                    return false;
                }
                else
                {
                    if(curB.left != null)
                    {
                        if (curA.left != null)
                        {
                            stackA.Push(curA.left);
                            stackB.Push(curB.left);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (curB.right != null)
                    {
                        if (curA.right != null)
                        {
                            stackA.Push(curA.right);
                            stackB.Push(curB.right);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
