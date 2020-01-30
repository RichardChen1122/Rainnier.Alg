using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.arr
{
    class FrogJump
    {
        //自己的实现 不是很好
        public int MinimumJumpStep(int[] arr)
        {
            var resultArr = new int[arr.Length];
            for(int i = 1; i < arr.Length; i++)
            {
                resultArr[i] = int.MaxValue;
            }

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=1; j <= arr[i]; j++)
                {
                    if ((i + j) < arr.Length)
                    {
                        resultArr[i + j] = Math.Min(resultArr[i + j], resultArr[i] + 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return resultArr[arr.Length-1];
        }


        
        public int BetterMinimumJumpStep(int[] arr)
        {
            int jump = 0;
            int current = 0;
            int next = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (current < i)
                {
                    jump++;
                    current = next;
                }

                next = Math.Max(next, i + arr[i]);
            }

            return jump;
        }

        public int Hello(int[] arr)
        {
            int jump = 0;
            int current = 0;
            int next = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (current < i)
                {
                    jump++;
                    current = next;
                }
                next = Math.Max(next, i + arr[i]);
            }

            return jump;
        }
    }

    
}
