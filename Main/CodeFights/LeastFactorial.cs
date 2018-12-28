/*
 DESCRIPTION:
 Given an integer n, find the minimal k such that

    k = m! (where m! = 1 * 2 * ... * m) for some integer m;
    k >= n.

 In other words, find the smallest factorial which is not less than n.

 Example:

 For n = 17, the output should be
 leastFactorial(n) = 24.

 17 < 24 = 4! = 1 * 2 * 3 * 4, while 3! = 1 * 2 * 3 = 6 < 17).
*/

namespace Main.CodeFights
{
    public static class LeastFactorial
    {
        public static int leastFactorial(int n)
        {
            int result = 1;
            for (int i = 2; result < n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
