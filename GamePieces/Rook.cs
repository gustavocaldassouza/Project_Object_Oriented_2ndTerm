using Board;
using Utils;

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
            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));

            var movePositions = new List<string>();

            // up
            for (int i = 1; i < 8; i++)
            {
                string? pos = board.IsValidPosition(this, fromColIdx, fromRowIdx - i);
                if (pos == string.Empty)
                    break;
                movePositions.Add(pos!);
            }
            // down
            for (int i = 1; i < 8; i++)
            {
                string? pos = board.IsValidPosition(this, fromColIdx, fromRowIdx + i);
                if (pos == string.Empty)
                    break;
                movePositions.Add(pos!);
            }
            // left
            for (int i = 1; i < 8; i++)
            {
                string? pos = board.IsValidPosition(this, fromColIdx - i, fromRowIdx);
                if (pos == string.Empty)
                    break;
                movePositions.Add(pos!);
            }
            // right
            for (int i = 1; i < 8; i++)
            {
                string? pos = board.IsValidPosition(this, fromColIdx + i, fromRowIdx);
                if (pos == string.Empty)
                    break;
                movePositions.Add(pos!);
            }

            return movePositions.Contains(toPosition.ToUpper());
        }
    }
}
