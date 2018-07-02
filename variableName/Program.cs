using System;
using System.Text.RegularExpressions;

namespace variableName
{
    class Program
    {
        static bool variableName(string name)
        {
            if (Char.IsDigit(name[0]))
            {
                return false;
            }
            Regex expression = new Regex("^[a-zA-Z0-9_]*$");

            return expression.IsMatch(name);
        }

        static void Main(string[] args)
        {
            string input = "2var_1__Int";
            Console.WriteLine(variableName(input));
            Console.ReadKey();
        }
    }
}
