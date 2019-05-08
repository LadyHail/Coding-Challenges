/*
 DESCRIPTION:
 Note: Try to solve this task in-place (with O(1) additional memory), since this is what you'll be asked to do during an interview.
 You are given an n x n 2D matrix that represents an image. Rotate the image by 90 degrees (clockwise).
 */

namespace Main.CodeFights
{
    public static class RotateImage
    {
        public static int[][] Solve(int[][] a)
        {
            int[][] n = new int[a.Length][];

            for (int i = 0; i < a.Length; i++)
            {
                int[] inner = new int[a.Length];
                int row = a.Length - 1;
                for (int j = 0; j < a.Length; j++, row--)
                {
                    inner[j] = a[row][i];
                }
                n[i] = new int[inner.Length];
                inner.CopyTo(n[i], 0);
            }

            return n;
        }
    }
}
