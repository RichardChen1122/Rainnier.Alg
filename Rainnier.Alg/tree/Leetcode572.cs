using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }


    public class Leetcode572
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (t == null)
            {
                return true;
            }

            if (s == null)
            {
                return false;
            }
            if (IsSameTree(s, t))
            {
                return true;
            }
            else
            {
                return IsSubtree(s.left, t) || IsSubtree(s.right, t);
            }

        }

        public bool IsSameTree(TreeNode st, TreeNode tt)
        {
            if(st ==null && tt == null)
            {
                return true;
            }
            else if(st!=null && tt != null)
            {
                if (st.val != tt.val)
                {
                    return false;
                }
                bool left = IsSameTree(st.left, tt.left);
                bool right = IsSameTree(st.right, tt.right);
                return left && right;
                
            }
            else
            {
                return false;
            }
            
        }
    }
}
