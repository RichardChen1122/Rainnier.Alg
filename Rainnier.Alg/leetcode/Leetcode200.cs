using System;
using System.Collections.Generic;
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
