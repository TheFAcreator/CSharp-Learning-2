// Program may not work correctly in some cases of input (chance of proper output - 90/100)

string input = "";
while ((input = Console.ReadLine()) != "END")
{
    Console.Write(input + " is ");
    bool success = long.TryParse(input, out _);
    if (success) Console.Write("integer ");
    else
    {
        success = decimal.TryParse(input, out _);
        if (success) Console.Write("floating point ");
        else
        {
            success = char.TryParse(input, out _);
            if (success) Console.Write("character ");
            else
            {
                success = bool.TryParse(input, out _);
                if (success) Console.Write("boolean ");
                else Console.Write("string ");
            }
        }
    }
    Console.WriteLine("type");
}