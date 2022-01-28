using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.LCP
{
    public class LCP40
    {
        public int MaxmiumScore(int[] cards, int cnt)
        {
            Array.Sort(cards);

            if (cnt > cards.Length)
            {
                return 0;
            }
            int max = 0;
            var length = cards.Length;

            int minOdd = 0;
            int minEven = 0;

            for (int i = 1; i <= cnt; i++)
            {

                if ((cards[length - i] & 1) != 0)
                {
                    minOdd = cards[length - i];
                }
                else
                {
                    minEven = cards[length - i];
                }
                max += cards[length - i];
            }

            if ((max & 1) == 0)
            {
                return max;
            }

            int even = 0;
            int odd = 0;
            for (int i = length - 1 - cnt; i >= 0; i--)
            {
                if ((cards[i] & 1) == 0 && even==0)
                {
                    even = cards[i];
                }
                if((cards[i] & 1) != 0 && odd == 0)
                {
                    odd = cards[i];
                }
            }

            var option1 = max + odd - minEven;
            var option2 = max + even - minOdd;


            if (even == 0 && odd!=0)
            {
                if (minEven == 0)
                {
                    return 0;
                }
                else
                {
                    return max + odd - minEven;
                }
            }
            else if(odd ==0 && even != 0)
            {
                
                return max + even - minOdd;
            }
            else if(odd == 0 && even == 0)
            {
                return 0;
            }
            else
            {
                if (minEven == 0)
                {
                    return max + even - minOdd;
                }
                else { return Math.Max(max + even - minOdd, max + odd - minEven); }
                
            }


        }
    }
}
