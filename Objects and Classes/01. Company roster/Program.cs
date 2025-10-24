using System.Collections.Generic;
class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> departmentNames = new();
        List<List<Employee>> employees = new();
        for (int i = 0; i < n; i++)
        {
            string[] analyzer = Console.ReadLine().Split();
            if (!departmentNames.Contains(analyzer[2]))
            {
                departmentNames.Add(analyzer[2]);
                employees.Add(new());
            }
            employees[departmentNames.IndexOf(analyzer[2])].Add(new Employee() { Name = analyzer[0], Salary = double.Parse(analyzer[1]), Department = analyzer[2] });
        }
        var maxAvr = employees.OrderByDescending(list => list.Average(j => j.Salary)).FirstOrDefault();
        Console.WriteLine($"Highest Average Salary: {departmentNames[employees.IndexOf(maxAvr)]}");
        maxAvr = maxAvr.OrderByDescending(k => k.Salary).ToList();
        foreach (Employee employee in maxAvr) Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
    }
}