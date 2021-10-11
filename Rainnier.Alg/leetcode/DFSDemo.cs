using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class DFSDemo
    {
        public void Entery(char[][] matrix)
        {
            int rowNum = matrix.Length;
            int colNum = matrix[0].Length;
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    DFS(matrix, i, j);
                }
            }
        }

        public void DFS(char[][] matrix, int row,int col)
        {
            if (matrix[row][col] == 'x')
            {
                return;
            }
            int rowNum = matrix.Length;
            int colNum = matrix[0].Length;
            Console.WriteLine(matrix[row][col]);
            matrix[row][col] = 'x';
            if(col < colNum - 1 && row < rowNum - 1)
            {
                DFS(matrix, row+1, col + 1);
            }
            if (col< colNum-1) 
                DFS(matrix, row, col+1);
            if (row < rowNum - 1)
                DFS(matrix, row+1, col);
        }

        public void BFS(char[][] matrix)
        {
            int rowNum = matrix.Length;
            int colNum = matrix[0].Length;
            var visitedMatrix = new bool[rowNum][];
            for (int i = 0; i < rowNum; i++)
            {
                visitedMatrix[i] = new bool[colNum];
            }
            var queue = new Queue<ValueTuple<int, int>>();

            queue.Enqueue((0, 0));
            visitedMatrix[0][0] = true;

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();

                
                Console.WriteLine(matrix[item.Item1][item.Item2]);
                if(item.Item1< rowNum-1 && !visitedMatrix[item.Item1 + 1][item.Item2])
                {
                    queue.Enqueue((item.Item1+1, item.Item2));
                    visitedMatrix[item.Item1 + 1][item.Item2] = true;
                }

                if (item.Item2 < colNum - 1 && !visitedMatrix[item.Item1][item.Item2+1])
                {
                    queue.Enqueue((item.Item1, item.Item2+1));
                    visitedMatrix[item.Item1][item.Item2 + 1] = true;
                }
            }

        }
    }
}
