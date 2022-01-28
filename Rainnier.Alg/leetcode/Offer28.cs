using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    internal class Offer28
    {
        public bool IsSymmetric(TreeNode root)
        {
            return IsSymmetric(root, root);

        }

        private bool IsSymmetric(TreeNode pLeft, TreeNode pRight)
        {
            if (pLeft == null && pRight == null)
            {
                return true;
            }

            if (pLeft == null || pRight == null)
            {
                return false;
            }

            return pLeft.val == pRight.val && IsSymmetric(pLeft.left, pRight.right) && IsSymmetric(pLeft.right, pRight.left);
        }
    }
}
