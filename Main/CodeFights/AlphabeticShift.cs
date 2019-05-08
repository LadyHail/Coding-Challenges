using System;
using System.Linq;

/*
 DESCRIPTION: 
 Given a string, replace each its character by the next one in the English alphabet (z would be replaced by a).
 Example:
 For inputString = "crazy", the output should be
 alphabeticShift(inputString) = "dsbaz".
 */

namespace Main.CodeFights
{
    public static class AlphabeticShift
    {
        public static string Solve(string inputString)
        {
            return new String(inputString.Select(c => c == 122 ? (char)97 : (char)(c + 1)).ToArray());
        }
    }
}
