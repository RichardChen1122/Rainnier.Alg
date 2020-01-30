using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.BeautyOfProgramming.Ch2
{
    class Question7
    {
        public int ZuiDaGongYueShu(int m, int n)
        {
            return n == 0 ? m : ZuiDaGongYueShu(n, m % n);   
        }
    }
}
