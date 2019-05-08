using System;
using System.Linq;

/*
 DESCRIPTION:
 Find the leftmost digit that occurs in a given string.
 Example:
 For inputString = "var_1__Int", the output should be
 firstDigit(inputString) = '1';
 For inputString = "q2q-q", the output should be
 firstDigit(inputString) = '2';
 For inputString = "0ss", the output should be
 firstDigit(inputString) = '0'.
*/

namespace Main.CodeFights
{
    public static class FirstDigit
    {
        public static char Solve(string inputString)
        {
            return inputString.FirstOrDefault(x => Char.IsDigit(x));
        }
    }
}
