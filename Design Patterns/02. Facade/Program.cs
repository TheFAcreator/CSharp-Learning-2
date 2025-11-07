using Façade;

Car car = new CarBuilderFaçade()
    .Info
        .WithType("Sedan")
        .WithColor("Red")
        .WithNumberOfDoors(4)
    .Address
        .InCity("New York")
        .AtAddress("123 Main St")
    .Build();

Console.WriteLine(car); // Output: 4 Sedan Red - New York, 123 Main St