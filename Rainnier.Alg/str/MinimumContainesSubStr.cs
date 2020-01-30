using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.str
{
    //给定字符串str1, str2 求str1 的字串中含有str2所有字符的最小字串长度
    class MinimumContainesSubStr
    {
        public int Contains(string str1, string str2)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int match = str2.Length;
            int result = int.MaxValue;
            for(int i = 0; i < match; i++)
            {
                int count = 0;
                map.TryGetValue(str2[i], out count);
                map[str2[i]] = ++count;
                
            }

            int left = 0;
            int right = 0;
            int val;
            if(map.TryGetValue(str1[left], out val))
            {
                match--;
            }

            while (left < str1.Length)
            {
                if (match > 0)
                {
                    if (right < str1.Length - 1)
                    {
                        if (map.TryGetValue(str1[++right], out val))
                        {
                            if (val > 0)
                            {
                                match--;
                            }

                            map[str1[right]] -= 1;
                        }
                    }
                    else
                    {
                        left++;
                    }
                }
                else
                {
                    result = Math.Min(result, right - left + 1);
                    
                    if(map.TryGetValue(str1[left], out val))
                    {
                        map[str1[left]] += 1;

                        if (map[str1[left]] > 0)
                        {
                            match++;
                        }
                    }

                    left++;
                }
            }

            

            return result;
        }
    }
}
