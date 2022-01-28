using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Interview10_01
    {
        //合并排序的数组
        public void Merge(int[] A, int m, int[] B, int n)
        {
            int pA = m - 1;
            int pB = n - 1;

            int index = m + n - 1;

            while (pA >= 0 && pB >= 0)
            {
                if (B[pB] >= A[pA])
                {
                    A[index--] = B[pB--];
                }
                else
                {
                    A[index--] = A[pA--];
                }
            }

            while (pB >= 0)
            {
                A[index--] = B[pB--];
            }

            while (pA >= 0)
            {
                A[index--] = A[pA--];
            }
        }
    }
}
