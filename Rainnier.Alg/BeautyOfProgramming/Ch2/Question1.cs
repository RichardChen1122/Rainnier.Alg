using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.BeautyOfProgramming.Ch2
{
    class Question1
    {
        public int NumberOfOne(int k)
        {
            int result = 0;
            while (k > 0)
            {
                k = k & (k - 1);

                result++;
            }
            return result;
        }
    }
}
