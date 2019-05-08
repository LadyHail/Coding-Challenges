using System.Linq;

/*
 DESCRIPTION:
 A string is said to be beautiful if b occurs in it no more times than a; c occurs in it no more times than b; etc.
 Given a string, check whether it is beautiful.
 Example
    For inputString = "bbbaacdafe", the output should be
    isBeautifulString(inputString) = true;
    For inputString = "aabbb", the output should be
    isBeautifulString(inputString) = false;
    For inputString = "bbc", the output should be
    isBeautifulString(inputString) = false.

*/

namespace Main.CodeFights
{
    public static class IsBeautifulString
    {
        public static bool Solve(string inputString)
        {
            var sorted = Enumerable.Range('a', inputString.Max(c => c) - 'a' + 1).Select(i => (char)i).ToArray();
            for (var i = 1; i < sorted.Length; i++)
                if (inputString.Count(c => c == sorted[i]) > inputString.Count(c => c == sorted[i - 1]))
                    return false;

            return true;
        }
    }
}
