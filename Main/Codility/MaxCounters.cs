using System.Linq;

namespace Main.Codility
{
    public class MaxCounters
    {
        public static int[] Solve(int N, int[] A)
        {
            int[] result = Enumerable.Repeat(0, N).ToArray();
            int max = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= 1 && A[i] <= N)
                {
                    int index = A[i] - 1;
                    result[index]++;

                    if (result[index] > max)
                    {
                        max = result[index];
                    }
                }
                else if (A[i] == N + 1)
                {
                    for (int j = 0; j < N; j++)
                    {
                        result[j] = max;
                    }
                }
            }

            return result;
        }
    }
}
