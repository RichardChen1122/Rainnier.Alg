using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.arr
{
    //给定一个无序数组，找到数组中未出现的最小正整数
    class FindFirstNotOccur
    {
        //这个算法比较难想到
        //把对应的数放到对应的位置上，如果放不了, 就排除这个数并对数组进行压缩，直到压缩到左右指针相遇
        public int FindMinmumNotOccur(int[] arr)
        {
            int right = arr.Length;
            int left = 0;

            while(left < right)
            {
                if (arr[left] == left + 1)
                {
                    left++;
                }
                else if (arr[left] <= left || arr[left] > right || arr[arr[left] - 1]== arr[left])
                {
                    right--;
                    arr[left] = arr[right];
                }
                else
                {
                    int position = arr[left] - 1;
                    int temp = arr[left];
                    arr[left] = arr[position];
                    arr[position] = temp;
                }
            }

            return left+1;

        }
    }
}
