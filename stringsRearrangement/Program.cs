using System;
using System.Collections.Generic;
using System.Linq;

namespace stringsRearrangement
{
    class Program
    {
        static bool stringsRearrangement(string[] inputArray)
        {
            IEnumerable<IEnumerable<string>> permutations = GetPermutations(inputArray.ToList());

            foreach (var item in permutations)
            {
                string[] permutation = item.ToArray();
                List<bool> matches = new List<bool>();

                for (int index = 1; index < permutation.Length; index++)
                {
                    int diff = permutation[index - 1].Where((c1, c2) => c1 != permutation[index][c2]).Count();

                    if (diff == 1)
                    {
                        matches.Add(true);
                    }
                    else
                    {
                        matches.Add(false);
                    }
                }

                if (matches.All(x => x == true))
                {
                    return true;
                }
            }
            return false;
        }

        private static List<string[]> GetPermutations(List<string> input)
        {
            List<string[]> result = new List<string[]>();

            Action<int> permute = null;
            permute = start =>
            {
                if (start == input.Count)
                {
                    result.Add(input.ToArray());
                }
                else
                {
                    List<string> swaps = new List<string>();
                    for (int i = start; i < input.Count; i++)
                    {
                        if (swaps.Contains(input[i])) continue;
                        swaps.Add(input[i]);

                        Swap(input, start, i);
                        permute(start + 1);
                        Swap(input, start, i);
                    }
                }
            };

            permute(0);

            return result;
        }

        private static void Swap(List<string> input, int index1, int index2)
        {
            string selected = input[index1];
            input[index1] = input[index2];
            input[index2] = selected;
        }

        static void Main(string[] args)
        {
            //string[] input = { "aba", "bbb", "bab" };
            //string[] input = { "ab", "bb", "aa" };
            //string[] input = {"abc", "bef", "bcc", "bec", "bbc", "bdc"};
            //string[] input = { "abc", "bbc", "bcc", "bec", "bef", "bdc" };
            string[] input = { "abc", "abx", "axx", "abx", "abc" };
            Console.WriteLine(stringsRearrangement(input));
            Console.ReadKey();
        }
    }
}
