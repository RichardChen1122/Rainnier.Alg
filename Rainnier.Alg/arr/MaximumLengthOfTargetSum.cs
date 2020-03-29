using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.arr
{
    class MaximumLengthOfTargetSum
    {
        public static int Solve(int[] arr, int target)
        {
            int sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            int maxLength = 0;
            map.Add(0, -1);

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if(map.TryGetValue(sum-target, out int val))
                {
                    maxLength = Math.Max(maxLength, i - val);
                }

                if (!map.ContainsKey(sum)) 
                {
                    map.Add(sum, i);
                }
            }

            return maxLength;
        }
    }
}
