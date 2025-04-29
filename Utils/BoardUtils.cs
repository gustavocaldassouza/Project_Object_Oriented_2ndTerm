using GamePieces;
using Board;

namespace Utils
{
    public static class BoardUtils
    {
        public static int FileCharToIdx(char fileChar)
        {
            switch (char.ToLower(fileChar))
            {
                case 'a': return 0;
                case 'b': return 1;
                case 'c': return 2;
                case 'd': return 3;
                case 'e': return 4;
                case 'f': return 5;
                case 'g': return 6;
                case 'h': return 7;
            }
            return -1;
        }

        public static char FileIntToChar(int fileIdx)
        {
            switch (fileIdx)
            {
                case 0: return 'A';
                case 1: return 'B';
                case 2: return 'C';
                case 3: return 'D';
                case 4: return 'E';
                case 5: return 'F';
                case 6: return 'G';
                case 7: return 'H';
            }

            return ' ';
        }

        public static int RankIntToIdx(int rank)
        {
            return 8 - rank;
        }

        public static int RankIdxToInt(int idx)
        {
            return 8 - idx;
        }

        public static ChessPiece PositionToPiece(ChessBoard board, string position)
        {
            int column = FileCharToIdx(position[0]);
            int row = RankIntToIdx(int.Parse(position[1].ToString()));

            return board.Board[row, column];
        }
    }
}
