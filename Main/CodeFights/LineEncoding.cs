/*
 DESCRIPTION:
 Given a string, return its encoding defined as follows:
 First, the string is divided into the least possible number of disjoint substrings consisting of identical characters
 for example, "aabbbc" is divided into ["aa", "bbb", "c"]
 Next, each substring with length greater than one is replaced with a concatenation of its length and the repeating character
 for example, substring "bbb" is replaced by "3b"
 Finally, all the new strings are concatenated together in the same order and a new string is returned.
 Example
 For s = "aabbbc", the output should be
 lineEncoding(s) = "2a3bc".
*/

namespace Main.CodeFights
{
    public static class LineEncoding
    {
        public static string Solve(string s)
        {
            char current = new char();
            char temp = new char();
            string count = null;
            string result = null;

            foreach (char c in s)
            {
                temp = c;
                if (temp != current)
                {
                    if (current != '\0')
                    {
                        result += count?.Length != 1 ? count.Length + current.ToString() : current.ToString();
                    }
                    count = null;
                    current = c;
                }
                count += c;
            }

            if (current != '\0')
            {
                result += count?.Length != 1 ? count.Length + current.ToString() : current.ToString();
            }

            return result;
        }
    }
}
