using System.Linq;

/*
 DESCRIPTION: 
 Given an integer size, return array of length size filled with 1s.

 Example:

 For size = 4, the output should be
 createArray(size) = [1, 1, 1, 1].
*/

namespace Main.CodeFights
{
    public static class CreateArray
    {
        public static int[] Solve(int size)
        {
            return Enumerable.Repeat(1, size).ToArray();
        }
    }
}
