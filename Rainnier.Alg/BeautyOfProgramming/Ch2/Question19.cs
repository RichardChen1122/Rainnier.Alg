using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.BeautyOfProgramming.Ch2
{
    class Question19
    {
        internal static bool Solve(int[][] ranges, int[] array)
        {
            sort(ranges);
            int[][] mergeResult = merge(ranges, out int resultLength);
            for(int i = 0; i < resultLength; i++)
            {
                if(mergeResult[i][0]<=array[0] && mergeResult[i][1] >= array[1])
                {
                    return true;
                }
            }

            return false;
        }

        private static void sort(int[][] ranges)
        {
            for(int i=0; i < ranges.Length; i++)
            {
                for(int j = 0; j < ranges.Length - i - 1; j++)
                {
                    if (ranges[j][0] > ranges[j + 1][0])
                    {
                        int[] temp = ranges[j];
                        ranges[j] = ranges[j + 1];
                        ranges[j + 1] = temp;
                    }
                }
            }
        }

        private static int[][] merge(int[][] ranges, out int resultLength)
        {
            int[][] result = new int[ranges.Length][];
            result[0] = ranges[0];
            resultLength = 1;
            int i = 1;
            while (i < ranges.Length)
            {
                if(!mergeOnce(result[resultLength - 1], ranges[i]))
                {
                    result[resultLength] = ranges[i];
                    resultLength++;
                }
                i++;
            }

            return result;
        }

        private static bool mergeOnce(int[] left, int[] right)
        {
            if ((right[0] - left[1]) > 1)
            {
                return false;
            }
            left[1] = Math.Max(left[1], right[1]);
            return true;
        }
    }
}
