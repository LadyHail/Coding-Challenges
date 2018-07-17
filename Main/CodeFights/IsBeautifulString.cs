using System.Linq;

namespace Main.CodeFights
{
    public static class IsBeautifulString
    {
        public static bool isBeautifulString(string inputString)
        {
            var sorted = Enumerable.Range('a', inputString.Max(c => c) - 'a' + 1).Select(i => (char)i).ToArray();
            for (var i = 1; i < sorted.Length; i++)
                if (inputString.Count(c => c == sorted[i]) > inputString.Count(c => c == sorted[i - 1]))
                    return false;

            return true;
        }
    }
}
