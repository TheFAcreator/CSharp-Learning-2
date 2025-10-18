string input = Console.ReadLine();
string result = string.Empty;
for (int i = 0; i < input.Length; i++) result += (char)(input[i] + 3);
Console.WriteLine(result);