using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.competition.advanced
{
    public class SegmentTree
    {
        SegmentTreeStruct[] tree;
        int[] arr;

        public SegmentTree(int[] array)
        {
            tree = new SegmentTreeStruct[array.Length * 4];
            arr = array;
        }

        int ls(int p)
        {
            return p << 1; // 左儿子， 编号 p*2
        }

        int rs(int p)
        {
            return p << 1 | 1; // 右儿子， 编号 p*2+1
        }

        public void Initialize(int p, int pl, int pr) // 节点编号p 指向区间 pl, pr
        {
            if (pl == pr)
            {
                tree[p] = new SegmentTreeStruct() { data = arr[pl], left = pl, right=pr };

                return;
            }
            int middle = (pl + pr) >> 1;

            Initialize(ls(p), pl, middle);
            Initialize(rs(p), middle+1, pr);

            PushUp(p, pl, pr); //此函数可以根据不同的线段树目的来实现
        }

        private void PushUp(int p, int pl, int pr)
        {
            tree[p] = new SegmentTreeStruct() { data = tree[ls(p)].data + tree[rs(p)].data , left = pl, right = pr};
        }
    }

    public struct SegmentTreeStruct
    {
        public int left;
        public int right;
        public int data;
    }
}
