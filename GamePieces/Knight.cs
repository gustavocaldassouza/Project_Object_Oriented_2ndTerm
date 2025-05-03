using Board;
using Utils;

namespace GamePieces
{
    class Knight : ChessPiece
    {
        public const int Points = 3;

        public Knight(string color) : base("Knight", color)
        {
        }

        public override string ToString()
        {
            return Color!.First().ToString().ToUpper() + "N";
        }

        public override bool IsValidMove(ChessBoard board, string fromPosition, string toPosition)
        {
            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));

            var movePositions = new List<string>();
            movePositions.Add(board.IsValidPosition(this, fromColIdx + 1, fromRowIdx - 2)!);
            movePositions.Add(board.IsValidPosition(this, fromColIdx - 1, fromRowIdx - 2)!);
            movePositions.Add(board.IsValidPosition(this, fromColIdx + 1, fromRowIdx + 2)!);
            movePositions.Add(board.IsValidPosition(this, fromColIdx - 1, fromRowIdx + 2)!);
            movePositions.Add(board.IsValidPosition(this, fromColIdx + 2, fromRowIdx - 1)!);
            movePositions.Add(board.IsValidPosition(this, fromColIdx - 2, fromRowIdx - 1)!);
            movePositions.Add(board.IsValidPosition(this, fromColIdx + 2, fromRowIdx + 1)!);
            movePositions.Add(board.IsValidPosition(this, fromColIdx - 2, fromRowIdx + 1)!);

            return movePositions.Contains(toPosition.ToUpper());
        }
    }
}
