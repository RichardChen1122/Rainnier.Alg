using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class Offer45
    {
        public string MinNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0) { return "0"; }

            Array.Sort(nums, (a, b) => { 
                return (a.ToString() + b.ToString()).CompareTo(b.ToString() + a.ToString()); 
            });
            var ret = new StringBuilder();
            for (int i = 0; i < nums.Length; i++)
            {
                ret.Append(nums[i]);
            }

            return ret.ToString();
        }

        public string MinNumber2(int[] nums)
        {
            if (nums == null || nums.Length == 0) { return "0"; }

            QuickSort(nums, 0, nums.Length - 1);

            var ret = new StringBuilder();
            for (int i = 0; i < nums.Length; i++)
            {
                ret.Append(nums[i]);
            }

            return ret.ToString();
        }

        public void QuickSort(int[] nums, int start, int end)
        {
            if (start < end)
            {
                int ret = QuickSortHelp(nums, start, end);
                QuickSort(nums, start, ret - 1);
                QuickSort(nums, ret + 1, end);
            }
        }

        private int QuickSortHelp(int[] nums, int start, int end)
        {
            var num = nums[start];
            var left = start;
            var right = end;

            while (left < right)
            {
                while(left<right&& nums[right] > num)
                {
                    right--;
                }
                nums[left] = nums[right];
                while (left < right && nums[left] <= num)
                {
                    left++;
                }
                nums[right] = nums[left];
            }

            nums[left] = num;

            return left;
        }
    }
}
