using System;

/*
 DESCRIPTION:
 Given the positions of a white bishop and a black pawn on the standard chess board, determine whether the bishop can capture the pawn in one move.
 The bishop has no restrictions in distance for each move, but is limited to diagonal movement. 
*/

namespace Main.CodeFights
{
    public static class BishopAndPawn
    {
        public static bool bishopAndPawn(string bishop, string pawn)
        {
            return Math.Abs(bishop[0] - pawn[0]) == Math.Abs(bishop[1] - pawn[1]);
        }
    }
}
