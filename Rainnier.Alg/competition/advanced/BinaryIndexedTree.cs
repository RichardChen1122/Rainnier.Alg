using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.competition.advanced
{
    public class BinaryIndexedTree
    {
        private int[] arr;
        private int[] tree;
        private int[] sum;
        public int[] Tree => tree;
        public int[] Sum => sum;

        public BinaryIndexedTree(int[] array)
        {
            arr = array;
            tree = new int[array.Length];
            sum = new int[array.Length];
        }

        public void Update(int number, int index)
        {
            while (index <= tree.Length)
            {
                tree[index-1] += number;

                index += lowbit(index);
            }
        }

        public void InitializeBinaryIndexedTree()
        {
            // 避免使用0 作为下标， 不然lowbit(index) 会进入死循环
            for (int i = 1; i <= arr.Length; i++)
            {
                Update(arr[i - 1], i);
            }
        }

        public int getSum(int index)
        {
            var innerIndex = index + 1;
            int result =0;

            while(innerIndex >= 1)
            {
                result += tree[innerIndex-1];
                innerIndex -= lowbit(innerIndex);
            }

            return result;
        }

        public int GetWindowSum(int left, int right)
        {
            return getSum(right) - getSum(left-1);
        }


        private int lowbit(int x)
        {
            return x & (-x);
        }
    }
}
