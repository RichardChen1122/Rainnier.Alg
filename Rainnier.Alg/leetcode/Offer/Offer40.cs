using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class Offer40
    {
        public int[] GetLeastNumbers(int[] arr, int k)
        {
            if (arr == null || arr.Length == 0 || k < 1)
            {
                return Array.Empty<int>();
            }

            var length = arr.Length;

            if (k >= length)
            {
                return arr;
            }

            int[] ret = new int[k];

            for (int i = 0; i < k; i++)
            {
                ret[i] = arr[i];
            }

            AdjustHeap(ret, 0);

            for (int i = k; i < length; i++)
            {
                if(arr[i]< ret[0])
                {
                    ret[0]=arr[i];
                    AdjustHeap(ret, 0);
                }
            }

            return ret;
        }

        public void Heapify(int[] array)
        {
            for (int i = array.Length/2-1; i >=0 ; i--)
            {
                AdjustHeap(array, i);
            }


        }

        public void AdjustHeap(int[] array, int i)
        {
            var temp = array[i];

            for (int k = i*2+1; k <array.Length; k = k*2+1)
            {


                if (k + 1 < array.Length && array[k] < array[k + 1])
                {//如果左子结点小于右子结点，k指向右子结点
                    k++;
                }
                if (array[k] > temp)
                {//如果子节点大于父节点，将子节点值赋给父节点（不用进行交换）
                    array[i] = array[k];
                    i = k;
                }
                else
                {
                    break;
                }
            }

            array[i] = temp;
        }
    }
}
