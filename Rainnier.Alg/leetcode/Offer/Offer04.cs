using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class Offer04
    {
//        [
//  [1,   4,  7, 11, 15],
//  [2,   5,  8, 12, 19],
//  [3,   6,  9, 16, 22],
//  [10, 13, 14, 17, 24],
//  [18, 21, 23, 26, 30]
//]

        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            

            int rowLength = matrix.Length;

            if (rowLength == 0) return false;

            int columnLength = matrix[0].Length;

            if (columnLength == 0) return false;

            return FindNumberIn2DArray(matrix, target, 0, rowLength - 1, 0, columnLength - 1);
        }

        public bool FindNumberIn2DArray(int[][] matrix, int target, int startRow, int endRow, int startCol, int endCol)
        {
            if (target < matrix[startRow][startCol] || target > matrix[endRow][endCol])
            {
                return false;
            }

            if(startRow==endRow&& startCol == endCol)
            {
                return target==matrix[startRow][startCol];
            }

            if (endRow - startRow >= 1 && endCol-startCol>=1)
            {
                int midRow = (endRow - startRow) / 2 + startRow;
                int midCol = (endCol - startCol) / 2 + startCol;
                var t = FindNumberIn2DArray(matrix, target, startRow, midRow, startCol, midCol);
                var t2 = FindNumberIn2DArray(matrix, target, startRow, midRow, midCol+1, endCol);
                var t3 = FindNumberIn2DArray(matrix, target, midRow+1, endRow, startCol, midCol);
                var t4 = FindNumberIn2DArray(matrix, target, midRow+1, endRow, midCol + 1, endCol);

                return t || t2 || t3 || t4;

            }
            else if(endRow - startRow >= 1)
            {
                int midRow = (endRow - startRow) / 2 + startRow;
                var t = FindNumberIn2DArray(matrix, target, startRow, midRow, startCol, endCol);
                var t2 = FindNumberIn2DArray(matrix, target, midRow+1, endRow, startCol, endCol);
                return t || t2;
            }
            else
            {
                int midCol = (endCol - startCol) / 2 + startCol;
                var t = FindNumberIn2DArray(matrix, target, startRow, endRow, startCol, midCol);
                var t2 = FindNumberIn2DArray(matrix, target, startRow, endRow, midCol+1, endCol);
                return t || t2;
            }
        }

        public bool FindNumberIn2DArray2(int[][] matrix, int target)
        {

            if(matrix == null|| matrix.Length==0|| matrix[0].Length == 0)
            {
                return false;
            }
            int rowLength = matrix.Length;
            int columnLength = matrix[0].Length;

            int row = 0;
            int column = columnLength-1;

            while(row<rowLength && column >=0)
            {
                if(matrix[row][column] == target)
                {
                    return true;
                }
                else if(matrix[row][column] < target)
                {
                    row++;
                }
                else
                {
                    column--;
                }
            }
            return false;
        }
    }
}
