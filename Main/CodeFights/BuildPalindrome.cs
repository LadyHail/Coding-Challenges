/*
 DESCRIPTION:
 Given a string, find the shortest possible string which can be achieved by adding characters to the end of initial string to make it a palindrome.
 Example
 For st = "abcdc", the output should be
 buildPalindrome(st) = "abcdcba".
*/

using System.Linq;

namespace Main.CodeFights
{
    public static class BuildPalindrome
    {
        private static string Reverse(string s)
        {
            if (s == null) return null;           
            return new string(s.Reverse().ToArray());
        }

        private static bool checkPalindrome(string s)
        {
            if (s.Length % 2 == 0)
                return s.Substring(0, s.Length / 2) == Reverse(s.Substring(s.Length / 2));
            else
                return s.Substring(0, s.Length / 2) == Reverse(s.Substring(s.Length / 2 + 1));
        }

        public static string Solve(string st)
        {
            for (int i = 0; i < st.Length; i++)
            {
                if (checkPalindrome(st + Reverse(st.Substring(0, i))))
                    return st + Reverse(st.Substring(0, i));
            }
            return st + Reverse(st);
        }
    }
}
