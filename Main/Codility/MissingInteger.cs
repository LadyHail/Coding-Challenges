using System.Collections.Generic;

namespace Main.Codility
{
    public class MissingInteger
    {
        public static int Solve(int[] A)
        {
            HashSet<int> h = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    h.Add(A[i]);
                }
            }

            int result = 1;

            while (h.Contains(result))
            {
                result++;
            }

            return result;
        }
    }
}
