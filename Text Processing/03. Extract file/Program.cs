string filePath = Console.ReadLine();
string[] analyzer = filePath.Split(".");
string[] analyzer2 = analyzer[0].Split("\\");
Console.WriteLine("File name: " + analyzer2[analyzer2.Length - 1]);
Console.WriteLine("File extension: " + analyzer[1]);