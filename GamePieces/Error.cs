using Board;
using GamePieces;

namespace GamePieces
{
    public class Error : ChessPiece
    {
        public Error() : base("Error", "None")
        {
        }

        public override bool IsValidMove(ChessBoard board, string fromPosition, string toPosition)
        {
            return false;
        }

        public override ChessPiece MovePiece(ChessBoard board, string fromPosition, string toPosition)
        {
            return this;
        }
    }
}