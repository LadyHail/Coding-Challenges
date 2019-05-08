using System;
using System.Collections.Generic;
using System.Linq;

/*
 DESCRIPTION:
 Given an array of equal-length strings, check if it is possible to rearrange the strings in such a way that after the rearrangement the strings at consecutive positions would differ by exactly one character.
 Example:
 For inputArray = ["aba", "bbb", "bab"], the output should be
 stringsRearrangement(inputArray) = false.
 All rearrangements don't satisfy the description condition.
 
 For inputArray = ["ab", "bb", "aa"], the output should be
 stringsRearrangement(inputArray) = true.
 Strings can be rearranged in the following way: "aa", "ab", "bb".
*/

namespace Main.CodeFights
{
    public static class StringsRearrangement
    {
        static bool Solve(string[] inputArray)
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
    }
}
