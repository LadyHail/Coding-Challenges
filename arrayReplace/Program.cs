using System;
using System.Linq;

namespace arrayReplace
{
    class Program
    {
        public static int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            int[] result = inputArray.Select(e => e == elemToReplace ? substitutionElem : e).ToArray();
            return result;
        }

        static void Main(string[] args)
        {
            int[] input = { 1, 2, 1 };
            int replace = 1;
            int substitution = 3;

            int[] result = arrayReplace(input, replace, substitution);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
