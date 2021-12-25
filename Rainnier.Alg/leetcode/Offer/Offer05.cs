using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class Offer05
    {
        public string ReplaceSpace(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == ' ')
                {
                    s= s.Substring(0,i-1)+"%20"+ s.Substring(i+1);
                }
            }

            return s;
        }
    }
}
