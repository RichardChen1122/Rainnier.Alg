using System.Collections.Generic;
using System.Globalization;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode507
    {
        public bool CheckPerfectNumber(int num)
        {
            if (num <= 2)
            {
                return false;
            }

            var hashset = new HashSet<int>() { 1};
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {

                    hashset.Add(i);

                    if (!hashset.Contains(num/i))
                    {
                        hashset.Add(num / i);
                    }
                }
            }

            int v = 0;

            foreach(int item in hashset)
            {
                v += item;
            }

            return v == num;
        }
    }
}
