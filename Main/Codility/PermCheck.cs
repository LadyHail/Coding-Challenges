using System.Collections.Generic;

namespace Main.Codility
{
    public class PermCheck
    {
        public static int Solve(int[] A)
        {
            HashSet<int> numbers = new HashSet<int>();
            int sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (numbers.Contains(A[i]))
                {
                    return 0;
                }
                else
                {
                    numbers.Add(A[i]);
                    sum += A[i];
                }
            }

            int elements = numbers.Count;
            int expectedSum = (elements * (elements + 1)) / 2;

            if (expectedSum != sum)
            {
                return 0;
            }

            return 1;
        }
    }
}
