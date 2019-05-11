using System.Linq;

namespace Main.Codility
{
    public class Distinct
    {
        public static int Solve(int[] A)
        {
            return A.GroupBy(x => x).Count();
        }
    }
}
