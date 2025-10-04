namespace Shapes
{
    public class Rectangle : Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }

        public override string Draw()
        {
            return base.Draw();
        }
    }
}
