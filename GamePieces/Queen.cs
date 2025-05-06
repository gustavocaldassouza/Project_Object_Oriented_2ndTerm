using Board;
using Utils;

namespace GamePieces
{
    class Queen : ChessPiece
    {
        private readonly Rook _rook;
        private readonly Bishop _bishop;

        public const int Points = 9;

        public Queen(string color) : base("Queen", color)
        {
            _rook = new Rook(color);
            _bishop = new Bishop(color);
        }

        public override bool IsValidMove(ChessBoard board, string fromPosition, string toPosition)
        {
            bool isRookMoveValid = _rook.IsValidMove(board, fromPosition, toPosition);
            bool isBishopMoveValid = _bishop.IsValidMove(board, fromPosition, toPosition);

            return isRookMoveValid || isBishopMoveValid;
        }
    }
}
