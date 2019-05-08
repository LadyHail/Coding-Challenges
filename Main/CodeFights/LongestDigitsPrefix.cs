/*
 DESCRIPTION:
 Given a string, output its longest prefix which contains only digits.
 Example:
 For inputString="123aa1", the output should be
 longestDigitsPrefix(inputString) = "123".
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Main.CodeFights
{
    public static class LongestDigitsPrefix
    {
        public static string Solve(string inputString)
        {
            List<string> list = new List<string>();
            string current = "";

            if (Char.IsDigit(inputString[0]))
            {
                foreach (char ch in inputString)
                {
                    if (Char.IsDigit(ch))
                    {
                        current += ch;
                    }
                    else
                    {
                        if (current != "") list.Add(current);
                        current = "";
                    }
                }
            }
            list.Add(current);
            return list.OrderByDescending(x => x.Length).ToList().FirstOrDefault();
        }
    }
}
