using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    internal class Leetcode825
    {
        public int FriendRequest(int[] ages)
        {
            if(ages == null|| ages.Length == 0)
            {
                return 0;
            }

            var length = ages.Length;

            var count = new int[121];

            var sum = new int[121];

            int result = 0;

            for (int i = 0; i < length; i++)
            {
                count[ages[i]]++;
            }

            for (int i = 1; i < 121; i++)
            {
                sum[i] = sum[i - 1] + count[i];
            }

            for (int i = 15; i < 121; i++)
            {
                result += count[i] * (sum[i] - sum[i / 2 + 7] - 1);
                    }

            return result;
        }
    }
}
