using System;
using System.Linq;

/*
 DESCRIPTION: 
 Given array of integers, remove each kth element from it.
 Example:
 For inputArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] and k = 3, the output should be
 extractEachKth(inputArray, k) = [1, 2, 4, 5, 7, 8, 10].
 */

namespace Main.CodeFights
{
    public static class ExtractEachKth
    {
        public static int[] extractEachKth(int[] inputArray, int k)
        {
            if (k == 1)
            {
                return Array.Empty<int>();
            }
            return inputArray.Where((x, i) => i == ((i + 1) % k == 0 ? 0 : i)).ToArray();
        }
    }
}
