using System;
using System.IO;
using Main.Other.Hierarchy;

namespace Main
{
    internal class _Main
    {
        private static void Main(string[] args)
        {
            Start s = new Start();
            s.Solve();

            Console.ReadKey();
        }

        private static void ChangeMethodsName()
        {
            string path = @"";
            string[] files = Directory.GetFiles(path);
            int counter = 0;

            foreach (string file in files)
            {
                string[] text = File.ReadAllLines(file);
                string className = null;
                int index = -1;
                string replaceText = null;

                for (int i = 0; i < text.Length; i++)
                {
                    if (className != null)
                    {
                        int replaceIndex = text[i].IndexOf(className, StringComparison.CurrentCultureIgnoreCase);
                        if (replaceIndex != -1)
                        {
                            string newItem = text[i].Remove(replaceIndex, className.Length);
                            replaceText = newItem.Insert(replaceIndex, "Solve");
                            index = i;
                        }
                    }

                    int classIndex = text[i].IndexOf("class ");

                    if (classIndex != -1)
                    {
                        className = text[i].Substring(classIndex + 6);
                    }
                }

                if (index != -1)
                {
                    text[index] = replaceText;
                    File.WriteAllLines(file, text);
                    Console.WriteLine(file);
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
