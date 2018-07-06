using System.Collections.Generic;

/*
 DESCRIPTION:
 Given two cells on the standard chess board, determine whether they have the same color or not.
 Example:
 For cell1 = "A1" and cell2 = "C3", the output should be
 chessBoardCellColor(cell1, cell2) = true.
*/

namespace Main.CodeFights
{
    public static class ChessBoardCellColor
    {
        public static bool chessBoardCellColor(string cell1, string cell2)
        {
            List<string> black = new List<string>();
            List<string> white = new List<string>();

            for (int i = 65; i <= 72; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        black.Add(((char)i + j.ToString()).ToString());
                    }
                    else if (i % 2 == 0 && j % 2 == 0)
                    {
                        black.Add(((char)i + j.ToString()).ToString());
                    }
                    else
                    {
                        white.Add(((char)i + j.ToString()).ToString());
                    }
                }
            }

            bool result = black.Contains(cell1) ? black.Contains(cell2) : white.Contains(cell1) ? white.Contains(cell2) : false;

            return result;
        }
    }
}
