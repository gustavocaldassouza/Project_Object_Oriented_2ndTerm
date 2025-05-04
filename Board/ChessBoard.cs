using GamePieces;
using Utils;

namespace Board
{
    public class ChessBoard
    {
        public ChessPiece[,] Board;

        public ChessBoard()
        {
            Board = new ChessPiece[8, 8];
        }

        public void SetUpBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                Board[1, i] = new Pawn("Black");
                Board[6, i] = new Pawn("White");
            }

            Board[0, 0] = new Rook("Black");
            Board[0, 7] = new Rook("Black");
            Board[7, 0] = new Rook("White");
            Board[7, 7] = new Rook("White");

            Board[0, 1] = new Knight("Black");
            Board[0, 6] = new Knight("Black");
            Board[7, 1] = new Knight("White");
            Board[7, 6] = new Knight("White");

            Board[0, 2] = new Bishop("Black");
            Board[0, 5] = new Bishop("Black");
            Board[7, 2] = new Bishop("White");
            Board[7, 5] = new Bishop("White");

            Board[0, 3] = new Queen("Black");
            Board[7, 3] = new Queen("White");

            Board[0, 4] = new King("Black");
            Board[7, 4] = new King("White");
        }

        public void DisplayBoard()
        {
            for (int row = 0; row < 8; row++)
            {
                Console.Write(8 - row + " ");
                for (int col = 0; col < 8; col++)
                {
                    if (Board[row, col] != null)
                    {
                        Console.Write(Board[row, col].ToString() + " ");
                    }
                    else
                    {
                        Console.Write("__ ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A  B  C  D  E  F  G  H");
        }

        public ChessPiece PositionToPiece(string position)
        {
            int column = BoardUtils.FileCharToIdx(position[0]);
            int row = position[1] == '-' ? -1 : BoardUtils.RankIntToIdx(int.Parse(position[1].ToString()));
            if (column < 0 || column > 7 || row < 0 || row > 7)
            {
                return new Error();
            }
            return Board[row, column];
        }

        public ChessPiece PositionToPiece(int column, int row)
        {
            if (column < 0 || column > 7 || row < 0 || row > 7)
            {
                return new Error();
            }
            return Board[row, column];
        }

        public string? IsValidPosition(ChessPiece basePiece, int col, int row)
        {
            if (row >= 0 && row < 8 && col >= 0 && col < 8)
            {
                ChessPiece piece = this.PositionToPiece(col, row);
                if (piece != null && basePiece.Color != piece.Color || piece == null)
                {
                    var result = $"{BoardUtils.FileIntToChar(col)}{BoardUtils.RankIdxToInt(row)}";
                    return result;
                }
                return string.Empty;
            }
            return null;
        }
    }
}
