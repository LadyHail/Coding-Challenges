using System.Linq;

/*
 DESCRIPTION: 
 Given two arrays of integers a and b, obtain the array formed by the elements of a followed by the elements of b.

 Example:
 For a = [2, 2, 1] and b = [10, 11], the output should be
 concatenateArrays(a, b) = [2, 2, 1, 10, 11].
*/

namespace Main.CodeFights
{
    public static class ConcatenateArrays
    {
        public static int[] Solve(int[] a, int[] b)
        {
            return a.Concat(b).ToArray();
        }
    }
}
