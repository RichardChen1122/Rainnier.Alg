using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode274
    {
        // H 指数
        public int HIndex(int[] citations)
        {
            Array.Sort(citations, (x, y) =>
            {
                return y - x;
            });
            int i = 0
            for (; i < citations.Length; i++)
            {
                if (citations[i] < i+1)
                {
                    break;
                }
            }

            return i;
        }
    }
}
