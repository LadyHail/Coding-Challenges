using System.Text.RegularExpressions;

/*
 DESCRIPTION:
 Define a word as a sequence of consecutive English letters. Find the longest word from the given string.
 Example
 For text = "Ready, steady, go!", the output should be
 longestWord(text) = "steady".
*/

namespace Main.CodeFights
{
    public static class LongestWord
    {
        public static string Solve(string text)
        {
            Regex reg = new Regex(@"([A-Za-z])+");
            var matches = reg.Matches(text);
            string max = "";

            foreach (Match m in matches)
            {
                if (m.Length > max.Length)
                {
                    max = m.ToString();
                }
            }

            return max;
        }
    }
}
