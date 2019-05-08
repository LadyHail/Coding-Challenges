using System.Linq;

/*
 DESCRIPTION: 
 Given an array of integers, replace all the occurrences of elemToReplace with substitutionElem.
 Example:
 For inputArray = [1, 2, 1], elemToReplace = 1, and substitutionElem = 3, the output should be
 arrayReplace(inputArray, elemToReplace, substitutionElem) = [3, 2, 3].
 */

namespace Main.CodeFights
{
    public static class ArrayReplace
    {
        public static int[] Solve(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            int[] result = inputArray.Select(e => e == elemToReplace ? substitutionElem : e).ToArray();
            return result;
        }
    }
}
