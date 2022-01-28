using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode390
    {
        public int LastRemaining(int n)
        {
            var list = new List<int>();

            for (int i = 1; i <=n; i++)
            {
                list.Add(i);
            }

            int iteration = 1;

            while(list.Count > 1)
            {
                if(iteration %2 == 1)
                {
                    int k= 0;
                    while (k < list.Count)
                    {
                        list.RemoveAt(k);
                        k++;
                    }
                }
                else
                {
                    int k= list.Count - 1;

                    while (k >= 0)
                    {
                        list.RemoveAt(k);
                        k -= 2;
                    }
                }
                iteration++;
            }

            return list[0];
        }

        public int LastRemaining2(int n)
        {
            int a1 = 1;
            int k = 0, cnt = n, step = 1;
            while (cnt > 1)
            {
                if (k % 2 == 0)
                { // 正向
                    a1 = a1 + step;
                }
                else
                { // 反向
                    a1 = (cnt % 2 == 0) ? a1 : a1 + step;
                }
                k++;
                cnt = cnt >> 1;
                step = step << 1;
            }
            return a1;
        }

    }
}
