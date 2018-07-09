using System.Linq;

/*
 DESCRIPTION: 
 Given array of integers, find the maximal possible sum of some of its k consecutive elements.
 Example:
 For inputArray = [2, 3, 5, 1, 6] and k = 2, the output should be
 arrayMaxConsecutiveSum(inputArray, k) = 8.
 All possible sums of 2 consecutive elements are:
    2 + 3 = 5;
    3 + 5 = 8;
    5 + 1 = 6;
    1 + 6 = 7.
 Thus, the answer is 8.

 */

namespace Main.CodeFights
{
    public static class ArrayMaxConsecutiveSum
    {
        public static int arrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            int sum = 0;
            int curr = 0;

            for (int i = 0; i < inputArray.Count(); i++)
            {
                if ((i - k) >= 0)
                {
                    curr -= inputArray[i - k];
                }
                curr += inputArray[i];
                if (curr > sum)
                {
                    sum = curr;
                }
            }

            return sum;
        }
    }
}
