using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.BeautyOfProgramming.Ch2
{
    class Question16
    {
        //这个算法的复杂度是N的平方
        public static int Solve(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return 0;
            }

            if (arr.Length == 1)
            {
                return 1;
            }

            int[] dp = new int[arr.Length];

            int maxLength;

            for(int i = 0; i < arr.Length; i++)
            {
                maxLength = 1;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        maxLength = Math.Max(maxLength, dp[j] + 1);
                    }
                }
                dp[i] = maxLength;

            }

            int result = dp[0];

            for(int i = 1; i < arr.Length; i++)
            {
                result = Math.Max(result, dp[i]);
            }

            return result;
        }

        //nlogN
        public static int Solve2(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return 0;
            }

            if (arr.Length == 1)
            {
                return 1;
            }

            int[] dp = new int[arr.Length];
            int[] ends = new int[arr.Length];

            int right = 0;
            ends[0] = arr[0];
            dp[0] = 1;

            for(int i = 1; i < arr.Length; i++)
            {
                int k = findWhereBiggerThanNumber(ends, arr[i], right);

                if (k == -1)
                {
                    right++;
                    ends[right] = arr[i];
                    dp[i] = right+1;
                }
                else
                {
                    dp[i] = k + 1;
                    ends[k] = arr[i];
                }
            }

            int result = dp[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result = Math.Max(result, dp[i]);
            }

            return result;
        }

        private static int findWhereBiggerThanNumber(int[] ends, int num, int right)
        {
            int i = 0;
            int j = right;
            int mid;

            while (i < j - 1)
            {
                mid = i + (j - i) / 2;
                if (num > ends[mid])
                {
                    i = mid ;
                }
                else
                {
                    j = mid;
                }
            }

            if (ends[i] >= num)
            {
                return i;
            }
            if (ends[j] >= num)
            {
                return j;
            }

            return -1;
        }
    }
}
