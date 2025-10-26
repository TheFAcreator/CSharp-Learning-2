decimal a = decimal.Parse(Console.ReadLine());
decimal b = decimal.Parse(Console.ReadLine());
decimal dif = Math.Abs(a - b);
if (dif >= 0.000001m) Console.WriteLine("False");
else Console.WriteLine("True");