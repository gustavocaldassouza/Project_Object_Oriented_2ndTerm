using Board;
using Utils;

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
            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));

            var movePositions = new List<string>();

            // up-right diagonal
            for (int i = 1; i < 8; i++)
            {
                string? pos = board.IsValidPosition(this, fromColIdx + i, fromRowIdx - i);
                if (pos == string.Empty)
                    break;
                movePositions.Add(pos!);
            }

            // up-left diagonal
            for (int i = 1; i < 8; i++)
            {
                string? pos = board.IsValidPosition(this, fromColIdx - i, fromRowIdx - i);
                if (pos == string.Empty)
                    break;
                movePositions.Add(pos!);
            }

            // down-right diagonal
            for (int i = 1; i < 8; i++)
            {
                string? pos = board.IsValidPosition(this, fromColIdx + i, fromRowIdx + i);
                if (pos == string.Empty)
                    break;
                movePositions.Add(pos!);
            }

            // down-left diagonal
            for (int i = 1; i < 8; i++)
            {
                string? pos = board.IsValidPosition(this, fromColIdx - i, fromRowIdx + i);
                if (pos == string.Empty)
                    break;
                movePositions.Add(pos!);
            }

            return movePositions.Contains(toPosition.ToUpper());
        }

    }
}
