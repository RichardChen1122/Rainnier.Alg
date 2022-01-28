using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode643
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            if(nums == null || nums.Length==0 || k > nums.Length)
            {
                return 0;
            }

            int left = 0;
            int max=0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < k)
                {
                    sum += nums[i];
                    max = sum;
                }
                else
                {
                    sum = sum+ nums[i]-nums[left];
                    left++;
                    if (sum > max)
                    {
                        max = sum;
                    }
                }
            }

            double a = (double)max / k;
            return a;
        }
    }
}
