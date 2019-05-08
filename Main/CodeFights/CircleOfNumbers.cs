/*
 DESCRIPTION: 
 Consider integer numbers from 0 to n - 1 written down along the circle in such a way that the distance between any two neighboring numbers is equal (note that 0 and n - 1 are neighboring, too).
 Given n and firstNumber, find the number which is written in the radially opposite position to firstNumber.
 Example:
 For n = 10 and firstNumber = 2, the output should be
 circleOfNumbers(n, firstNumber) = 7.
 */

namespace Main.CodeFights
{
    public static class CircleOfNumbers
    {
        public static int Solve(int n, int firstNumber)
        {
            int even = n / 2;
            int result = firstNumber > even ? firstNumber - even : even == firstNumber ? 0 : even + firstNumber;

            return result;
        }
    }
}
