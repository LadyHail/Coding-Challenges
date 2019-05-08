/*
 DESCRIPTION: 
 Imagine a white rectangular grid of n rows and m columns divided into two parts by
 a diagonal line running from the upper left to the lower right corner. Now let's paint
 the grid in two colors according to the following rules:

    A cell is painted black if it has at least one point in common with the diagonal;
    Otherwise, a cell is painted white.

 Count the number of cells painted black.

 Example:

    For n = 3 and m = 4, the output should be
    countBlackCells(n, m) = 6.

    There are 6 cells that have at least one common point with the diagonal and therefore are painted black.

    For n = 3 and m = 3, the output should be
    countBlackCells(n, m) = 7.

    7 cells have at least one common point with the diagonal and are painted black.
 */


namespace Main.CodeFights
{
    public static class CountBlackCells
    {
        private static int gcd(int n, int m)
        {
            while (m > 0)
            {
                int temp = n;
                n = m;
                m = temp % m;
            }

            return n;
        }

        public static int Solve(int n, int m)
        {
            if (n == m)
            {
                return (n + 2 * (n - 1));
            }

            if (n == 1 || m == 1)
            {
                return n * m;
            }

            return n + m - gcd(n, m) + (gcd(n, m) - 1) * 2;
        }
    }
}
