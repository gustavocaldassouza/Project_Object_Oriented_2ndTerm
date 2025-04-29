using GamePieces;

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
                Board[1, i] = new Pawn("White");
                Board[6, i] = new Pawn("Black");
            }

            Board[0, 0] = new Rook("White");
            Board[0, 7] = new Rook("White");
            Board[7, 0] = new Rook("Black");
            Board[7, 7] = new Rook("Black");

            Board[0, 1] = new Knight("White");
            Board[0, 6] = new Knight("White");
            Board[7, 1] = new Knight("Black");
            Board[7, 6] = new Knight("Black");

            Board[0, 2] = new Bishop("White");
            Board[0, 5] = new Bishop("White");
            Board[7, 2] = new Bishop("Black");
            Board[7, 5] = new Bishop("Black");

            Board[0, 3] = new Queen("White");
            Board[7, 3] = new Queen("Black");

            Board[0, 4] = new King("White");
            Board[7, 4] = new King("Black");
        }

        public void DisplayBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Board[i, j] != null)
                    {
                        Console.Write(Board[i, j].ToString() + " ");
                    }
                    else
                    {
                        Console.Write("_");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
