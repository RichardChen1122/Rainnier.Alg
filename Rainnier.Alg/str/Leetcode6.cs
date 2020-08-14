using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.str
{
    public class Leetcode6
    {
        public string Convert(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }
            if (s.Length <= numRows || numRows<=1)
            {
                return s;
            }
            var strbuilder = new StringBuilder();
            for (int i = 0; i < numRows; i++)
            {
                int gap = (numRows - 1) * 2;
                int frontBase = 0;
                int endBase = gap;
                while (frontBase < s.Length)
                {
                    int frontTemp = frontBase + i;
                    int endTemp = endBase - i;

                    if (frontTemp < s.Length)
                    {
                        strbuilder.Append(s[frontTemp]);
                    }
                    if ((endTemp- frontTemp) !=gap && endTemp!=frontTemp && endTemp < s.Length)
                    {
                        strbuilder.Append(s[endTemp]);
                    }
                    frontBase = endBase;
                    endBase += gap;
                }
            }

            return strbuilder.ToString();
        }
    }
}
