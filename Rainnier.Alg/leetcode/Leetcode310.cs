using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode310
    {
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            if(edges == null|| n == 0)
            {
                return Array.Empty<int>();
            }

            if(edges.Length == 0)
            {
                return new List<int>() { 0 };
            }

            var degree = new int[n];
            var removed = new bool[n];
            var length = edges.Length;

            var queue = new Queue<int>();

            var map  = new Dictionary<int, HashSet<int>> ();

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    degree[edges[i][j]]++;

                    if (!map.ContainsKey(edges[i][j]))
                    {
                        map.Add(edges[i][j], new HashSet<int>() { edges[i][1-j]});
                    }
                    else
                    {
                        if(!map[edges[i][j]].Contains(edges[i][1 - j]))
                        {
                            map[edges[i][j]].Add(edges[i][1 - j]);
                        }
                    }
                }
            }

            for (int i = 0; i < degree.Length; i++)
            {
                if (degree[i] == 1)
                {
                    queue.Enqueue(i);
                }
            }

            var leftCount = n;
            while (queue.Count > 0 && queue.Count< leftCount)
            {
                var queueSize = queue.Count;
                leftCount -= queueSize;
                while (queueSize > 0)
                {
                    queueSize--;
                    var current = queue.Dequeue();
                    removed[current] = true;
                    degree[current]--;

                    var nexts = map[current].ToList();
                    for (int j = 0; j < nexts.Count; j++)
                    {
                        if (map[nexts[j]].Contains(current))
                        {
                            map[nexts[j]].Remove(current);

                            if (--degree[nexts[j]] == 1)
                            {
                                queue.Enqueue(nexts[j]);
                            }
                        }
                    }
                }

            }

            var result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (!removed[i])
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
