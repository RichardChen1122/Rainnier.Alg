using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.str
{
    // http://www.ruanyifeng.com/blog/2013/05/Knuth%E2%80%93Morris%E2%80%93Pratt_algorithm.html
    public class KMP
    {
        public bool IsSubString(string origin, string toMatch)
        {
            if (string.IsNullOrEmpty(toMatch)) return true;
            if (string.IsNullOrEmpty(origin)) return false;

            int position = 0;
            var table = getPartialMatchArray(toMatch);

            while (position < origin.Length - toMatch.Length)
            {
                int i = 0;
                int matchedLength = 0;
                for (; i < toMatch.Length; i++)
                {
                    if (toMatch[i] != origin[position + i])
                    {
                        break;
                    }
                    else
                    {
                        matchedLength++;
                    }
                }
                if (matchedLength == toMatch.Length)
                {
                    return true;
                }
                else
                {
                    if (matchedLength == 0)
                    {
                        position++;
                    }
                    else
                    {
                        position += (matchedLength - table[matchedLength - 1]);
                    }
                }
            }

            return false;
        }

        public int[] getPartialMatchArray(string toMatch)
        {
            var result = new int[toMatch.Length];
            result[0] = 0;

            for (int i = 1; i < toMatch.Length; i++)
            {
                string[] tempTable = new string[i];
                for (int j = 0; j < i; j++)
                {
                    tempTable[j] = toMatch.Substring(0, j + 1);
                }
                for (int k = 0; k < i; k++)
                {
                    if (string.Equals(tempTable[k], toMatch.Substring(i - k,k+1)))
                    {
                        result[i] = tempTable[k].Length;
                    }
                }
            }

            return result;
        }
    }
}
