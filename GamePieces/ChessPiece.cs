using Board;
using Interface;

namespace GamePieces
{
    public abstract class ChessPiece : IMovable //classe base para as peças de xadrez nao posso usa sozinha
    {

        public string Name;
        public string Color;

        public ChessPiece(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public override string ToString()
        {
            string symbol;

            if (Name == "Knight") // criei essa condica pro cavalo nao confundir com o k de king
            {
                symbol = "N";
            }
            else
            {
                symbol = Name[0].ToString();
            }

            return Color[0].ToString() + symbol;
        }


        public abstract bool IsValidMove(
            ChessBoard board,
            string fromPosition,
            string toPosition);
        public abstract ChessPiece MovePiece(
            ChessBoard board,
            string fromPosition,
            string toPosition
        );
    }
}
