using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class Offer43
    {
        //返回十进制 1~n 中 所有出现的 1 的个数
        public int CountDigitOne(int n)
        {
            var map = new int[10];

            map[1] = 1;
            for (int i = 2; i < 10; i++)
            {
                var result = 1 + 9 * map[i - 1] + 9;
                map[i] = result;
            }
            var current = n;
            int position = 0;
            int divide = 1;


            int ret = 0;

            while (current > 0)
            {
                position++;
                var p = current % 10;
                current /= 10;

                ret += 1 + (p - 1) * map[position - 1];
            }

            return 0;

        }
    }
}
