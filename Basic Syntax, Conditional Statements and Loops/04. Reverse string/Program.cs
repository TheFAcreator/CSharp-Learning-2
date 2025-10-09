string input = Console.ReadLine();
char[] array = input.ToCharArray();
Array.Reverse(array);
input = new string(array);
Console.WriteLine(input);