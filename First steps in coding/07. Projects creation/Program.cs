string architectName = Console.ReadLine();
int projectCount = int.Parse(Console.ReadLine());
int neededHours = projectCount * 3;
Console.WriteLine($"The architect {architectName} will need {neededHours} hours to complete {projectCount} project/s.");