using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class Offer12
    {
        private bool[][] visited;
        public bool Exist(char[][] board, string word)
        {
            if(board == null || board.Length==0|| board[0].Length == 0)
            {
                return false;
            }

            var rowLength = board.Length;
            var columnLength = board[0].Length;

            visited = new bool[rowLength][]; 

            for (int i = 0; i < rowLength; i++)
            {
                visited[i] = new bool[columnLength];
            }

            var charlist = word.ToCharArray();

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    if(board[i][j]== charlist[0])
                    {
                        if(dfs(board, charlist, i, j, 0))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private bool dfs(char[][] board, char[] charlist, int row,int col, int index)
        {
            if(index== charlist.Length)
            {
                return true;
            }
            if (row<0|| row>=board.Length || col<0|| col>=board[0].Length || visited[row][col])
            {
                return false;
            }

            if (board[row][col] != charlist[index])
            {
                return false;
            }
            else
            {
                visited[row][col] = true;
                var b1 = dfs(board, charlist, row+1, col, index+1);
                var b2 = dfs(board, charlist, row-1, col, index+1);
                var b3 = dfs(board, charlist, row, col+1, index+1);
                var b4 = dfs(board, charlist, row, col-1, index+1);

                if(!(b1 || b2 || b3 || b4))
                {
                    visited[row][col] = false;
                }
                return b1 || b2 || b3 || b4;
            }

        }
    }
}
