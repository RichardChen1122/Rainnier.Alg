using System;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode209
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            if(nums==null|| nums.Length == 0)
            {
                return 0;
            }
            int length = nums.Length;

            int left = 0;
            int right = 0;

            int sum = 0;
            int minLength = int.MaxValue;

            while(right < length)
            {
                sum += nums[right];
                if(sum < target)
                {
                    right++;
                    continue;
                }
                else
                {
                    minLength = Math.Min(minLength, right-left+1);
                    while (left < right)
                    {
                        sum -= nums[left];
                        left++;
                        if (sum < target)
                        {
                            break;
                        }
                        minLength = Math.Min(minLength, right-left+1);
                        
                    }
                    right++;
                }
            }

            return minLength==int.MaxValue? 0: minLength;
        }

    }
}
