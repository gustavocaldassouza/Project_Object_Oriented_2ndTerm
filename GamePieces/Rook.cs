using Board;
using Interface;

namespace GamePieces
{
    class Rook : ChessPiece
    {
        public const int Points = 5;

        public Rook(string color) : base("Rook", color)
        {
        }

        public override bool IsValidMove(ChessBoard board, string fromPosition, string toPosition)
        {
            throw new NotImplementedException("Rook movement logic not implemented yet.");
        }

        public override ChessPiece MovePiece(ChessBoard board, string fromPosition, string toPosition)
        {
            ChessPiece? piece = null;
            if (IsValidMove(board, fromPosition, toPosition))
            {
                piece = board.Board[Convert.ToInt32(toPosition[1].ToString()), Convert.ToInt32(toPosition[0].ToString())];
                return piece;
            }
            return piece!;
        }
    }
}
