using GamePieces;

namespace Board
{
    class ChessBoard
    {
        ChessPiece[,] board;

        public ChessBoard()
        {
            board = new ChessPiece[8, 8];
        }

        public void SetUpBoard() { }

        public void DisplayBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i, j] != null)
                    {
                        Console.Write(board[i, j].GetType().Name + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
