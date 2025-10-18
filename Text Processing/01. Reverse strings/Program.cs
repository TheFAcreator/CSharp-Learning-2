string input = "";
while ((input = Console.ReadLine()) != "end")
{
    string result = new string(input.Reverse().ToArray());
    Console.WriteLine(input + " = " + result);
}