using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode846
    {
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            if(hand == null|| hand.Length == 0 || groupSize==0)
            {
                return false;
            }

            if (groupSize == 1)
            {
                return true;
            }
            var n = hand.Length;

            if (n % groupSize != 0)
            {
                return false;
            }

            int min= hand[0];
            int max= hand[0];

            for (int i = 0; i < n; i++)
            {
                min = Math.Min(min, hand[i]);
                max = Math.Max(max, hand[i]);
            }
            

            var map = new Dictionary<int, int>();

            for (int i = 0;i < n; i++)
            {
                if (!map.ContainsKey(hand[i]))
                {
                    map.Add(hand[i], 1);
                }
                else
                {
                    map[hand[i]]++;
                }
            }

            int index = min;
           while (index <= max)
            {
                if (map.ContainsKey(index))
                {
                    if (map[index] >= 1)
                    {
                        int value = index;
                        int size = 1;

                        while (size <= groupSize)
                        {
                            if (map.ContainsKey(value))
                            {
                                if (map[value] >= 1)
                                {
                                    map[value]--;
                                }
                                else
                                {
                                    return false;
                                }
                                value++;
                                size++;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        index++;
                    }
                }
                else
                {
                    index++;
                }
            }

            return true; 
        }
    }
}
