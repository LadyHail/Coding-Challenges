using System;

namespace Main.Codility
{
    public static class FrogJmp
    {
        public static int Solve(int X, int Y, int D)
        {
            double result = Math.Ceiling(((double)(Y - X) / D));
            return (int)result;
        }
    }
}
