using System;
using System.Linq;

namespace Main.Codility
{
    public static class BinaryGap
    {
        public static int Solve(int N)
        {
            string n = Convert.ToString(N, 2);

            int result = 0;

            while (n.Length > 0)
            {
                string a = string.Concat(n.TakeWhile(x => x != '0'));
                string b = string.Concat(n.Skip(a.Length).TakeWhile(x => x == '0'));
                string c = string.Concat(n.Skip(a.Length + b.Length).TakeWhile(x => x != '0'));

                n = n.Remove(0, a.Length + b.Length);

                if (c != "")
                {
                    int count = b.Count(x => x == '0');
                    if (count > result)
                    {
                        result = count;
                    }
                }
            }

            return result;

            // Alternative solution
            //return Convert
            //    .ToString(N, 2)
            //    .Trim('0')
            //    .Split(new[] { '1' })
            //    .Max(x => x.Length);
        }
    }
}
