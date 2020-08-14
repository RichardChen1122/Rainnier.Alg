using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg
{
    public class Leetcode214
    {
        public string ShortestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            char[] array = new char[s.Length * 2 - 1];

            for (int t = 0; t < array.Length; t++)
            {
                if (t % 2 == 0)
                {
                    array[t] = s[t / 2];
                }
                else
                {
                    array[t] = ' ';
                }
            }
            int i = array.Length / 2;
            for (; i >= 0; i--)
            {
                int max = i * 2;
                bool flag = false;
                for (int k=i-1; k >=0; k--)
                {
                    
                    if (array[k] != array[max - k])
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag) break;
            }

            StringBuilder strBuilder = new StringBuilder();
            for (int k = array.Length-1; k > i*2; k--)
            {
                if(array[k]!=' ')
                {
                    strBuilder.Append(array[k]);
                }
            }

            return strBuilder.ToString() + s;
        } 
    }
}
