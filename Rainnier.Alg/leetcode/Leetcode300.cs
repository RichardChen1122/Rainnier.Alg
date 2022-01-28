using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    /// <summary>
    /// 最长递增子序列
    /// </summary>
    public class Leetcode300
    {
        public int LengthOfLIS(int[] nums)
        {
            var length = nums.Length;
            int[] dp = new int[length];

            for (int i = 0; i < length; i++)
            {
                dp[i] = int.MaxValue;
            }

            dp[0] = 1;

            var ret = dp[0];

            for (int i = 1; i < length; i++)
            {
                var res = 1;
                for (int j = 0; j < i; j++)
                {
                    if(nums[j] < nums[i])
                    {
                        res = Math.Max(res, dp[j] + 1);
                    }
                }

                dp[i] = res;
                ret = Math.Max(ret, dp[i]);
            }

            return ret;
        }

        public int LengthOfLIS2(int[] nums)
        {
            var length = nums.Length;
            int[] dp = new int[length+1];
            var end = 1;
            dp[1] = nums[0];



            for (int i = 1; i < length; i++)
            {
                var pos = FindPosition(dp, nums[i], end);

                if (pos < end)
                {
                    dp[pos + 1] = Math.Min(nums[i], dp[pos + 1]);
                }
                else
                {
                    dp[pos + 1] = nums[i];
                    end++;
                }
            }

            return end ;
        }

        public int FindPosition(int[] dp, int target, int end)
        {
            var left = 1;
            var right = end;
            var pos = 0;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (dp[mid] < target)
                {
                    pos = mid;
                    left = mid + 1;
                }

                else
                {
                    right = mid - 1;
                }
            }

            return pos;
        }
    }
}
