using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Offer_001
    {
        public int Divide(int a, int b)
        {
            int flag = 0;
            if (a > 0)
            {
                a = -a;
                flag += 1;
            }

            if (b > 0)
            {
                b = -b;
                flag += 1;
            }
            int ret = calc(a, b);
            if (flag != 1 && ret == int.MinValue)
            {
                ret++;
            }
            return flag == 1 ? ret : -ret;
        }

        private int calc(int a, int b)
        {
            int ret = 0;
            while (a <= b)
            {
                int cnt = 1;
                int val = b;
                while (val >= int.MinValue >> 1 && a <= val << 1)
                {
                    cnt += cnt;
                    val += val;
                }
                ret -= cnt;
                a -= val;
            }
            return ret;
        }
    }
}
