using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> students = new();
        for (int i = 0; i < n; i++)
        {
            string analyzer1 = Console.ReadLine();
            string analyzer2 = Console.ReadLine();
            if (!students.ContainsKey(analyzer1))
                students[analyzer1] = new();
            students[analyzer1].Add(double.Parse(analyzer2));
        }
        students = students.Where(j => j.Value.Average() >= 4.5).ToDictionary(name => name.Key, grade => grade.Value);
        foreach (var kvp in students)
            Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
    }
}