using System;
using System.Collections.Generic;

namespace Rainnier.Alg.leetcode
{
    public class Leetocde210
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            if (prerequisites == null || numCourses == 0)
            {
                return Array.Empty<int>();
            }

            if (prerequisites.Length == 0)
            {
                var t = new int[numCourses];
                for (int i = 0; i < numCourses; i++)
                {
                    t[i] = i;
                }

                return t;
            }

            var degree = new int[numCourses];

            var map = new Dictionary<int, List<int>>();

            var visited = 0;

            var length = prerequisites.Length;

            var queue = new Queue<int>();

            var result = new int[numCourses];
            var index = 0;

            for (int i = 0; i < length; i++)
            {
                var edge = prerequisites[i];
                degree[edge[0]]++;
                if (!map.ContainsKey(edge[1]))
                {
                    map.Add(edge[1], new List<int>() { edge[0] });
                }
                else
                {
                    if (!map[edge[1]].Contains(edge[0]))
                    {
                        map[edge[1]].Add(edge[0]);
                    }
                }
            }

            for (int i = 0; i < numCourses; i++)
            {
                if (degree[i] == 0)
                {
                    queue.Enqueue(i);
                    visited++;
                }
            }

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                result[index++] = current;

                if (!map.ContainsKey(current) || map[current].Count == 0)
                {
                    continue;
                }

                var nexts = map[current];

                for (int i = 0; i < nexts.Count; i++)
                {
                    if (--degree[nexts[i]] == 0)
                    {
                        queue.Enqueue(nexts[i]);
                        visited++;
                    }
                }

            }

            if (visited == numCourses)
            {
                return result;
            }

            return Array.Empty<int>();
        }
    }
}
