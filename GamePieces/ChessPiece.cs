using Board;
using Interface;
using Utils;

namespace GamePieces
{
    public abstract class ChessPiece : IMovable
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public ChessPiece(string name, string color)
        {
            if (name.ToLower() == "knight" || name.ToLower() == "bishop" || name.ToLower() == "rook" || name.ToLower() == "queen" || name.ToLower() == "king" || name.ToLower() == "pawn" || name.ToLower() == "error")
            {
                Name = name;
            }
            else
            {
                Console.WriteLine("Invalid name. Use 'Knight', 'Bishop', 'Rook', 'Queen', 'King' or 'Pawn'.");
            }
            if (color.ToLower() == "white" || color.ToLower() == "black" || color.ToLower() == "none")
            {
                Color = color;
            }
            else
            {
                Console.WriteLine("Invalid color. Use 'white' or 'black'.");
            }
        }

        public override string ToString()
        {
            return Color.First().ToString().ToUpper() + Name.First().ToString().ToUpper();
        }

        public abstract bool IsValidMove(
            ChessBoard board,
            string fromPosition,
            string toPosition);

        public ChessPiece MovePiece(
            ChessBoard board,
            string fromPosition,
            string toPosition
        )
        {
            ChessPiece pieceFrom = board.PositionToPiece(fromPosition);

            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));
            int toColIdx = BoardUtils.FileCharToIdx(toPosition[0]);
            int toRowIdx = BoardUtils.RankIntToIdx(int.Parse(toPosition[1].ToString()));

            board.Board[toRowIdx, toColIdx] = pieceFrom;
            board.Board[fromRowIdx, fromColIdx] = null;

            return pieceFrom;
        }
    }
}
