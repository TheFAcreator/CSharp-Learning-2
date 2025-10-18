string toRemove = Console.ReadLine();
string initial = Console.ReadLine();
int index = 0;
while ((index = initial.IndexOf(toRemove)) != -1)
    initial = initial.Remove(index, toRemove.Length);
Console.WriteLine(initial);