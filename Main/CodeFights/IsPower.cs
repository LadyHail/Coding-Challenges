/*
 DESCRIPTION: 
 Determine if the given number is a power of some non-negative integer.

 Example:
    For n = 125, the output should be
    isPower(n) = true;
    For n = 72, the output should be
    isPower(n) = false.
*/

using System;

namespace Main.CodeFights
{
    public static class IsPower
    {
        public static bool Solve(int n)
        {
            for (int i = 1; i < 21; i++)
            {
                if (n % i == 0)
                {
                    for (int j = 2; j < 21; j++)
                    {
                        if (Math.Pow(i, j) == n)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
