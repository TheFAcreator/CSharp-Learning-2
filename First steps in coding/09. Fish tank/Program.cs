int len = int.Parse(Console.ReadLine());
int wid = int.Parse(Console.ReadLine());
int hei = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());
int vol = len * wid * hei;
double vol2 = (vol - (vol * percent / 100)) / 1000;
Console.WriteLine(vol2);