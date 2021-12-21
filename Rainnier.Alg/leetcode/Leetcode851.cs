using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
//    输入：richer = [[1,0],[2,1],[3,1],[3,7],[4,3],[5,3],[6,3]], quiet = [3,2,5,4,6,1,7,0]
//输出：[5,5,2,5,4,5,6,7]
    public class Leetcode851
    {
        public int[] LoudAndRich(int[][] richer, int[] quiet)
        {
            var n = quiet.Length;
            var res = new int[n];


            var degree  = new int[n];

            var reverseMap = new Dictionary<int, List<int>>();  

            for (int i = 0; i < richer.Length; i++)
            {
                degree[richer[i][1]]++;

                if (!reverseMap.ContainsKey(richer[i][0]))
                {
                    reverseMap.Add(richer[i][0], new List<int>() { richer[i][1] });
                }
                else
                {
                    reverseMap[richer[i][0]].Add(richer[i][1]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                res[i] = i;
            }

            var queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                if (degree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }



            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (reverseMap.ContainsKey(current))
                {
                    foreach (var next in reverseMap[current])
                    {
                        if (quiet[res[current]] < quiet[res[next]])
                        {
                            res[next] = res[current];
                        }

                        if ( --degree[next]==0)
                        {
                            queue.Enqueue(next); 
                        }
                    }
                }
                
            }



            return res;
        }
    }
}
