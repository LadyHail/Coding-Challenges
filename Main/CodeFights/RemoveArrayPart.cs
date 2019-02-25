/*
 DESCRIPTION: 
 Remove a part of a given array between given 0-based indexes l and r (inclusive).

 Example:
 For inputArray = [2, 3, 2, 3, 4, 5], l = 2, and r = 4, the output should be
 removeArrayPart(inputArray, l, r) = [2, 3, 5].
*/

using System.Linq;

namespace Main.CodeFights
{
    public static class RemoveArrayPart
    {
        public static int[] removeArrayPart(int[] inputArray, int l, int r)
        {
            return inputArray.Where((x, y) => y < l || y > r).ToArray();
        }
    }
}
