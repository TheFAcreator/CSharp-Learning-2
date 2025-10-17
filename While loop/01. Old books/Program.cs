string book = Console.ReadLine();
int check = 0;
while (true)
{
    string book1 = Console.ReadLine();
    if (book1 == "No More Books")
    {
        Console.WriteLine($"The book you search is not here!\nYou checked {check} books.");
        break;
    }
    else
    {
        if (book1 == book)
        {
            Console.WriteLine($"You checked {check} books and found it.");
            break;
        }
        else check++;
    }
}