using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Rainnier.Alg.arr
{
    class BinarySearch
    {
        public static int Solve(int[] arr, int num, int start, int end)
        {
            int result = -1;

            if (arr == null || arr.Length == 0)
            {
                return -1;
            }

            if (end >= start)
            {

                int mid = start + (end - start) / 2;

                if (num > arr[mid])
                {
                    result = Solve(arr, num, mid+1, end);
                }
                else if (num < arr[mid])
                {
                    result = Solve(arr, num, start, mid-1);
                }
                else
                {
                    result = mid;
                }
            }

            return result;

        }

        public static int Solve2(int[] arr,int num)
        {
            int left = 0;
            int right = arr.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (num > arr[mid])
                {
                    left = mid + 1;
                }
                else if (num < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        public static int Solve3(string[] arr, int begin, int end, string str)
        {
            int mid;
            int left = begin;
            int right = end;

            while (left < right - 1){
                mid = left + (right - left) / 2;
                if (string.Compare(arr[mid], str) <= 0)
                {
                    left = mid;
                }
                else{
                    right = mid;
                }
            }
            if(string.Compare(arr[right], str) == 0)
            {
                return right;
            }
            else if(string.Compare(arr[left], str) == 0)
            {
                return left;
            }
            else
            {
                return -1;
            }
        }
    }
}
