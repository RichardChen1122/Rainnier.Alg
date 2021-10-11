using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode823
    {
        public int NumFactoredBinaryTrees(int[] arr)
        {
            Array.Sort(arr);

            var map = new Dictionary<int, long>();

            map.Add(arr[0], 1);

            int length = arr.Length;

            for (int i = 1; i < length; i++)
            {
                long result = 1;
                for (int k = 0; k < i; k++)
                {

                    if(CanDivide(arr[i], arr[k]))
                    {
                        var anotherFactor = arr[i] / arr[k];
                        if (map.ContainsKey(anotherFactor))
                        {
                            result += map[arr[k]] * map[anotherFactor];
                        }
                    }
                    
                }

                map.Add(arr[i], result);
            }

            long resultFinal = 0;
            foreach (var item in map)
            {
                resultFinal += item.Value;
            }

            return (int)(resultFinal % (Math.Pow(10, 9) + 7));
        }

        private bool CanDivide(int target, int bedevided)
        {
            int temp = target / bedevided;

            return temp * bedevided == target;
        }
    }
}
