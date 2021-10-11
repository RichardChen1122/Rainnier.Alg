using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class IslandNumber
    {
        public int NumIslands(char[][] grid)
        {
            if(grid == null || grid.Length==0)
            {
                return 0;
            }

            int result = 0;

            int row = grid.Length;
            int col = grid[0].Length;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        DFS(grid,i,j);

                        result ++;
                    }
                }
            }

            return result;
        }

        private void DFS(char[][] grid, int i, int j)
        {
            int row = grid.Length;
            int col = grid[0].Length;


            if(grid[i][j] == '0')
            {
                return;
            }

            if (grid[i][j] == '1')
            {
                grid[i][j] = '0';
            }
            if (i + 1 < row && grid[i + 1][j] == '1')
            {
                DFS(grid, i + 1, j);
            }
            if ( j+1 < col && grid[i][j + 1] == '1')
            {
                DFS(grid, i, j+1);
            }
            if ( i - 1 >-1 && grid[i - 1][j] == '1' )
            {
                DFS(grid, i - 1, j);
            }
            if (j-1 >-1 && grid[i][j - 1] == '1')
            {
                DFS(grid, i, j-1);
            }
        }
    }
}
