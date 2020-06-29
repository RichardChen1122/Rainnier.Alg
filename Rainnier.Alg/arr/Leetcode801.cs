using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.arr
{
    class Leetcode801
    {
        public int MinSwap(int[] A, int[] B)
        {
            int i = 1;
            int nochange = 0;
            int change = 1;
            while (i < A.Length)
            {
                if (A[i - 1] < A[i] && B[i - 1] < B[i]) //这种情况要根据前一次的交换情况进行判断
                {
                    if (A[i - 1] >= B[i] || B[i - 1] >= A[i])//这种情况下，要么不交换 nochange 不变。如果交换，必须基于前一次交换的基础上一起交换，所以要change++
                    {
                        change++;
                    }
                    else //这种情况下， 如果交换，前一次交换不交换都无所谓，找小的+1即可，如果不叫唤，那迁移此叫不交换也无所谓， 取小的即可
                    {
                        int temp = change;
                        change = Math.Min(nochange, change) + 1;
                        nochange = Math.Min(nochange, temp);
                    }
                }
                else //由于输入的结果一定是有效的，所以其他情况只能是 A[i-1]<B[i] && B[i-1]<A[i]
                {
                    int temp = change;
                    change = nochange + 1;
                    nochange = temp;

                }
                i++;
            }

            return Math.Min(nochange, change);
        }
    }
}
