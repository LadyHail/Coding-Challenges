using System.Linq;

namespace Main.Codility
{
    public static class PermMissingElem
    {
        public static int Solve(int[] A)
        {
            decimal capacity = A.Length + 1;
            decimal expectedSum = (capacity * (capacity + 1)) / 2;
            decimal sum = A.Sum(x => (decimal)x);

            return (int)(expectedSum - sum);
        }
    }
}
