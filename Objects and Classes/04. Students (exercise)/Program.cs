class Student
{
    public Student(string first, string last, double grade)
    {
        firstName = first;
        lastName = last;
        this.grade = grade;
    }
    public string firstName;
    public string lastName;
    public double grade;
}
class Progrma
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        System.Collections.Generic.List<Student> students = new();
        for (int i = 0; i < n; i++)
        {
            string[] analyzer = Console.ReadLine().Split();
            students.Add(new Student(analyzer[0], analyzer[1], double.Parse(analyzer[2])));
        }
        students = students.OrderBy(n => n.grade).ToList();
        students.Reverse();
        foreach (Student student in students)
            Console.WriteLine($"{student.firstName} {student.lastName}: {student.grade:f2}");
    }
}