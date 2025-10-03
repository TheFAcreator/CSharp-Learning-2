namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void Draw()
        {
            DrawLine(this.width, '*');
            for (int i = 0; i < this.height - 2; i++)
            {
                Console.Write('*');
                Console.Write(new string(' ', this.width - 2));
                Console.WriteLine('*');
            }
            DrawLine(this.width, '*');
        }

        private void DrawLine(int length, char symbol)
        {
            Console.WriteLine(new string(symbol, length));
        }
    }
}
