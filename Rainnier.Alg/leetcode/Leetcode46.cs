using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode46
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            var length = nums.Length;

            if (length == 0)
            {
                return result;
            }
            List<int> path = new List<int>();
            bool[] used = new bool[length];
            var depth = 0;

            BackTrack(nums, length, depth, path, used, result);

            return result;
        }

        private void BackTrack(int[] nums, int length, int depth, List<int> path, bool[] used, IList<IList<int>> result)
        {
            if(depth== length)
            {
                result.Add(new List<int>(path));

                return;
            }

            

            for (int i = 0; i < length; i++)
            {
                if (used[i])
                {
                    continue;
                }

                path.Add(nums[i]);
                used[i] = true;
                BackTrack(nums, length, depth + 1, path, used, result);
                path.RemoveAt(path.Count - 1);
                used[i] = false;

            }
        }

        public IList<IList<int>> Permute_2(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            var length = nums.Length;

            if (length == 0)
            {
                return result;
            }
            List<int> path = new List<int>(nums);


            BackTrack_2(length, result, 0, path);

            return result;
        }

        private void BackTrack_2( int length, IList<IList<int>> result, int first, IList<int> path)
        {
            if (first == length)
            {
                result.Add(new List<int>(path));

                return;
            }

            for (int i = first; i < length; i++)
            {
                Swap(path, first, i);
                BackTrack_2(length, result, first + 1, path);
                Swap(path, first, i);
            }
            
        }

        private void Swap(IList<int> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
