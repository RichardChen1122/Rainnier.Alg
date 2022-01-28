using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode747
    {
        public int DominantIndex(int[] nums)
        {
            if(nums == null || nums.Length == 0)
            {
                return -1;
            }

            if(nums.Length == 1)
            {
                return 0;
            }

            int max = 0;
            int second = -1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[max])
                {
                    second = max;
                    max = i;
                }
                else if (second == -1 || nums[i] > nums[second])
                {
                    second = i;
                }
            }

            if (nums[max] >>1  >= nums[second])
            {
                return max;
            }

            return -1;
        }
    }
}
