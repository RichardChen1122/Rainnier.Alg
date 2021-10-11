using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    /// <summary>
    /// 老师想给孩子们分发糖果，有 N 个孩子站成了一条直线，老师会根据每个孩子的表现，预先给他们评分。
    /// 你需要按照以下要求，帮助老师给这些孩子分发糖果：
    /// 每个孩子至少分配到 1 个糖果。
    /// 相邻的孩子中，评分高的孩子必须获得更多的糖果。
    /// </summary>
    public class Leetcode135
    {
        public int Candy(int[] ratings)
        {
            int n = ratings.Length;
            int ret = 1;
            int inc = 1, dec = 0, pre = 1;
            for (int i = 1; i < n; i++)
            {
                if (ratings[i] >= ratings[i - 1])
                {
                    dec = 0;
                    pre = ratings[i] == ratings[i - 1] ? 1 : pre + 1;
                    ret += pre;
                    inc = pre;
                }
                else
                {
                    dec++;
                    if (dec == inc)
                    {
                        dec++;
                    }
                    ret += dec;
                    pre = 1;
                }
            }
            return ret;
        }
    }
}
