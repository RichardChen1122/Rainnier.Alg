using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode435
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[0] -y[0]);

            return 0;
        }
    }
}
