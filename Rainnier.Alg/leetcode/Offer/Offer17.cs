using System;
using System.Text;

namespace Rainnier.Alg.leetcode.Offer
{
    public class Offer17
    {
        StringBuilder res;
        int nine = 0, start, n;
        char[] num, loop = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public String printNumbers(int n)
        {
            this.n = n;
            res = new StringBuilder();
            num = new char[n];
            start = n - 1;
            dfs(0);
            res.Remove(res.Length - 1, 1);
            return res.ToString();
        }
        void dfs(int level)
        {
            if (level == n)
            {
                string s = string.Join("",num).Substring(start);
                if (!s.Equals("0")) res.Append(s + ",");
                if (n - start == nine) start--;
                return;
            }
            foreach (char i in loop)
            {
                if (i == '9') nine++;
                num[level] = i;
                dfs(level + 1);
            }
            nine--;

        }
    }
}
