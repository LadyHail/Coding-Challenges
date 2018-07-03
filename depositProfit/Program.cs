using System;

namespace depositProfit
{
    class Program
    {
        public static int depositProfit(int deposit, int rate, int threshold)
        {
            int result = 0;
            double current = deposit;
            while (current < threshold)
            {
                current += (current * rate) / 100;
                result++;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int deposit = 100;
            int rate = 2;
            int threshold = 170;
            Console.WriteLine(depositProfit(deposit, rate, threshold));
            Console.ReadKey();
        }
    }
}
