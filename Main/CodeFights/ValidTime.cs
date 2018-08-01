using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 DESCRIPTION:
 Check if the given string is a correct time representation of the 24-hour clock.
 Example
    For time = "13:58", the output should be
    validTime(time) = true;
    For time = "25:51", the output should be
    validTime(time) = false;
    For time = "02:76", the output should be
    validTime(time) = false.
*/

namespace Main.CodeFights
{
    public static class ValidTime
    {
        public static bool validTime(string time)
        {
            try
            {
                DateTime t = DateTime.Parse(time);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
