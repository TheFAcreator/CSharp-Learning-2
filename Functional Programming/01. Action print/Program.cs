﻿Action<string> print = Console.WriteLine;

Console.ReadLine().Split().ToList().ForEach(j => print(j));