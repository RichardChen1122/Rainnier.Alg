using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.UnionSearch
{
    public class UnionSearchClass
    {
        public int[] father = new int[10];

        private int[] surpressedFather = new int[10];

        public void Init(int n)
        {
            for (int i = 1; i <= n; ++i)
                father[i] = i;

            for (int i = 0; i < 10; i++)
            {
                surpressedFather[i] = father[i];
            }
        }

        // 路径压缩
        public int Find(int x)
        {
            if (father[x] == x)
            {
                return x;
            }
            else
            { 
                father[x] = Find(father[x]);

                return father[x];
            }
        }

        // 没有路径压缩
        public int SlowFind(int x)
        {
            if (father[x] == x)
            {
                return x;
            }
            else
            {
                return SlowFind(father[x]);
            }
        }

        public void Merge(int x, int y)
        {
            father[Find(x)] = Find(y);
        }

        public void SlowMerge(int x, int y)
        {
            father[SlowFind(x)] = SlowFind(y);
        }


    }
}
