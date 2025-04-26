using Board;
using Interface;

namespace GamePieces
{
    class Queen : ChessPiece
    {
        public const int Points = 9;

        public Queen(string color) : base("Queen", color)
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
