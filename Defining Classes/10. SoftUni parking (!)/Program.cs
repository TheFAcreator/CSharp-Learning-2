namespace SoftUniParking
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }

        public override string ToString()
        {
            return $"Make: {Make}" +
                   $"\nModel: {Model}" +
                   $"\nHorsePower: {HorsePower}" +
                   $"\nRegistrationNumber: {RegistrationNumber}";
        }
    }
    public class Parking
    {
        public List<Car> Cars { get; set; }
        private int capacity;
        public int Count => Cars.Count;

        public Parking(int capacity)
        {
            Cars = new List<Car>();
            this.capacity = capacity;
        }

        public string AddCar(Car car)
        {
            if (Cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (Count >= capacity)
            {
                return "Parking is full!";
            }

            Cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }
        public string RemoveCar(string registrationNumber)
        {
            Car car = Cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
            if (car == null)
            {
                return "Car with that registration number, doesn't exist!";
            }

            Cars.Remove(car);
            return $"Successfully removed {registrationNumber}";
        }
        public Car GetCar(string registrationNumber)
        {
            return Cars.First(c => c.RegistrationNumber == registrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string regNum in registrationNumbers)
            {
                RemoveCar(regNum);
            }
        }
    }
    public class StartUp
    {
        public static void Main(string[] args)
        {
            
        }
    }
}