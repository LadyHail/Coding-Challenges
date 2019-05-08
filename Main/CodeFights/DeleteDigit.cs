/*
 DESCRIPTION: 
 Given some integer, find the maximal number you can obtain by deleting exactly one digit of the given number.
 Example
    For n = 152, the output should be
    deleteDigit(n) = 52;
    For n = 1001, the output should be
    deleteDigit(n) = 101.

 */

using System;

namespace Main.CodeFights
{
    public static class DeleteDigit
    {
        public static int Solve(int n)
        {
            string s = n.ToString();
            int i = 0;
            for (i = 0; i < s.Length - 1; i++)
            {
                if (s[i] < s[i + 1])
                {
                    break;
                }
            }
            return Convert.ToInt32(s.Remove(i, 1));
        }
    }
}
