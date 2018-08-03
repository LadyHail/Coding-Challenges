/*
 DESCRIPTION:
 Given a rectangular matrix containing only digits, calculate the number of different 2 × 2 squares in it.
 Example
 For
 matrix = [[1, 2, 1],
           [2, 2, 2],
           [2, 2, 2],
           [1, 2, 3],
           [2, 2, 1]]
 the output should be differentSquares(matrix) = 6.
*/

using System.Collections.Generic;

namespace Main.CodeFights
{
    public static class DifferentSquares
    {
        public static int differentSquares(int[][] matrix)
        {
            HashSet<string> s = new HashSet<string>();

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    s.Add(matrix[i][j].ToString() + matrix[i + 1][j].ToString() + matrix[i + 1][j + 1].ToString() + matrix[i][j + 1].ToString());
                }
            }

            return s.Count;
        }
    }
}
