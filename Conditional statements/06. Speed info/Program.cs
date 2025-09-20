double v = double.Parse(Console.ReadLine());
if (v <= 10) Console.WriteLine("slow");
else if (v <= 50) Console.WriteLine("average");
else if (v <= 150) Console.WriteLine("fast");
else if (v <= 1000) Console.WriteLine("ultra fast");
else Console.WriteLine("extremely fast");