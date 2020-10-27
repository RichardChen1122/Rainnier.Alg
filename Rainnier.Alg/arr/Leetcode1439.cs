using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.arr
{
    public class Leetcode1439
    {
        public int KthSmallest(int[][] mat, int k)
        {
            int l = 0;
            int r = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                l += mat[i].First();
                r += mat[i].Last();
            }

            int base1 = l;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                int cnt = 1;
                dfs(mat, k, mid, 0, base1, ref cnt);
                if (cnt < k)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
            }
            return r;
        }

        void dfs(int[][] mat, int k, int maxSum, int idx, int sum, ref int cnt)
        {
            if (idx == mat.Length) return;
            if (sum > maxSum || cnt > k) return;

            dfs(mat, k, maxSum, idx + 1, sum, ref cnt);

            for (int j = 1; j < mat[idx].Length; j++)
            {
                int temp = sum + mat[idx][j] - mat[idx][0];
                if (temp > maxSum) break;
                cnt++;
                dfs(mat, k, maxSum, idx + 1, temp, ref cnt);
            }
        }


        //public int MyKthSmallest(int[][] mat, int k)
        //{
        //    int[] priorityArray = new int[k];
        //    int calcuatedCount = 0;
        //    int l = 0;
        //    for (int i = 0; i < mat.Length; i++)
        //    {
        //        l += mat[i].First();
        //        calcuatedCount++;
        //    }
        //}

        private void dfs(int[][] mat, int level, int l, int[] priorityArray, ref int calCount)
        {
            if (level >= mat.Length) return;
            dfs(mat, level + 1, l);
            int temp = 0;
            for (int i = 1; i < mat[0].Length; i++)
            {
                temp = l + mat[level][i] - mat[level][0];
                Console.WriteLine(temp);
                dfs(mat, level + 1, temp);
            }
        }


        public void ShowSums(int[][] mat)
        {
            int l = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                l += mat[i].First();
            }
            Console.WriteLine(l);
            dfs(mat, 0, l);
        }

        private void dfs(int[][] mat, int level, int l)
        {
            if (level >= mat.Length) return;
            dfs(mat, level + 1, l);
            int temp = 0;
            for (int i = 1; i < mat[0].Length; i++)
            {
                temp = l + mat[level][i] - mat[level][0];
                Console.WriteLine(temp);
                dfs(mat, level + 1, temp);
            }
        }
    }
}
