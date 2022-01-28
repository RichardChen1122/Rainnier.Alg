using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    internal class Leetcode1013
    {
        public bool CanThreePartsEqualSum(int[] arr)
        {
            if(arr == null || arr.Length < 4)
            {
                return false;
            }
            var sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum+=arr[i];
            }

            if (sum % 3 != 0)
            {
                return false;
            }

            var subSum=sum/3;

            int p = 0;
            int q = 0;

            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp +=arr[i];
                if (temp == subSum)
                {
                    if (p == 0)
                    {
                        p = i + 1;
                        temp = 0;
                    }
                    else if(q == 0)
                    {
                        q = i + 1;
                    }
                }
            }

            if(p!=0&& q!=arr.Length && q!=0 && q != arr.Length)
            {
                return true;
            }

            return false;
        }
    }
}
