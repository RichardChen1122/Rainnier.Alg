using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.arr
{
    class Leetcode1465
    {
        public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
        {
            long max1 = FindMaxSpan(horizontalCuts, h);
            long max2 = FindMaxSpan(verticalCuts, w);

            long test = (max1 * max2)%(10000*100000+7);
            return (int)test;
        }

        public int FindMaxSpan(int[] array, int k)
        {
            QuickSort(array,0,array.Length-1);
            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                result = Math.Max(result, array[i] - array[i - 1]);
            }

            result = Math.Max(result, k - array[array.Length - 1]);

            return result;
        }

        public void QuickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                var mid = QuickSortOnce(array, start, end);
                QuickSort(array, start, mid);
                QuickSort(array, mid + 1, end);
            }
        }

        public int QuickSortOnce(int[] array, int start, int end)
        {
            int temp = array[start];

            while (start < end)
            {
                while(array[end]>=temp && start < end)
                {
                    end--;
                }
                array[start] = array[end];
                while (array[start] < temp && start < end)
                {
                    start++;
                }
                array[end] = array[start];
            }

            array[start] = temp;

            return start;
        }
    }
}
