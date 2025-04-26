using GamePieces;
using Board;

namespace Utils
{
    public static class BoardUtils
    {
        public static int FileCharToIdx(char fileChar)
        {
            return fileChar - 'A'; // A=0, B=1, ..., H=7
        }

        public static char FileIntToChar(int fileIdx)
        {
            return (char)('A' + fileIdx); // 0=A, 1=B, ..., 7=H
        }

        public static int RankIntToIdx(int rank)
        {
            return 8 - rank; // 8=0, 1=7
        }

        public static int RankIdxToInt(int idx)
        {
            return 8 - idx; // 0=8, 7=1
        }

        public static ChessPiece PositionToPiece(ChessBoard board, string position)
        {
            int file = FileCharToIdx(position[0]);
            int rank = int.Parse(position[1].ToString());
            int row = RankIntToIdx(rank);

            return board.Board[row, file];
        }
    }
}
