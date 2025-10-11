int start = 1;
int end = int.Parse(Console.ReadLine());
List<Predicate<int>> dividers = Console.ReadLine().Split().Select(h => new Predicate<int>(n => n % int.Parse(h) == 0)).ToList();

for(int i = start; i <= end; i++)
{
    if(dividers.Where(f => !f(i)).FirstOrDefault() == null)
    {
        Console.Write(i + " ");
    }
    //if(dividers.All(d => d(i)))
    //{
    //    Console.Write(i + " ");
    //}
}