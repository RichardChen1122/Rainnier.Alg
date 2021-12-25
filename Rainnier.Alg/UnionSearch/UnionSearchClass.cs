using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.UnionSearch
{
    public class UnionSearchClass
    {
        private int[] father = new int[10];

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

        public int Find(int x)
        {
            if (father[x] == x)
            {
                return x;
            }
            else
            {
                var fa =  Find(father[x]);
                father[x] = fa;

                return fa;
            }
        }

        public void Merge(int x, int y)
        {
            father[Find(x)] = Find(y);
        }


    }
}
