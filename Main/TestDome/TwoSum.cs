using System;
using System.Collections.Generic;

internal class TwoSum
{
    public static Tuple<int, int> Solve(IList<int> list, int sum)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < list.Count; i++)
        {
            int diff = sum - list[i];

            if (dict.ContainsKey(diff))
            {
                return Tuple.Create(i, dict[diff]);
            }
            else
            {
                dict[list[i]] = i;
            }
        }

        return null;
    }

    //public static void Main(string[] args)
    //{
    //    Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
    //    if (indices != null)
    //    {
    //        Console.WriteLine(indices.Item1 + " " + indices.Item2);
    //    }
    //}
}