using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.arr
{
    class FindOnce
    {
        public int FindOne(int[] arr)
        {
            int result = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                result ^= arr[i];
            }

            return result;
        }
    }
}
