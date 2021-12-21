using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            if(nums==null|| nums.Length == 0)
            {
                return Array.Empty<int>();
            }

            var length = nums.Length;

            var result = new int[length];

            var preProduct = new int[length];

            var postProduct = 1;

            preProduct[0] = 1;

            for(int i = 1; i < length; i++)
            {
                preProduct[i] = preProduct[i - 1] * nums[i - 1];
            }

            for(int i = length-1; i >=0; i--)
            {
                result[i] = preProduct[i] * postProduct;
                postProduct *= nums[i];
            }

            return result;
        }
    }
}
