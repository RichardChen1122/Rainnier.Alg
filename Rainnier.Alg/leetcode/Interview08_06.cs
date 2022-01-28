using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Interview08_06
    {
        public void Hanota(IList<int> A, IList<int> B, IList<int> C)
        {
            Move(A.Count, A, B, C);
        }

        public void Move(int n, IList<int> A, IList<int> B, IList<int> C)
        {
            if (n == 1)
            {
                C.Add(A[A.Count - 1]);
                A.RemoveAt(A.Count - 1);

                return;
            }

            Move(n - 1, A, C, B);
            C.Add(A[A.Count - 1]);
            A.RemoveAt(A.Count - 1);
            Move(n - 1, B, A, C);
        }
    }
}
