using Board;
using GamePieces;

namespace Interface
{
    interface IMovable
    {
        bool IsValidMove(ChessBoard board, String fromPosition, String toPosition);
        ChessPiece MovePiece(ChessBoard board, String fromPosition, String toPosition);
    }
}
