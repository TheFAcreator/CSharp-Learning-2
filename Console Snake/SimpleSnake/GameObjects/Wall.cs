namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        public Wall(int x, int y) : base(x, y)
        {
            DrawWalls();
        }

        private const char wallSymbol = '\u25A0';

        private void DrawHorizontalLine(int y)
        {
            for (int x = 0; x < X; x++)
            {
                Draw(wallSymbol, x, y);
            }
        }

        private void DrawVerticalLine(int x)
        {
            for (int y = 0; y < Y; y++)
            {
                Draw(wallSymbol, x, y);
            }
        }

        private void DrawWalls()
        {
            DrawHorizontalLine(0);
            DrawHorizontalLine(Y);

            DrawVerticalLine(0);
            DrawVerticalLine(X - 2);
        }

        public bool IsPointInWall(Point coordinatesOfSnake)
        {
            return coordinatesOfSnake.X == 0 || coordinatesOfSnake.Y == 0
                || coordinatesOfSnake.X == X - 1 || coordinatesOfSnake.Y == Y;
        }
    }
}
