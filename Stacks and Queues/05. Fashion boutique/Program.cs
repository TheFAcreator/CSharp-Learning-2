Stack<byte> clothes = new(Console.ReadLine().Split().Select(byte.Parse));
byte rackCapacity = byte.Parse(Console.ReadLine());
int racks = 1;
int sum = 0;
while (clothes.Count > 0)
{
    if(sum + clothes.Peek() <= rackCapacity)
    {
        sum += clothes.Pop();
    }
    else
    {
        racks++;
        sum = 0;
    }
}
Console.WriteLine(racks);