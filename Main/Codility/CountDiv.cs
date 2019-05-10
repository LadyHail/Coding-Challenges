namespace Main.Codility
{
    public class CountDiv
    {
        public static int Solve(int A, int B, int K)
        {
            int b = B / K;
            int a = (A > 0 ? (A - 1) / K : 0);
            if (A == 0)
            {
                b++;
            }
            return b - a;
        }
    }
}
