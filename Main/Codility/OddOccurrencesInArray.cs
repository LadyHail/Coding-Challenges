using System.Collections.Generic;
using System.Linq;

namespace Main.Codility
{
    public static class OddOccurrencesInArray
    {
        public static int oddOccurrencesInArray(int[] A)
        {
            HashSet<int> b = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                int element = A[i];
                if (!b.Contains(element))
                {
                    b.Add(element);
                }
                else
                {
                    b.Remove(element);
                }
            }

            return b.First();
        }
    }
}
