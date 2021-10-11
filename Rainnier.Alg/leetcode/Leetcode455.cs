using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode455
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            var childrenNumber = g.Length;
            var cookieNumber = s.Length;
            int number = 0;

            for (int i = 0, j = 0; i < cookieNumber && j < childrenNumber; i++, j++)
            {
                while (i < cookieNumber && s[i] < g[j])
                {
                    i++;
                }

                if (i < cookieNumber)
                {
                    number++;
                }
            }
            return number;
        }
    }
}
