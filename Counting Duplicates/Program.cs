using System;
using System.Linq;

namespace Counting_Duplicates
{
    class Program
    {
        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }

        static void Main(string[] args)
        {
            string input = "aabBcde";
            Console.WriteLine(DuplicateCount(input));
            Console.ReadKey();
        }
    }
}
