using System;
using System.Linq;

namespace alphabeticShift
{
    class Program
    {
        public static string alphabeticShift(string inputString)
        {
            return new String(inputString.Select(c => c == 122 ? (char)97 : (char)(c + 1)).ToArray());
        }

        static void Main(string[] args)
        {
            string input = "crazy";

            Console.WriteLine(alphabeticShift(input));
            Console.ReadKey();
        }
    }
}
