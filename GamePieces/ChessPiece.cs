using Board;
using Interface;

namespace GamePieces
{
    abstract class ChessPiece : IMovable
    {
        public abstract bool IsValidMove(ChessBoard board, string fromPosition, string toPosition);
        public abstract ChessPiece MovePiece(
            ChessBoard board,
            string fromPosition,
            string toPosition
        );
    }
}
