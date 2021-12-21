using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class Offer03
    {
        public int FindRepeatNumber(int[] nums)
        {
            int index = 0;
            while(index < nums.Length)
            {
                int current = nums[index];
                if (current == index)
                {
                    index++;
                    continue;
                }
                else
                {
                    if (nums[current] == current)
                    {
                        return current;
                    }
                    else
                    {
                        var temp = nums[current];
                        nums[current] = current;
                        nums[index] = temp;
                    }
                }
            }

            return -1;
        }
    }
}
