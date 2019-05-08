/*
 DESCRIPTION:
 Given a position of a knight on the standard chessboard, find the number of different moves the knight can perform.
 The knight can move to a square that is two squares horizontally and one square vertically, or two squares vertically 
 and one square horizontally away from it. The complete move therefore looks like the letter L. Check out the image 
 below to see all valid moves for a knight piece that is placed on one of the central squares.

 Example
    For cell = "a1", the output should be
    chessKnight(cell) = 2.

    For cell = "c2", the output should be
    chessKnight(cell) = 6.
*/

namespace Main.CodeFights
{
    public static class ChessKnight
    {
        public static int Solve(string cell)
        {
            int count = 0;
            if (cell[0] - 2 >= 97 && char.GetNumericValue(cell[1]) - 1 >= 1) count++;
            if (cell[0] - 2 >= 97 && char.GetNumericValue(cell[1]) + 1 <= 8) count++;
            if (cell[0] - 1 >= 97 && char.GetNumericValue(cell[1]) - 2 >= 1) count++;
            if (cell[0] - 1 >= 97 && char.GetNumericValue(cell[1]) + 2 <= 8) count++;
            if (cell[0] + 1 <= 104 && char.GetNumericValue(cell[1]) - 2 >= 1) count++;
            if (cell[0] + 1 <= 104 && char.GetNumericValue(cell[1]) + 2 <= 8) count++;
            if (cell[0] + 2 <= 104 && char.GetNumericValue(cell[1]) - 1 >= 1) count++;
            if (cell[0] + 2 <= 104 && char.GetNumericValue(cell[1]) + 1 <= 8) count++;
            return count;
        }
    }
}
