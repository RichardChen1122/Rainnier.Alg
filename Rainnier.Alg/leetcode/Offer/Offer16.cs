using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class Offer16
    {
        public double MyPow(double x, int n)
        {
            double result = 1;
            for (int i = n; i !=0; i/=2)
            {
                if (i % 2 !=0)
                {
                    result *= x;
                }
                x *= x;
            }
            return n < 0 ? 1 / result : result;
        }
    }
}
