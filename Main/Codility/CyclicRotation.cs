namespace Main.Codility
{
    public static class CyclicRotation
    {
        public static int[] cyclicRotation(int[] A, int K)
        {
            if (A.Length < 2)
            {
                return A;
            }

            int[] r = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                if (i + K > A.Length)
                {
                    int index = (i + K) % A.Length;
                    r[index] = A[i];
                }
                else if (i + K == A.Length)
                {
                    r[0] = A[i];
                }
                else
                {
                    r[i + K] = A[i];
                }
            }

            return r;
        }
    }
}
