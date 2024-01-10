int numOfPages = int.Parse(Console.ReadLine());
int pagesReadPerHour = int.Parse(Console.ReadLine());
int numOfDays = int.Parse(Console.ReadLine());

int totalHoursToReadBook = numOfPages / pagesReadPerHour;
int requiredHoursPerDay = totalHoursToReadBook / numOfDays;

Console.WriteLine(requiredHoursPerDay);
