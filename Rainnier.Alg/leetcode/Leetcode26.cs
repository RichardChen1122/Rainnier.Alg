using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums == null || nums.Length == 0)
            {
                return 0;
            }
            var length = nums.Length;

            var index = 0;
            var current = nums[0];

            for (int i = 1; i < length; i++)
            {
                if (nums[i] == current)
                {
                    continue;
                }
                else
                {
                    current = nums[i];
                    nums[++index] = current;
                }
            }

            return ++index;
        }
    }
}
