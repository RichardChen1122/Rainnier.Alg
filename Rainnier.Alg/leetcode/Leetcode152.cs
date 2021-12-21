using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode152
    {
        public int MaxProduct(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int max = nums[0];
            int min = nums[0];
            int ret = max;
            int maxCur = max;
            int minCur = min;

            for (int i = 1; i < nums.Length; i++)
            {
                maxCur = max * nums[i];
                minCur = min * nums[i];
                max = Math.Max(Math.Max(maxCur, minCur), nums[i]);
                min = Math.Min(Math.Min(maxCur, minCur), nums[i]);
                ret = Math.Max(max, ret);
            }
            return ret;
        }
    }
}
