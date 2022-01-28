using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Interview08_01
    {
        public int WaysToStep(int n)
        {
            long[] dp = new long[4] {1,2,4,7};

            if (n <= 4)
            {
                return (int)dp[n - 1];
            }

            for (int i = 5; i <=n; i++)
            {
                dp[0] = dp[1];
                dp[1] = dp[2];
                dp[2] = dp[3];
                dp[3] = dp[0]+dp[1]+dp[2];
            }

            return (int)(dp[3] % 1000000007);
        }
    }
}
