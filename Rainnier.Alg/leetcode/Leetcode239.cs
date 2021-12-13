using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode239
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int resultCount = 0;
            if(nums ==null || nums.Length ==0)
            {
                return null;
            }

            if (k > nums.Length)
            {
                resultCount = 1;
            }
            else
            {
                resultCount = nums.Length - k + 1;
            }

            var result = new int[resultCount];

            var linkList = new LinkedList<int>();


            int i = 0;
            for (; i < k && i < nums.Length; i++)
            {

                while (linkList.Count > 0 && linkList.Last.Value < nums[i])
                {
                    linkList.RemoveLast();

                }
                linkList.AddLast(nums[i]);
            }

            result[0] = linkList.First();

            if (i == nums.Length)
            {
                return result;
            }

            
            for (int t=1; i < nums.Length; i++, t++)
            {
                if (nums[i - k ] == linkList.First.Value)
                {
                    linkList.RemoveFirst();
                }
                while (linkList.Count > 0 && linkList.Last.Value < nums[i])
                {
                    linkList.RemoveLast();
                }
                linkList.AddLast(nums[i]);

                result[t] = linkList.First();
            }



            return result;
        }
    }
}
