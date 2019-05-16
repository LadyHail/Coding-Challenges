using System;
using System.Collections.Generic;
using System.Linq;

namespace Main.Other.Hierarchy
{
    public class Start
    {
        public void Solve()
        {
            string[] data = DataAccess.GetData(@"D:\Program Files\Projekty\Szkoleniowe\Coding challenges\Main\Other\Hierarchy\data.csv");
            IEnumerable<Person> people = DataAccess.DataToPeople(data);

            Hierarchy hierarchy = new Hierarchy(people);
            Node[] list = hierarchy.GetHierarchy().ToArray();
            PrintHierarchy(list);
        }

        private static void PrintHierarchy(Node[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(list[i].Value.Name + ", " + list[i].Value.Position);
                }
                else
                {
                    string str = new string(' ', list[i].depth * 4);
                    Console.WriteLine(str + "-> " + list[i].Value.Name + ", " + list[i].Value.Position);
                }
            }
        }
    }
}
