int s = int.Parse(Console.ReadLine());
int s2 = int.Parse(Console.ReadLine());
int s3 = int.Parse(Console.ReadLine());
int all = s + s2 + s3;
int min = 0;
int sec = all % 60;
if (all >= 60)
{
    min = all / 60;
}
if (sec < 10)
{
    Console.WriteLine($"{min}:0{sec}");
}
else
{
    Console.WriteLine($"{min}:{sec}");
}