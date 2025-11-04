HashSet<string> parkingLot = new();
string input = "";
while((input = Console.ReadLine()) != "END")
{
    string[] analyzer = input.Split(", ");
    string command = analyzer[0];
    string plateNumber = analyzer[1];
    if (command == "IN")
    {
        parkingLot.Add(plateNumber);
    }
    else if (command == "OUT")
    {
        parkingLot.Remove(plateNumber);
    }
}
if(parkingLot.Count == 0)
{
    Console.WriteLine("Parking Lot is Empty");
}
else
{
    foreach (string plate in parkingLot)
    {
        Console.WriteLine(plate);
    }
}