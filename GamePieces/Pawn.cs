using Board;
using Utils;

namespace GamePieces
{
    class Pawn : ChessPiece
    {
        public const int Points = 1;

        public Pawn(string color) : base("Pawn", color)
        {
        }

        public override bool IsValidMove(ChessBoard board, string fromPosition, string toPosition)
        {
            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));

            var movePositions = new List<string>();

            if (this.Color == "White")
            {
                if (board.PositionToPiece(fromColIdx, fromRowIdx - 1) == null)
                    movePositions.Add(board.IsValidPosition(this, fromColIdx, fromRowIdx - 1)!);
                if (fromRowIdx == 6 && board.PositionToPiece(fromColIdx, fromRowIdx - 2) == null)
                    movePositions.Add(board.IsValidPosition(this, fromColIdx, fromRowIdx - 2)!);

                if (board.PositionToPiece(fromColIdx + 1, fromRowIdx - 1) != null)
                    movePositions.Add(board.IsValidPosition(this, fromColIdx + 1, fromRowIdx - 1)!);
                if (board.PositionToPiece(fromColIdx - 1, fromRowIdx - 1) != null)
                    movePositions.Add(board.IsValidPosition(this, fromColIdx - 1, fromRowIdx - 1)!);
            }
            else
            {
                if (board.PositionToPiece(fromColIdx, fromRowIdx + 1) == null)
                    movePositions.Add(board.IsValidPosition(this, fromColIdx, fromRowIdx + 1)!);
                if (fromRowIdx == 1 && board.PositionToPiece(fromColIdx, fromRowIdx + 2) == null)
                    movePositions.Add(board.IsValidPosition(this, fromColIdx, fromRowIdx + 2)!);

                if (board.PositionToPiece(fromColIdx + 1, fromRowIdx + 1) != null)
                    movePositions.Add(board.IsValidPosition(this, fromColIdx + 1, fromRowIdx + 1)!);
                if (board.PositionToPiece(fromColIdx - 1, fromRowIdx + 1) != null)
                    movePositions.Add(board.IsValidPosition(this, fromColIdx - 1, fromRowIdx + 1)!);
            }

            return movePositions.Contains(toPosition.ToUpper());
        }
    }
}
