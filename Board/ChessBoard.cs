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

        public void SetUpBoard() { }

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
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
