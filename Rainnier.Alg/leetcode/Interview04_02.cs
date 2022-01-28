using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Interview04_02
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }

            var ret = BuildTree(nums, 0, nums.Length-1);

            return ret;
        }

        public TreeNode BuildTree(int[] nums, int left, int right)
        {
            if(left>right || left ==nums.Length || right ==-1)
            {
                return null;
            }

            var mid = left + (right - left) / 2;

            TreeNode root = new TreeNode(mid);

            root.left = BuildTree(nums, left, mid - 1);
            root.right = BuildTree(nums, mid + 1, right);

            return root;

        }
    }
}
