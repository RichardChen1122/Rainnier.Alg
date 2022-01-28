using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode47
    {
        //全排列2
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums==null|| nums.Length == 0)
            {
                return result;

            }

            Array.Sort(nums);

            var length = nums.Length;
            var path = new List<int>();

            var used = new bool[length];
            BackTrack(nums, length, 0, result, path, used);
            return result;
        }

        public void BackTrack(int[] nums, int length, int depth, IList<IList<int>> result, IList<int> path, bool[] used)
        {
            if (length == depth)
            {
                result.Add(new List<int>(path));
            }

            for (int i = 0; i < length; i++)
            {
                if (used[i] || (i > 0 && nums[i] == nums[i - 1] && !used[i - 1]))
                {
                    continue;
                }

                if (!used[i])
                {
                    used[i] = true;
                    path.Add(nums[i]);
                    BackTrack(nums, length, depth + 1, result, path, used);
                    path.RemoveAt(path.Count - 1);
                    used[i] = false;
                }
                
            }
        }
    }
}
