using System;
using System.Linq;

namespace Main.Codility
{
    public static class TapeEquilibrium
    {
        public static int tapeEquilibrium(int[] A)
        {
            int result = int.MaxValue;
            int sumRight = A.Sum();
            int sumLeft = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                sumLeft += A[i];
                sumRight -= A[i];

                int difference = Math.Abs(sumLeft - sumRight);

                if (difference < result)
                {
                    result = difference;
                }
            }

            return result;
        }
    }
}
