namespace Main.Codility
{
    public class GenomicRangeQuery
    {
        public static int[] Solve(string S, int[] P, int[] Q)
        {
            int[,] nucleotides = new int[3, S.Length + 1];

            short a, c, g;
            for (int i = 0; i < S.Length; i++)
            {
                a = 0; c = 0; g = 0;
                if (S[i] == 'A')
                {
                    a = 1;
                }
                else if (S[i] == 'C')
                {
                    c = 1;
                }
                else if (S[i] == 'G')
                {
                    g = 1;
                }

                nucleotides[0, i + 1] = nucleotides[0, i] + a;
                nucleotides[1, i + 1] = nucleotides[1, i] + c;
                nucleotides[2, i + 1] = nucleotides[2, i] + g;
            }

            int[] result = new int[P.Length];

            for (int i = 0; i < P.Length; i++)
            {
                int from = P[i];
                int to = Q[i] + 1;

                if (nucleotides[0, to] - nucleotides[0, from] > 0)
                {
                    result[i] = 1;
                }
                else if (nucleotides[1, to] - nucleotides[1, from] > 0)
                {
                    result[i] = 2;
                }
                else if (nucleotides[2, to] - nucleotides[2, from] > 0)
                {
                    result[i] = 3;
                }
                else
                {
                    result[i] = 4;
                }
            }

            return result;
        }
    }
}
