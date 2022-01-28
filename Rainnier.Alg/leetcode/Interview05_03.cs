using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Interview05_03
    {
        public int ReverseBits(int num)
        {
            var n = num;

            var current = 0;
            var reverse = 0;
            var best = 0;

            while(n>0)
            {
                if ((n & 1) == 1)
                {
                    current++;
                    reverse++;
                }
                else
                {

                    reverse = current + 1;
                    current = 0;
                }

                best = Math.Max(reverse, best);
                n = n >> 1;
            }

            return best;
        }
    }
}
