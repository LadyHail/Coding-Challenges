using System.Collections.Generic;

/*
 DESCRIPTION: 
 Given an integer product, find the smallest positive (i.e. greater than 0) integer the product of whose digits is equal to product. If there is no such integer, return -1 instead.
 Example
    For product = 12, the output should be
    digitsProduct(product) = 26;
    For product = 19, the output should be
    digitsProduct(product) = -1.
 */

namespace Main.CodeFights
{
    public static class DigitsProduct
    {
        public static int digitsProduct(int product)
        {
            List<int> list = new List<int>();
            int sum = 0;

            if (product == 0) return 10;
            if (product == 1) return 1;

            for (int div = 9; div > 1; div--)
            {
                while (product % div == 0)
                {
                    product /= div;
                    list.Add(div);
                }
            }
            if (product > 1) return -1;

            for (int i = list.Count - 1; i >= 0; i--)
            {
                sum = 10 * sum + list[i];
            }
            return sum;
        }
    }
}
