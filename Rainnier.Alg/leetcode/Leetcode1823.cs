using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode1823
    {
        public int FindTheWinner(int n, int k)
        {
            if (k == 1)
            {
                return n;
            }

            var list = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }

            int index = k - 1;
            while (list.Count > 1)
            {
                if (index < list.Count)
                {
                    list.RemoveAt(index);
                    index += k - 1;
                }
                else
                {
                    index = index - list.Count;
                }
            }

            return list[0];
        }

        /*
             int findTheWinner(int n, int k) {
        int dp = 0;
        for(int i = 2; i <= n; i++) {
            dp = ((dp + k) % i);
        }
        return dp + 1;
    }*/

        public int FindTheWinner2(int n, int k)
        {
            int dp = 0;

            for (int i = 2; i <=n; i++)
            {
                dp = ((dp + k) % i);
            }

            return dp + 1;
        }
    }
}
