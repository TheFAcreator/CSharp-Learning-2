string username = Console.ReadLine();
string password = string.Empty;
for (int i = 0; i < username.Length; i++)
{
    password += username[username.Length - 1 - i];
}
int count = 0;
while (true)
{
    string input = Console.ReadLine();
    if (input == password)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
    count++;
    if (count == 4)
    {
        Console.WriteLine($"User {username} blocked!");
        break;
    }
    Console.WriteLine("Incorrect password. Try again.");
}