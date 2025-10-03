namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; }

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public override string ToString()
        {
            return $"{this.Color} Seat {this.Model}";
        }
    }
}
