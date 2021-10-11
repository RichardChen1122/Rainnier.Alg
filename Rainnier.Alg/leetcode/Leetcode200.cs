using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode200
    {
        public int NumIslands(char[][] grid)
        {  
            var previous = GetRanges(grid[0]);
            int maxResult = previous.Count;
            for (int i = 1; i < grid.Length; i++)
            {
                var next = GetRanges(grid[i]);
                var result = Consume(previous, next);
                maxResult = maxResult - result + next.Count;
                previous = next;
            }

            return maxResult;
        }

        public int NumIslandsDFS(char[][] grid)
        {
            int num = 0;
            int rowNumber = grid.Length;
            int colNumber = grid[0].Length;
            for (int i = 0; i < rowNumber; i++)
            {
                for (int j = 0; j < colNumber; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        num++;
                        dfs(grid,i,j);
                    }
                }
            }

            return num;
        }

        private void dfs(char[][] grid, int row, int col)
        {
            int rowNumber = grid.Length;
            int colNumber = grid[0].Length;

            grid[row][col] = '0';

            if (row - 1 >= 0 && grid[row - 1][col] == '1')
                dfs(grid, row - 1, col);
            if (row +1 < rowNumber && grid[row + 1][col] == '1')
                dfs(grid, row + 1, col);
            if (col - 1 >= 0 && grid[row][col-1] == '1')
                dfs(grid, row, col-1);
            if (col + 1 < colNumber && grid[row][col + 1] == '1')
                dfs(grid, row, col + 1);
        }

        public int NumIslandsBFS(char[][] grid)
        {
            int num = 0;
            int rowNumber = grid.Length;
            int colNumber = grid[0].Length;
            for (int i = 0; i < rowNumber; i++)
            {
                for (int j = 0; j < colNumber; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        num++;
                        bfs(grid, i, j);
                    }
                }
            }

            return num;
        }

        private void bfs(char[][] grid, int row, int col)
        {
            int rowNumber = grid.Length;
            int colNumber = grid[0].Length;

            var queue = new Queue<ValueTuple<int, int>>();
            queue.Enqueue((row, col));
            grid[row][col] = '0';
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                if (item.Item1>0 && grid[item.Item1-1][item.Item2] == '1')
                {
                    queue.Enqueue((item.Item1 - 1, item.Item2));
                    grid[item.Item1 - 1][item.Item2] = '0';
                }
                if (item.Item2 > 0 && grid[item.Item1][item.Item2-1] == '1')
                {
                    queue.Enqueue((item.Item1, item.Item2-1));
                    grid[item.Item1][item.Item2-1] = '0';
                }
                if (item.Item1 < rowNumber-1 && grid[item.Item1 +1][item.Item2] == '1')
                {
                    queue.Enqueue((item.Item1 + 1, item.Item2));
                    grid[item.Item1 + 1][item.Item2] = '0';
                }
                if (item.Item2 < colNumber-1 && grid[item.Item1][item.Item2 + 1] == '1')
                {
                    queue.Enqueue((item.Item1, item.Item2 + 1));
                    grid[item.Item1][item.Item2 + 1] = '0';
                }
            }
        }
        


        internal List<Range> GetRanges(char[] list)
        {
            List<Range> result = new List<Range>();
            int start = 0;
            int length = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == '0')
                {
                    if (length != 0)
                    {
                        var item = new Range()
                        {
                            begin = start,
                            end = start + length - 1
                        };
                        result.Add(item);

                        start = i+1;
                        length = 0;
                    }
                    else
                    {
                        start++;
                    }
                }
                else
                {
                    length++;
                }
            }

            if(start< list.Length && length > 0)
            {
                var item = new Range()
                {
                    begin = start,
                    end = start + length - 1
                };
                result.Add(item);
            }

            return result;
        }

        internal struct Range
        {
            public int begin;
            public int end;
        }

        internal int Consume(List<Range> previous, List<Range> next)
        {
            int consumeCount = 0;
            for (int i = 0; i < next.Count; i++)
            {
                for (int j = 0; j < previous.Count; j++)
                {
                    if((next[i].begin<=previous[j].begin && next[i].end >= previous[j].end)||
                        (next[i].begin >= previous[j].begin && next[i].end <= previous[j].end))
                    {
                        consumeCount++;
                    }
                }
            }

            return consumeCount;
        }

    }
}
