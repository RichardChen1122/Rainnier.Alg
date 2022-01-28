using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode16_01
    {
        public int[] DivingBoard(int shorter, int longer, int k)
        {
            var result = new HashSet<int>();
            DivingBoard(shorter, longer, k, 0, new int[k], result);

            return result.ToArray();
        }

        public void DivingBoard(int shorter, int longer, int k, int level, int[] nums, ISet<int> set)
        {
            if (level == k)
            {
                int result = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    result += nums[i];
                }

                if (result!=0 && !set.Contains(result))
                {
                    set.Add(result);
                }

                return;
            }
            nums[level] = shorter;
            DivingBoard(shorter, longer, k, level + 1, nums, set);
            nums[level] = longer;
            DivingBoard(shorter, longer, k, level + 1, nums, set);
        }
    }
}
