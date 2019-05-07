using System.Collections.Generic;
using System.Linq;

namespace Main.Codility
{
    public static class Niobium2019
    {
        public static int Solve(int[][] A)
        {
            if (A.Length < 2)
            {
                return 1;
            }

            if (A[0].Length < 2)
            {
                return A.Length;
            }

            bool once = A.All(x => x.Count(y => y == 1) == 1);
            if (once)
            {
                List<int> indexes = new List<int>();

                foreach (int[] arr in A)
                {
                    int index = arr.ToList().IndexOf(1);
                    if (index != -1)
                    {
                        indexes.Add(index);
                    }
                }

                IEnumerable<int> indexesToChange = indexes.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);

                if (indexesToChange.Count() == 0)
                {
                    return 1;
                }

                foreach (int[] arr in A)
                {
                    foreach (int index in indexesToChange)
                    {
                        arr[index] = arr[index] == 0 ? 1 : 0;
                    }
                }

                int count = CountRows(A);

                return count;
            }

            bool iterate = true;
            while (iterate)
            {
                iterate = FindColumnToChange(ref A);
            }

            int counter = CountRows(A);
            return counter;
        }

        private static int CountRows(int[][] A)
        {
            int count = 0;
            int singleArrayLength = A[0].Length;

            foreach (int[] arr in A)
            {
                int zeros = 0, ones = 0;

                foreach (int item in arr)
                {
                    if (item == 0)
                    {
                        zeros++;
                    }
                    else if (item == 1)
                    {
                        ones++;
                    }
                }

                if (zeros == singleArrayLength || ones == singleArrayLength)
                {
                    count++;
                }
            }

            return count;
        }

        private static bool FindColumnToChange(ref int[][] A)
        {
            bool iterate = false;
            int currentRowZeros = 0, nextRowOnes = 0, nextRowZeros = 0;
            int indexOfOneCurrentRow = -1, indexOfOneNextRow = -1;
            bool indexFound = false;

            for (int i = 0; i < A.Length; i++)
            {
                if (indexFound)
                {
                    if (currentRowZeros == nextRowOnes && currentRowZeros != A[i].Length && currentRowZeros != 0)
                    {
                        A[i][indexOfOneCurrentRow] = A[i][indexOfOneCurrentRow] == 0 ? 1 : 0;
                        iterate = true;
                        continue;
                    }
                    else if (currentRowZeros == nextRowZeros && indexOfOneCurrentRow == indexOfOneNextRow && indexOfOneCurrentRow != -1)
                    {
                        A[i][indexOfOneCurrentRow] = A[i][indexOfOneCurrentRow] == 1 ? 0 : 1;
                        iterate = true;
                        continue;
                    }

                    iterate = false;
                    continue;
                }

                for (int j = 0; j < A[i].Length; j++)
                {
                    if (i + 1 == A.Length)
                    {
                        break;
                    }

                    if (A[i][j] == 0)
                    {
                        currentRowZeros++;
                    }
                    else if (A[i][j] == 1 && indexOfOneCurrentRow == -1)
                    {
                        indexOfOneCurrentRow = j;
                    }

                    if (A[i + 1][j] == 1)
                    {
                        nextRowOnes++;
                    }
                    else if (A[i + 1][j] == 0)
                    {
                        nextRowZeros++;
                    }

                    if (A[i + 1][j] == 1 && indexOfOneNextRow == -1)
                    {
                        indexOfOneNextRow = j;
                    }
                }

                if (indexOfOneCurrentRow != -1)
                {
                    indexFound = true;
                    i = -1;
                }
                else
                {
                    currentRowZeros = 0;
                    nextRowOnes = 0;
                    nextRowZeros = 0;
                    indexOfOneCurrentRow = -1;
                    indexOfOneNextRow = -1;
                }
            }

            return iterate;
        }
    }
}
