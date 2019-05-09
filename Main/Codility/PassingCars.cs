namespace Main.Codility
{
    public class PassingCars
    {
        public static int Solve(int[] A)
        {
            int zeros = 0;
            int count = 0;

            foreach (int i in A)
            {
                if (i == 0)
                {
                    zeros++;
                }
                else
                {
                    count += zeros;
                }

                if (count > 1000000000)
                {
                    return -1;
                }
            }

            return count;
        }
    }
}
