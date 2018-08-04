using System.Collections.Generic;
using System.Linq;

/*
 DESCRIPTION: 
 You are given an array of desired filenames in the order of their creation. Since two files cannot have equal names, 
 the one which comes later will have an addition to its name in a form of (k), where k is the smallest positive integer 
 such that the obtained name is not used yet.
 Return an array of names that will be given to the files.
 Example
 For names = ["doc", "doc", "image", "doc(1)", "doc"], the output should be
 fileNaming(names) = ["doc", "doc(1)", "image", "doc(1)(1)", "doc(2)"].
 */

namespace Main.CodeFights
{
    public static class FileNaming
    {
        public static string[] fileNaming(string[] names)
        {
            HashSet<string> temp = new HashSet<string>();

            foreach (string item in names)
            {
                if (!temp.Contains(item))
                {
                    temp.Add(item);
                }
                else
                {
                    int counter = 1;
                    while (temp.Any(x => x == item + "(" + counter.ToString() + ")"))
                    {
                        counter++;
                    }
                    temp.Add(item + "(" + counter.ToString() + ")");
                }
            }

            return temp.ToArray();
        }
    }
}
