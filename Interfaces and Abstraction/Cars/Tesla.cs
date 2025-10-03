namespace Cars
{
    public class Tesla : IElectricCar
    {   
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }
        
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public override string ToString()
        {
            return $"{this.Color} Tesla {this.Model} with {this.Battery} Batteries";
        }
    }
}
