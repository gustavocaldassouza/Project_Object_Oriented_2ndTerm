using Board;
using Interface;

namespace GamePieces
{
    class King : ChessPiece
    {
        public const int Points = Int32.MaxValue;

        public King(string color) : base("King", color)
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
