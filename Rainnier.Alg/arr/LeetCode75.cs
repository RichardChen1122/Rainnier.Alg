using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.arr
{
    class LeetCode75
    {
        int one = 0;
        void Partition(int[] arr, int b)
        {
            
            int two = arr.Length;
            int zero = -1;

            while (one < two)
            {
                if (arr[one] == b)
                {
                    one++;
                }
                else if (arr[one] > b)
                {
                    two--;
                    int temp = arr[one];
                    arr[one] = arr[two];
                    arr[two] = temp;
                }
                else
                {
                    zero++;

                    int temp = arr[zero];
                    arr[zero] = arr[one];
                    arr[one] = temp;

                    one++;
                }
            }
        }
    }
}
