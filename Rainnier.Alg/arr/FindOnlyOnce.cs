using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.arr
{
    class FindOnlyOnce
    {
        public static int Solve(int[] arr, int k)
        {
            int[] e = getKSysNumFromNum(arr[0], k);
            for (int i = 1; i < arr.Length; i++)
            {
                getXor(e, getKSysNumFromNum(arr[i], k),k);
            }

            return getNumFromKSysNum(e, k);
        }

        private static void getXor(int[] e1, int[] e2, int k)
        {
            for(int i = 0; i < e1.Length; i++)
            {
                e1[i] = (e1[i] + e2[i]) % k;
            }
        }

        private static int[] getKSysNumFromNum(int num, int k)
        {
            int[] result = new int[32];
            int i = 0;
            int val;

            while (num != 0)
            {
                val = num % k;
                num = num / k;
                result[i] = val;
                i++;
            }

            return result;
        }

        private static int getNumFromKSysNum(int[] kSys, int k)
        {
            int result = 0;

            for(int i = 0; i < kSys.Length; i++)
            {
                result += kSys[i] * (int)Math.Pow(k, i);
            }

            return result;
        }
    }
}
