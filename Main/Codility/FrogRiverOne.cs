using System.Collections.Generic;

namespace Main.Codility
{
    public class FrogRiverOne
    {
        public static int Solve(int X, int[] A)
        {
            HashSet<int> n = new HashSet<int>();
            int sum = 0;
            int maxTime = -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > X)
                {
                    continue;
                }

                if (!n.Contains(A[i]))
                {
                    n.Add(A[i]);
                    sum += A[i];

                    if (i > maxTime)
                    {
                        maxTime = i;
                    }
                }
            }

            int expectedSum = (X * (X + 1)) / 2;
            if (expectedSum != sum)
            {
                return -1;
            }

            return maxTime;
        }
    }
}
