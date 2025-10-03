namespace Telephony;
public class StartUp
{
    public static void Main()
    {
        string[] phoneNumbers = Console.ReadLine().Split();
        string[] urls = Console.ReadLine().Split();

        ICallable smartphone = new Smartphone();
        ICallable stationaryPhone = new StationaryPhone();
        
        foreach (var phoneNumber in phoneNumbers)
        {
            if(phoneNumber.Any(char.IsLetter)) Console.WriteLine("Invalid number!");

            else if(phoneNumber.Length == 10) Console.WriteLine(smartphone.Call(phoneNumber));
            else Console.WriteLine(stationaryPhone.Call(phoneNumber));
        }

        IBrowseable smartphone2 = new Smartphone();
        foreach (var url in urls)
        {
            if(url.Any(char.IsDigit)) Console.WriteLine("Invalid URL!");

            else Console.WriteLine(smartphone2.Browse(url));
        }
    }
}