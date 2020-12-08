using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
//    给定一个无序的数组，找出数组在排序之后，相邻元素之间最大的差值。

//如果数组元素个数小于 2，则返回 0。
    public class Leetcode164
    {
        public int MaximumGap(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return 0;
            }

            int length = nums.Length;
            int max = nums.Max();

            int[] temp = new int[length];
            int[] container = new int[10];
            int exp = 1;
            while (max >= exp)
            {
                for (int i = 0; i < container.Length; i++)
                {
                    container[i] = 0;
                }
                for (int i = 0; i < length; i++)
                {
                    int lastNumber = (nums[i] / exp)%10;
                    container[lastNumber]++;
                }

                for (int i = 1; i < 10; i++)
                {
                    container[i] += container[i - 1];
                }

                for (int i = length-1; i >=0 ; i--)
                {
                    temp[container[(nums[i] / exp) % 10] - 1] = nums[i];
                    container[(nums[i] / exp) % 10]--;
                }

                temp.CopyTo(nums, 0);

                exp *= 10;

            }

            int result = 0;
            for (int i = 1; i < length; i++)
            {
                result = Math.Max(result, nums[i] - nums[i - 1]);
            }
            return result;
        }
    }
}
