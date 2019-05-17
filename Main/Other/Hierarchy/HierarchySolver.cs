using System;
using System.Collections.Generic;
using System.Linq;

namespace Main.Other.Hierarchy
{
    public class HierarchySolver
    {
        public void Solve()
        {
            string[] data = DataAccess.GetData(@"D:\Program Files\Projekty\Szkoleniowe\Coding challenges\Main\Other\Hierarchy\data.csv");
            IEnumerable<Person> people = DataAccess.DataToPeople(data);

            IEnumerable<string> companies = people.Select(x => x.Company).Distinct();

            foreach (string c in companies)
            {
                IEnumerable<Person> peopleInCompany = people.Where(x => x.Company == c).Select(x => x);
                Hierarchy hierarchy = new Hierarchy(peopleInCompany);
                Node[] list = hierarchy.GetHierarchy().ToArray();
                PrintHierarchy(list);
            }
        }

        private static void PrintHierarchy(Node[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(list[i].Value.Name + ", " + list[i].Value.Position + ", " + list[i].Value.Company);
                }
                else
                {
                    string str = new string(' ', list[i].depth * 4);
                    Console.WriteLine(str + "-> " + list[i].Value.Name + ", " + list[i].Value.Position + ", " + list[i].Value.Company);
                }
            }
        }
    }
}
