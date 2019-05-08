using System.Linq;

/*
 DESCRIPTION:
 Given a string, find the number of different characters in it.
 Example:
 For s = "cabca", the output should be
 differentSymbolsNaive(s) = 3.
 There are 3 different characters a, b and c.
*/

namespace Main.CodeFights
{
    public static class DifferentSymbolsNaive
    {
        public static int Solve(string s)
        {
            return s.GroupBy(x => x).Count();
        }
    }
}
