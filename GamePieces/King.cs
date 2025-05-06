using Board;
using Utils;

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
            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));

            var movePositions = new List<string>
            {
                board.IsValidPosition(this, fromColIdx, fromRowIdx - 1)!,
                board.IsValidPosition(this, fromColIdx, fromRowIdx + 1)!,
                board.IsValidPosition(this, fromColIdx - 1, fromRowIdx)!,
                board.IsValidPosition(this, fromColIdx + 1, fromRowIdx)!,
                board.IsValidPosition(this, fromColIdx - 1, fromRowIdx - 1)!,
                board.IsValidPosition(this, fromColIdx + 1, fromRowIdx - 1)!,
                board.IsValidPosition(this, fromColIdx - 1, fromRowIdx + 1)!,
                board.IsValidPosition(this, fromColIdx + 1, fromRowIdx + 1)!
            };

            return movePositions.Contains(toPosition.ToUpper());
        }
    }
}
