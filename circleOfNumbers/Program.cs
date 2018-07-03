using System;

namespace circleOfNumbers
{
    class Program
    {
        public static int circleOfNumbers(int n, int firstNumber)
        {
            int even = n / 2;
            int result = firstNumber > even ? firstNumber - even : even == firstNumber ? 0 : even + firstNumber;

            return result;
        }

        static void Main(string[] args)
        {
            int n = 10;
            int first = 7;
            Console.WriteLine(circleOfNumbers(n, first));
        }
    }
}
