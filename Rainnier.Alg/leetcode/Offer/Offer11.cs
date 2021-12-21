using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class Offer11
    {
        public int MinArray(int[] numbers)
        {
            if(numbers == null|| numbers.Length == 0)
            {
                return -1;
            }

            int cur = numbers[0];
            int index = 0;
            while(index<numbers.Length && numbers[index] >= cur)
            {

                cur = numbers[index++];
            }
            return index == numbers.Length ? numbers[0] : numbers[index];
        }
    }
}
