using System;
using System.Text.RegularExpressions;

/*
 DESCRIPTION:
 Correct variable names consist only of English letters, digits and underscores and they can't start with a digit.
 Check if the given string is a correct variable name.
 Example:
 For name = "var_1__Int", the output should be
 variableName(name) = true;
 For name = "qq-q", the output should be
 variableName(name) = false;
 For name = "2w2", the output should be
 variableName(name) = false.
*/

namespace Main.CodeFights
{
    public static class VariableName
    {
        public static bool Solve(string name)
        {
            if (Char.IsDigit(name[0]))
            {
                return false;
            }
            Regex expression = new Regex("^[a-zA-Z0-9_]*$");

            return expression.IsMatch(name);
        }
    }
}
