class Student
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}
class Program
{
    static void Main()
    {
        string input = "";
        System.Collections.Generic.List<Student> students = new();
        while ((input = Console.ReadLine()) != "end")
        {
            string[] analyzer = input.Split();
            students.Add(new Student() { FirstName = analyzer[0], LastName = analyzer[1], Age = int.Parse(analyzer[2]), HomeTown = analyzer[3] });
        }
        string filter = Console.ReadLine();
        foreach (Student student in students)
        {
            if (student.HomeTown == filter) Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
        }
    }
}