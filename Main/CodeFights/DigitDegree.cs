/*
 DESCRIPTION:
 Let's define digit degree of some positive integer as the number of times we need to replace this number with the sum of its digits until we get to a one digit number.
 Given an integer, find its digit degree.
 Example:
	For n = 5, the output should be
	digitDegree(n) = 0;
	For n = 100, the output should be
	digitDegree(n) = 1.
	1 + 0 + 0 = 1.
	For n = 91, the output should be
	digitDegree(n) = 2.
	9 + 1 = 10 -> 1 + 0 = 1.
*/

namespace Main.CodeFights
{
    public static class DigitDegree
    {
        public static int Solve(int n)
        {
            if (n.ToString().Length == 1)
            {
                return 0;
            }
            int count = 0;
            Count(n.ToString(), ref count);
            return count;
        }

        private static int Count(string num, ref int count)
        {
            int sum = 0;
            count++;
            foreach (char item in num)
            {
                sum += int.Parse(item.ToString());
            }
            if (sum.ToString().Length == 1)
            {
                return count;
            }
            else
            {
                return Count(sum.ToString(), ref count);
            }
        }
    }
}
