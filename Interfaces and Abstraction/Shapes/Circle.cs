namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            double in1 = radius - 0.4;
            double out1 = radius + 0.4;

            for(double y = radius; y >= -radius; y--)
            {
                for(double x = -radius; x < out1; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= in1 * in1 && value <= out1 * out1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
