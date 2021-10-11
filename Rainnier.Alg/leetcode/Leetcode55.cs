using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode55
    {
        public bool CanJump(int[] nums)
        {
            var length = nums.Length;
            var dp = new bool[length];

            var position = length - 1;

            for (int i = length-2; i >=0; i--)
            {
                if(nums[i]+i>= position)
                {
                    position = i;
                }
            }

            return position == 0;
        }

        public bool CanJump_2(int[] nums)
        {
            var fareast = nums[0];
            var length = nums.Length;
            int i = 1;

            for (; i <length && i < fareast;i++)
            {
                if (nums[i] + i > fareast)
                {
                    fareast = nums[i] + i;
                }
            }

            return fareast >= length-1;
        }

        public int JumpStep(int[] nums)
        {
            int length = nums.Length;
            var dp = new int[length];

            for (int i = 0; i < length; i++)
            {
                dp[i] = int.MaxValue;
            }
            dp[0] = 0;

            for (int i = 0; i < length; i++)
            {
                for(int k = 1;k<= nums[i]; k++)
                {
                    if (i + k < length)
                    {
                        dp[i + k] = Math.Min(dp[i] + 1, dp[i + k]);
                    }
                }
            }

            return dp[length - 1];
        }
    }
}
