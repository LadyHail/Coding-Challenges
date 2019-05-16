using System.Collections.Generic;
using System.IO;

namespace Main.Other.Hierarchy
{
    public static class DataAccess
    {
        public static string[] GetData(string path)
        {
            try
            {
                return File.ReadAllLines(path);
            }
            catch
            {
                return null;
            }
        }

        public static IEnumerable<Person> DataToPeople(string[] data)
        {
            List<Person> result = new List<Person>();

            foreach (string d in data)
            {
                string[] line = d.Split(',');

                int id = int.Parse(line[0]);
                int parentId = int.Parse(line[1]);
                Person person = new Person(id, parentId, line[2], line[3]);
                result.Add(person);
            }

            return result;
        }
    }
}
