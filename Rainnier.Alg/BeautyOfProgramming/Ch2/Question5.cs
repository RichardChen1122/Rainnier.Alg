using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.BeautyOfProgramming.Ch2
{
    class Question5
    {
        public int[] Solve(int[] arr, int k)
        {
            int[] result = new int[k];

            int i = 0;
            int max = int.MinValue;

            HashSet<int> exist = new HashSet<int>();

            while (i < k)
            {
                max = int.MinValue;
                int position = 0;
                for (int j=i;j<arr.Length;j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                        position = j;
                    }
                }

                if (exist.Contains(arr[position])){
                    arr[position] = int.MinValue;
                }
                else
                {
                    int temp = arr[i];
                    arr[i] = arr[position];
                    arr[position] = temp;

                    result[i] = arr[i];
                    exist.Add(arr[i]); 
                    i++;
                } 
            }

            return result;

        }
    }
}
