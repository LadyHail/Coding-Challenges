using System;
using System.Linq;
using System.Text.RegularExpressions;

/*
 DESCRIPTION: 
 CodeMaster has just returned from shopping. He scanned the check of the items he bought and gave the resulting string to Ratiorg to figure out the total number of purchased items. Since Ratiorg is a bot he is definitely going to automate it, so he needs a program that sums up all the numbers which appear in the given input.
 Help Ratiorg by writing a function that returns the sum of numbers that appear in the given inputString.
 Example
 For inputString = "2 apples, 12 oranges", the output should be
 sumUpNumbers(inputString) = 14.
 */

namespace Main.CodeFights
{
    public static class SumUpNumbers
    {
        public static int Solve(string inputString)
        {
            Regex reg = new Regex(@"([0-9])+");
            int counter = 0;
            Func<string, int> func =
            value =>
                {
                    counter += Convert.ToInt32(value);
                    return counter;
                };
            var matches = reg.Matches(inputString).OfType<Match>().Select(x => func(x.Value)).ToList().LastOrDefault();

            return matches;
        }
    }
}
