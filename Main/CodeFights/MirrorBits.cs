using System;
using System.Collections.Generic;
using System.Linq;

/*
 DESCRIPTION:
 Reverse the order of the bits in a given integer.

 Example:
    For a = 97, the output should be
    mirrorBits(a) = 67.

    97 equals to 1100001 in binary, which is 1000011 after mirroring, and that is 67 in base 10.

    For a = 8, the output should be
    mirrorBits(a) = 1.
*/

namespace Main.CodeFights
{
    public static class MirrorBits
    {
        public static int mirrorBits(int a)
        {
            string b = Convert.ToString(a, 2);
            IEnumerable<char> c = b.Reverse();
            string r = string.Concat(c);

            return Convert.ToInt32(r, 2);
        }
    }
}
