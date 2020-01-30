using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.BeautyOfProgramming.Ch2
{
    class Question14
    {
        public int MaximumSum(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            int result = (int)default;
            int sum;

            for (int i = 0; i < array.Length; i++)
            {
                sum = 0;
                for (int j = i; j < array.Length; j++)
                {
                    sum += array[j];
                    result = Math.Max(result, sum);
                }
            }

            return result;
        }

        public int MaximumSum2(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            int result = (int)default;
            int sum = 0;

            int left = 0;
            while (left < array.Length)
            {
                sum += array[left];
                result = Math.Max(result, sum);
                if (sum < 0)
                {
                    sum = 0;
                }

                left++;
            }

            return result;
        }

        public int MaximumSum3(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            int result = (int)default;
            
            return result;
        }
    }
}
