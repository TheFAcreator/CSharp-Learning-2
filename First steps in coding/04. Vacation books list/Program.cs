int pages = int.Parse(Console.ReadLine());
int pagesPerDay = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());
int totalHoursNeeded = pages / pagesPerDay;
int hoursNeeded = totalHoursNeeded / days;
Console.WriteLine(hoursNeeded);