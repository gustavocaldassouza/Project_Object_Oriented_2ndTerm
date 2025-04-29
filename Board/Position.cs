namespace Board
{
    public class Position
    {
        public char File;
        public int Rank;
        public Position(char file, int rank)
        {
            if (file >= 'A' && file <= 'H')
            {
                File = file;
            }
            else
            {
                Console.WriteLine("Invalid file.");
            }
            if (rank >= 1 && rank <= 8)
            {
                Rank = rank;
            }
            else
            {
                Console.WriteLine("Invalid rank.");
            }
        }

        public override string ToString()
        {
            return File + Rank.ToString();
        }

        public bool IsEqual(Position other)
        {
            return this.Rank == other.Rank && this.File == other.File;
        }
    }
}
