using Board;
using Interface;

namespace GamePieces
{
    class Bishop : ChessPiece
    {
        public const int Points = 3;

        public Bishop(string color) : base("Bishop", color)
        {
        }

        public override bool IsValidMove(ChessBoard board, string fromPosition, string toPosition)
        {
            throw new NotImplementedException();
        }

        public override ChessPiece MovePiece(ChessBoard board, string fromPosition, string toPosition)
        {
            throw new NotImplementedException();
        }
    }
}
