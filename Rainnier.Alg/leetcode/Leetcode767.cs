using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
//    给定一个字符串S，检查是否能重新排布其中的字母，使得两相邻的字符不同。

//若可行，输出任意可行的结果。若不可行，返回空字符串。
    public class Leetcode767
    {
        public string ReorganizeString(string S)
        {
            if (S.Length == 1)
            {
                return S;
            }
            int[] container = new int[26];

            char[] input = S.ToCharArray();
            int length = input.Length;
            for (int i = 0; i < length; i++)
            {
                container[input[i] - 'a']++;
            }
            int max = 0;
            int maxPosition = -1;
            for (int i = 0; i < length; i++)
            {
                if (container[i] > max)
                {
                    max = container[i];
                    maxPosition = i;
                }
            }

            if ((length / 2 + 1) < max)
            {
                return string.Empty;
            }
            else
            {
                return string.Empty;

            }

        }
    }
}
