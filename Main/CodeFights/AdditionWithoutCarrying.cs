/*
 DESCRIPTION:
 A little boy is studying arithmetics. He has just learned how to add two integers, 
 written one below another, column by column. But he always forgets about the important part - carrying.

 Given two integers, find the result which the little boy will get.

 Note: the boy used this site as the source of knowledge, feel free to check it out too 
 if you are not familiar with column addition.

 Example:
 For param1 = 456 and param2 = 1734, the output should be
 additionWithoutCarrying(param1, param2) = 1180.

   456
  1734
+ ____
  1180

 The little boy goes from right to left:

    6 + 4 = 10 but the little boy forgets about 1 and just writes down 0 in the last column
    5 + 3 = 8
    4 + 7 = 11 but the little boy forgets about the leading 1 and just writes down 1 under 4 and 7.
    There is no digit in the first number corresponding to the leading digit of the second one, 
    so the little boy imagines that 0 is written before 456. Thus, he gets 0 + 1 = 1.
*/

using System;

namespace Main.CodeFights
{
    public static class AdditionWithoutCarrying
    {
        public static int Solve(int param1, int param2)
        {
            string p1 = param1.ToString();
            string p2 = param2.ToString();
            int result = 0;

            for (int index = 0; index < Math.Max(p1.Length, p2.Length); index++)
            {
                int a1 = 0, a2 = 0;

                if (index < p1.Length)
                {
                    string s1 = string.Empty;
                    s1 += p1[p1.Length - 1 - index];
                    a1 = int.Parse(s1);
                }

                if (index < p2.Length)
                {
                    string s2 = string.Empty;
                    s2 += p2[p2.Length - 1 - index];
                    a2 = int.Parse(s2);
                }

                int total = (a1 + a2);

                if (total >= 10)
                {
                    total -= 10;
                }

                result += total * (int)Math.Pow(10, index);
            }

            return result;
        }
    }
}
